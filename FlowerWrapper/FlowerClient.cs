using FlowerWrapper.Models.Raw;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var proxy = this.Proxy ?? (this.Proxy = new FlowerProxy());

            var login = Proxy.api_user_login.TryParse<fkapi_login>().FirstAsync().ToTask();

            Proxy.api_user_login.FirstAsync().Subscribe(async session =>
            {
                var loginData = await login;

                fkapi_login loginData1;
                if (!FlowerProxy.Parse(session, out loginData1)) return;

                Debug.WriteLine(loginData);
            });
        }

        /// <summary>
        /// 美少女花骑士通信代理。
        /// </summary>
        public FlowerProxy Proxy { get; private set; }
    }
}
