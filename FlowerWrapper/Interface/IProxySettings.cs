using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper.Interface
{
    public interface IProxySettings
    {
        ProxyType Type { get; }

        string HttpHost { get; }

        UInt16 HttpPort { get; }

        string HttpsHost { get; }

        UInt16 HttpsPort { get; }

        string FtpHost { get; }

        UInt16 FtpPort { get; }

        string SocksHost { get; }

        UInt16 SocksPort { get; }

        bool IsUseHttpProxyForAllProtocols { get; }
    }
}
