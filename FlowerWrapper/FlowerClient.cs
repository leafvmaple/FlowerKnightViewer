using FlowerWrapper.Internal;
using FlowerWrapper.Models.Raw;
using Livet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using FlowerWrapper.Models;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper
{
    public class FlowerClient : NotificationObject
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

        public Garden Garden { get; set; }

        public Friend Friend { get; set; }

        public void Initialieze()
        {
            if (Proxy == null) Proxy = new FlowerProxy();
            if (Garden == null) Garden = new Garden();
            if (Friend == null) Friend = new Friend();

            // 在Dmm中同步昵称
            Proxy.dmm_social_rpc.TryParse<dmm_source_rpc[]>().Subscribe(x => Garden.UpdateGarden(x));

            var login = Proxy.api_user_login.TryParse<fkapi_login>().FirstAsync().ToTask();
            var news = Proxy.api_config_getNews.TryParse<fkapi_news>().FirstAsync().ToTask();
            var friends = this.Proxy.api_friend_getFriendList.TryParse<fkapi_friend>().FirstAsync().ToTask();
            var raidBoss = this.Proxy.api_raidBoss_getRaidBossList.TryParse<fkapi_raid_boss>().FirstAsync().ToTask();
            var friendApt = this.Proxy.api_friend_getFriendAcceptList.TryParse<fkapi_friend_accept>().FirstAsync().ToTask();

            Proxy.api_user_login.FirstAsync().Subscribe(async session =>
            {
                //var timeout = Task.Delay(TimeSpan.FromSeconds(20));

                // 当所有任务都已经完成
                await Task.WhenAll(news, raidBoss, friends, friendApt);

                Garden.UpdateGarden(await login);

                Friend.UpdateFriend(await friends);
                Friend.UpdateFriendAccept(await friendApt);
            });
        }

        /// <summary>
        /// 美少女花骑士通信代理。
        /// </summary>
        public FlowerProxy Proxy { get; private set; }

        #region IsStarted 変更通知

        private bool _IsStarted;

        /// <summary>
        /// 美少女花骑士是否启动。
        /// </summary>
        public bool IsStarted
        {
            get { return this._IsStarted; }
            set
            {
                if (this._IsStarted != value)
                {
                    this._IsStarted = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region IsInSortie 変更通知

        private bool _IsInSortie;

        /// <summary>
        /// 是否出击中。
        /// </summary>
        public bool IsInSortie
        {
            get { return this._IsInSortie; }
            private set
            {
                if (this._IsInSortie != value)
                {
                    this._IsInSortie = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion
    }
}
