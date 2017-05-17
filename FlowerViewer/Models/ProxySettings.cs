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
    [Serializable]
    public class ProxySettings : NotificationObject, IProxySettings
    {
        private bool _IsEnable;

        public bool IsEnable
        {
            get { return _IsEnable; }
            set
            {
                _IsEnable = value;
                this.RaisePropertyChanged();
            }
        }

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

        private UInt16 _FtpPort = 8099;
        public UInt16 FtpPort
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

        private UInt16 _HttpPort = 8099;
        public UInt16 HttpPort
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

        private UInt16 _HttpsPort = 8099;
        public UInt16 HttpsPort
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

        private UInt16 _SocksPort = 8099;
        public UInt16 SocksPort
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
