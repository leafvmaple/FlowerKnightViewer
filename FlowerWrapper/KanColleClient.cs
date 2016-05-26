using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper
{
    public class FlowerClient
    {
        private static FlowerClient _Current = new FlowerClient();

        public static FlowerClient Current
        {
            get { return _Current; }
        }

        /// <summary>
        /// 美少女花骑士通信代理。
        /// </summary>
        public FlowerProxy Proxy { get; private set; }
    }
}
