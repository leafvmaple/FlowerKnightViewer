using FlowerWrapper.Models.Raw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
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

        private FlowerClient()
        {
            this.Initialieze();
        }

        public void Initialieze()
        {
            if (this.Proxy == null)
                this.Proxy = new FlowerProxy();

            var login = this.Proxy.api_user_login.TryParse<fkapi_login>().FirstAsync().ToTask();
        }

        /// <summary>
        /// 美少女花骑士通信代理。
        /// </summary>
        public FlowerProxy Proxy { get; private set; }
    }
}
