using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Livet;
using FlowerWrapper.Interface;
using System.Diagnostics;
using System.Runtime.Serialization.Json;
using System.IO;
using Nekoxy;

namespace FlowerWrapper
{
    public partial class FlowerProxy
    {
        private readonly IConnectableObservable<Session> connectableSessionSource;
        private readonly IConnectableObservable<Session> apiSource;
        private readonly LivetCompositeDisposable compositeDisposable;

        public IObservable<Session> ApiSessionSource
        {
            get { return this.apiSource.AsObservable(); }
        }

        public IProxySettings UpstreamProxySettings { get; set; }

        public int ListeningPort { get; private set; } = 37564;

        public FlowerProxy()
        {
            this.compositeDisposable = new LivetCompositeDisposable();

            this.connectableSessionSource = Observable
                .FromEvent<Action<Session>, Session>(
                    action => action,
                    h => HttpProxy.AfterSessionComplete += h,
                    h => HttpProxy.AfterSessionComplete -= h)
                .Publish();

            this.apiSource = this.connectableSessionSource
                .Where(s => s.Request.PathAndQuery.StartsWith("/api/v1") || s.Request.PathAndQuery.StartsWith("/social/rpc"))
                .Where(s => s.Response.MimeType.Equals("text/plain") || s.Response.MimeType.Equals("application/json"))
            #region .Do(debug)
#if DEBUG
                .Do(session =>
                {
                    Debug.WriteLine("==================================================");
                    Debug.WriteLine("Fiddler session: ");
                    Debug.WriteLine(session);
                    Debug.WriteLine("");
                })
#endif
            #endregion
                .Publish();
        }

        public void Startup(int proxy = 37564)
        {
            this.ListeningPort = proxy;

            HttpProxy.Startup(proxy, false, false);
            this.ApplyProxySettings();

            this.compositeDisposable.Add(this.connectableSessionSource.Connect());
            this.compositeDisposable.Add(this.apiSource.Connect());
        }

        public void Shutdown()
        {
            this.compositeDisposable.Dispose();
            HttpProxy.Shutdown();
        }

        private void ApplyProxySettings()
        {
            this.ApplyUpstreamProxySettings();
            this.ApplyDownstreamProxySettings();
        }

        private void ApplyUpstreamProxySettings()
        {
            if (UpstreamProxySettings.IsEnable)
            {
                HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.SpecificProxy, this.UpstreamProxySettings.HttpHost, this.UpstreamProxySettings.HttpPort);
            }
            else
            {
                HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.DirectAccess);
            }

            /*switch (this.UpstreamProxySettings?.Type)
            {
                case ProxyType.DirectAccess:
                    HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.DirectAccess);
                    break;
                case ProxyType.SystemProxy:
                    HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.SystemProxy);
                    break;
                case ProxyType.SpecificProxy:
                    HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.SpecificProxy, this.UpstreamProxySettings.HttpHost, this.UpstreamProxySettings.HttpPort);
                    break;
                default:
                    HttpProxy.UpstreamProxyConfig = new ProxyConfig(ProxyConfigType.SystemProxy);
                    break;
            }*/
        }

        private void ApplyDownstreamProxySettings()
        {
            var config = HttpProxy.UpstreamProxyConfig;
            switch (config.Type)
            {
                case ProxyConfigType.SystemProxy:
                    WinInetUtil.SetProxyInProcessForNekoxy(this.ListeningPort);
                    break;
                case ProxyConfigType.SpecificProxy:
                    if (!string.IsNullOrWhiteSpace(config.SpecificProxyHost))
                    {
                        if (this.UpstreamProxySettings.IsUseHttpProxyForAllProtocols)
                        {
                            WinInetUtil.SetProxyInProcess(
                                $"http=127.0.0.1:{this.ListeningPort};"
                                + $"https={this.UpstreamProxySettings.HttpHost}:{this.UpstreamProxySettings.HttpPort};"
                                + $"ftp={this.UpstreamProxySettings.HttpHost}:{this.UpstreamProxySettings.HttpPort};"
                                , "local");
                        }
                        else
                        {
                            WinInetUtil.SetProxyInProcess(
                                $"http=127.0.0.1:{this.ListeningPort};"
                                + ((!string.IsNullOrWhiteSpace(this.UpstreamProxySettings.HttpsHost))
                                    ? $"https={this.UpstreamProxySettings.HttpsHost}:{this.UpstreamProxySettings.HttpsPort};" : string.Empty)
                                + ((!string.IsNullOrWhiteSpace(this.UpstreamProxySettings.FtpHost))
                                    ? $"ftp={this.UpstreamProxySettings.FtpHost}:{this.UpstreamProxySettings.FtpPort};" : string.Empty)
                                + ((!string.IsNullOrWhiteSpace(this.UpstreamProxySettings.SocksHost))
                                    ? $"socks={this.UpstreamProxySettings.SocksHost}:{this.UpstreamProxySettings.SocksPort};" : string.Empty)
                                , "local");
                        }
                    }
                    else
                    {
                        WinInetUtil.SetProxyInProcess($"http=127.0.0.1:{this.ListeningPort}", "local");
                    }
                    break;
                case ProxyConfigType.DirectAccess:
                    WinInetUtil.SetProxyInProcess($"http=127.0.0.1:{this.ListeningPort}", "local");
                    break;
            }
        }
    }
}
