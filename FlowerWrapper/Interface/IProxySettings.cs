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

        ushort HttpPort { get; }

        string HttpsHost { get; }

        ushort HttpsPort { get; }

        string FtpHost { get; }

        ushort FtpPort { get; }

        string SocksHost { get; }

        ushort SocksPort { get; }

        bool IsUseHttpProxyForAllProtocols { get; }
    }
}
