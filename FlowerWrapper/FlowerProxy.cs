﻿using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.InteropServices;
using FlowerWrapper.Win32;
using System.Text;
using System.Threading.Tasks;
using Livet;
using FlowerWrapper.Interface;
using System.Diagnostics;

namespace FlowerWrapper
{
    public class FlowerProxy
    {
        private readonly IConnectableObservable<Session> connectableSessionSource;
        private readonly IConnectableObservable<Session> apiSource;
        private readonly LivetCompositeDisposable compositeDisposable;

        public IProxySettings UpstreamProxySettings { get; set; }

        public FlowerProxy()
        {
            this.compositeDisposable = new LivetCompositeDisposable();

            this.connectableSessionSource = Observable
                .FromEvent<SessionStateHandler, Session>(
                    action => new SessionStateHandler(action),
                    h => FiddlerApplication.AfterSessionComplete += h,
                    h => FiddlerApplication.AfterSessionComplete -= h)
                .Publish();

            this.apiSource = this.connectableSessionSource
                .Where(s => s.PathAndQuery.StartsWith("/api/v1"))
                .Where(s => s.oResponse.MIMEType.Equals("text/plain"))
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
            FiddlerApplication.Startup(proxy, FiddlerCoreStartupFlags.ChainToUpstreamGateway);
            FiddlerApplication.BeforeRequest += this.SetUpstreamProxyHandler;

            SetIESettings("localhost:" + proxy);

            this.compositeDisposable.Add(this.connectableSessionSource.Connect());
            this.compositeDisposable.Add(this.apiSource.Connect());
        }

        private static void SetIESettings(string proxyUri)
        {
            // ReSharper disable InconsistentNaming
            const int INTERNET_OPTION_PROXY = 38;
            const int INTERNET_OPEN_TYPE_PROXY = 3;
            // ReSharper restore InconsistentNaming

            INTERNET_PROXY_INFO proxyInfo;
            proxyInfo.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
            proxyInfo.proxy = Marshal.StringToHGlobalAnsi(proxyUri);
            proxyInfo.proxyBypass = Marshal.StringToHGlobalAnsi("local");

            var proxyInfoSize = Marshal.SizeOf(proxyInfo);
            var proxyInfoPtr = Marshal.AllocCoTaskMem(proxyInfoSize);
            Marshal.StructureToPtr(proxyInfo, proxyInfoPtr, true);

            NativeMethods.InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, proxyInfoPtr, proxyInfoSize);
        }

        private void SetUpstreamProxyHandler(Session requestingSession)
        {
            var settings = this.UpstreamProxySettings;
            if (settings == null) return;

            var useGateway = !string.IsNullOrEmpty(settings.Host) && settings.IsEnabled;
            if (!useGateway || (IsSessionSSL(requestingSession) && !settings.IsEnabledOnSSL)) return;

            var gateway = settings.Host.Contains(":")
                // IPv6 带有冒号，需要加上[]
                ? string.Format("[{0}]:{1}", settings.Host, settings.Port)
                : string.Format("{0}:{1}", settings.Host, settings.Port);

            requestingSession["X-OverrideGateway"] = gateway;
        }

        internal static bool IsSessionSSL(Session session)
        {
            // 「http://www.dmm.com:433/」の場合もあり、これは Session.isHTTPS では判定できない
            return session.isHTTPS || session.fullUrl.StartsWith("https:") || session.fullUrl.Contains(":443");
        }
    }
}
