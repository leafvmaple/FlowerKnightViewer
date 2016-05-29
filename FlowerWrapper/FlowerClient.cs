using FlowerWrapper.Internal;
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

        public Knight Knight { get; set; }

        public Friend Friend { get; set; }

        public void Initialieze()
        {
            if (Proxy == null) Proxy = new FlowerProxy();

            var social = Proxy.dmm_social_rpc.TryParse<dmm_source_rpc>().FirstAsync().ToTask();
            var news  = Proxy.api_config_getNews.TryParse<fkapi_news>().FirstAsync().ToTask();
            var friends = this.Proxy.api_friend_getFriendList.TryParse<fkapi_friend>().FirstAsync().ToTask();
            var raidBoss = this.Proxy.api_raidBoss_getRaidBossList.TryParse<fkapi_raid_boss>().FirstAsync().ToTask();
            var friendApt = this.Proxy.api_friend_getFriendAcceptList.TryParse<fkapi_friend_accept>().FirstAsync().ToTask();

            var login = Proxy.api_user_login.TryParse<fkapi_login>().FirstAsync().ToTask();

            Proxy.api_user_login.FirstAsync().Subscribe(async session =>
            {
                var timeout = Task.Delay(TimeSpan.FromSeconds(20));

                // 当所有任务都已经完成，或者已经延时已经到.
                var bCanInitialize = await Task.WhenAny(new Task[] { news, raidBoss, friendApt }.WhenAll(), timeout) != timeout;

                if (Knight == null) Knight = new Knight();
                if (Friend == null) Friend = new Friend();

                if (bCanInitialize)
                {
                    Knight.UpdateKnight(await login);
                    Knight.UpdateName(await social);

                    Friend.UpdateFriend(await friends);
                    Friend.UpdateFriendAccept(await friendApt);
                }
            });
        }

        /// <summary>
        /// 美少女花骑士通信代理。
        /// </summary>
        public FlowerProxy Proxy { get; private set; }
    }
}
