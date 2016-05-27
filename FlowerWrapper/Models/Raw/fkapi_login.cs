using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerWrapper.Models.Raw
{
    public class fkapi_login
    {
        Api_User user { get; set; }

    }

    public class Api_User
    {
        public int api_id { get; set; }
        public int api_attributeId { get; set; }
        public int api_openSocialId { get; set; }
        public int api_searchUserId { get; set; }
        public int api_stamina { get; set; }
        public string api_staminaTime { get; set; }
        public int api_battlePoint { get; set; }
        public string api_battlePointTime { get; set; }
        public int api_gameMoney { get; set; }
        public int api_chargeMoney { get; set; }
        public int api_gachaPoint { get; set; }
        public int api_raidBossGachaPoint { get; set; }
        public int api_registrationEndFlag { get; set; }
        public int api_levelId { get; set; }
        public int api_levelExperience { get; set; }
        public int api_maxFriend { get; set; }
        public int api_maxCharacterBox { get; set; }
        public int api_maxCharacterEquipmentBox { get; set; }
        public int api_maxMysetNum { get; set; }
        public int api_activeCharacterPartySetNum { get; set; }
        public int api_deputyLeaderCharacterId { get; set; }
        public int api_deputyLeaderUserCharacterId { get; set; }
        public int[] api_newsHideIdList { get; set; }
    }
}
