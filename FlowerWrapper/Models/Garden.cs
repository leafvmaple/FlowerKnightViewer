using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerWrapper.Models.Raw;
using Livet;

namespace FlowerWrapper.Models
{
    public class Garden : NotificationObject
    {
        public void UpdateGarden(fkapi_login loginData)
        {
            Knight.UpdateKnight(loginData.user);
        }

        public void UpdateGarden(dmm_source_rpc[] sourceRpc)
        {
            Knight = new Knight(sourceRpc[0].data);
        }

        private Knight _Knight;
        public Knight Knight
        {
            get { return _Knight; }
            private set
            {
                if (this._Knight != value)
                {
                    this._Knight = value;
                    this.RaisePropertyChanged();
                }
            }
        }

    }
}
