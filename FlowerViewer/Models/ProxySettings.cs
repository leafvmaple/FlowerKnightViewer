using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FlowerWrapper.Interface;
using Livet;

namespace FlowerViewer.Models
{
    public class ProxySettings : NotificationObject, IProxySettings
    {
        private string _FtpHost = "127.0.0.1";
        public string FtpHost
        {
            get { return _FtpHost; }
            set
            {
                _FtpHost = value;
                this.RaisePropertyChanged();
            }
        }

        private ushort _FtpPort = 8099;
        public ushort FtpPort
        {
            get { return _FtpPort; }
            set
            {
                _FtpPort = value;
                this.RaisePropertyChanged();
            }
        }

        private string _HttpHost = "127.0.0.1";
        public string HttpHost
        {
            get { return _HttpHost; }
            set
            {
                _HttpHost = value;
                this.RaisePropertyChanged();
            }
        }

        private ushort _HttpPort = 8099;
        public ushort HttpPort
        {
            get { return _HttpPort; }
            set
            {
                _HttpPort = value;
                this.RaisePropertyChanged();
            }
        }

        private string _HttpsHost = "127.0.0.1";
        public string HttpsHost
        {
            get { return _HttpsHost; }
            set
            {
                _HttpsHost = value;
                this.RaisePropertyChanged();
            }
        }

        private ushort _HttpsPort = 8099;
        public ushort HttpsPort
        {
            get { return _HttpsPort; }
            set
            {
                _HttpsPort = value;
                this.RaisePropertyChanged();
            }
        }

        private bool _IsUseHttpProxyForAllProtocols = true;
        public bool IsUseHttpProxyForAllProtocols
        {
            get { return _IsUseHttpProxyForAllProtocols; }
            set
            {
                _IsUseHttpProxyForAllProtocols = value;
                this.RaisePropertyChanged();
            }
        }

        private string _SocksHost = "127.0.0.1";
        public string SocksHost
        {
            get { return _SocksHost; }
            set
            {
                _SocksHost = value;
                this.RaisePropertyChanged();
            }
        }

        private ushort _SocksPort = 8099;
        public ushort SocksPort
        {
            get { return _SocksPort; }
            set
            {
                _SocksPort = value;
                this.RaisePropertyChanged();
            }
        }

        private ProxyType _Type = ProxyType.SpecificProxy;
        public ProxyType Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
