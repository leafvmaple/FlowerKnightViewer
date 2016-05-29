using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerWrapper.Models.Raw;

namespace FlowerWrapper
{
    public class Knight
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public long GameMoney { get; set; }

        public long ChargeMoney { get; set; }

        public long Level { get; set; }

        public long LevelExp { get; set; }

        public void UpdateKnight(fkapi_login loginData)
        {
            this.ID = loginData.user.id;
            this.GameMoney = loginData.user.gameMoney;
            this.ChargeMoney = loginData.user.chargeMoney;
            this.Level = loginData.user.levelId;
            this.LevelExp = loginData.user.levelExperience;
        }

        public void UpdateName(dmm_source_rpc sourceRpc)
        {
            this.Name = sourceRpc.data.displayName;
        }
    }
}
