using System;

namespace FlowerWrapper.Models.Raw
{
    public class fkapi_login
    {
        public fkapi_user user { get; set; }
        public fkapi_userSearchQuest userSearchQuest { get; set; }
        public fkapi_userAchievement userAchievement { get; set; }
        public fkapi_userPlant userPlant { get; set; }
        public fkapi_userItemList[] userItemList { get; set; }
        public fkapi_userCharacterList[] userCharacterList { get; set; }
        public fkapi_userCharacterPartyList[] userCharacterPartyList { get; set; }
        public fkapi_userCharacterEquipmentList[] userCharacterEquipmentList { get; set; }
        public fkapi_userDungeon userDungeon { get; set; }
        public fkapi_userStageList[] userStageList { get; set; }
        public fkapi_userMysetNameList[] userMysetNameList { get; set; }
        public fkapi_userPointItemList[] userPointItemList { get; set; }
        public string sessionKey { get; set; }
        public fkapi_masterLoginBonus masterLoginBonus { get; set; }
        public long loginBonusGroupId { get; set; }
        public fkapi_masterLoginBonusList[] masterLoginBonusList { get; set; }
        public fkapi_masterLimitationLoginBonus[] masterLimitationLoginBonus { get; set; }
        public fkapi_masterAdministratorMailScheduleList[] masterAdministratorMailScheduleList { get; set; }
        public fkapi_userEventItemList[] userEventItemList { get; set; }
        public fkapi_givingMasterComebackLoginBonusList[] givingMasterComebackLoginBonusList { get; set; }
        public fkapi_masterComebackLoginBonusList[] masterComebackLoginBonusList { get; set; }
        public fkapi_userComebackLoginBonusList[] userComebackLoginBonusList { get; set; }
        public fkapi_masterComebackLoginBonusItemList[] masterComebackLoginBonusItemList { get; set; }
        public fkapi_masterComebackLoginBonusGroupList[] masterComebackLoginBonusGroupList { get; set; }
        public long gacha5starPurchaseCount { get; set; }
        public fkapi_userGachaTicketList[] userGachaTicketList { get; set; }
        public fkapi_userBoostList[] userBoostList { get; set; }
        public fkapi_userMissionList[] userMissionList { get; set; }
        public fkapi_userCharacterQuestList[] userCharacterQuestList { get; set; }
        public long userCampaignGoodsPurchaseFlag { get; set; }
        public string userRetryPaymentItem { get; set; }
        public long userSpecialGachaPurchaseCount { get; set; }
        public long userGardenMakeoverBgmId { get; set; }
        public fkapi_userGardenMakeoverPurchaseItemList[] userGardenMakeoverPurchaseItemList { get; set; }
        public fkapi_masterLoginContinueBonusList[] masterLoginContinueBonusList { get; set; }
        public long nextLoginContinueBonusDateDiff { get; set; }
        public long nextLoginContinueBonusGroupId { get; set; }
        public fkapi_userWhaleCharacterPartyList[] userWhaleCharacterPartyList { get; set; }
        public fkapi_userWhaleMysetNameList[] userWhaleMysetNameList { get; set; }
        public fkapi_userPanelMissionList[] userPanelMissionList { get; set; }
        public string errorMessage { get; set; }
        public string resultCode { get; set; }
        public string buildVersion { get; set; }
        public string serverTime { get; set; }
        public long loginBonusTypeId { get; set; }
        public fkapi_userGardenCharacterList[] userGardenCharacterList { get; set; }
        public string userWhaleTotalPower { get; set; }
    }
    public class fkapi_user
    {
        public long id { get; set; }
        public long attributeId { get; set; }
        public long openSocialId { get; set; }
        public string searchUserId { get; set; }
        public long stamina { get; set; }
        public string staminaTime { get; set; }
        public long battlePoint { get; set; }
        public string battlePointTime { get; set; }
        public long gameMoney { get; set; }
        public long chargeMoney { get; set; }
        public long gachaPoint { get; set; }
        public long raidBossGachaPoint { get; set; }
        public long registrationEndFlag { get; set; }
        public long levelId { get; set; }
        public long levelExperience { get; set; }
        public long maxFriend { get; set; }
        public long maxCharacterBox { get; set; }
        public long maxCharacterEquipmentBox { get; set; }
        public long maxMysetNum { get; set; }
        public long activeCharacterPartySetNum { get; set; }
        public long deputyLeaderCharacterId { get; set; }
        public long deputyLeaderUserCharacterId { get; set; }
        public string newsHideIdList { get; set; }
    }
    public class fkapi_userSearchQuest
    {
        public long searchQuestPoint { get; set; }
        public string searchQuestPointTime { get; set; }
    }
    public class fkapi_userAchievement
    {
        public long id { get; set; }
        public long totalLoginCount { get; set; }
        public string loginDate { get; set; }
        public long friendTotalCount { get; set; }
        public long achievementId1FinishFlag { get; set; }
        public long achievementId2FinishFlag { get; set; }
        public long achievementId3FinishFlag { get; set; }
        public long achievementId4FinishFlag { get; set; }
        public long achievementId5FinishFlag { get; set; }
        public long achievementId6FinishFlag { get; set; }
        public long achievementId7FinishFlag { get; set; }
        public long achievementId8FinishFlag { get; set; }
        public long achievementId9FinishFlag { get; set; }
        public long achievementId10FinishFlag { get; set; }
        public long achievementId11FinishFlag { get; set; }
        public long achievementId12FinishFlag { get; set; }
        public long achievementId13FinishFlag { get; set; }
        public long achievementId14FinishFlag { get; set; }
        public long achievementId15FinishFlag { get; set; }
        public long achievementId16FinishFlag { get; set; }
        public long achievementId17FinishFlag { get; set; }
        public long achievementId18FinishFlag { get; set; }
        public long achievementId19FinishFlag { get; set; }
        public long achievementId20FinishFlag { get; set; }
        public long achievementId21FinishFlag { get; set; }
        public long achievementId22FinishFlag { get; set; }
        public long achievementId23FinishFlag { get; set; }
        public long achievementId24FinishFlag { get; set; }
        public long achievementId25FinishFlag { get; set; }
        public long achievementId26FinishFlag { get; set; }
        public long achievementId27FinishFlag { get; set; }
        public long achievementId28FinishFlag { get; set; }
        public long achievementId29FinishFlag { get; set; }
        public long achievementId30FinishFlag { get; set; }
        public long achievementId31FinishFlag { get; set; }
        public long achievementId32FinishFlag { get; set; }
        public long achievementId33FinishFlag { get; set; }
        public long achievementId34FinishFlag { get; set; }
        public long achievementId35FinishFlag { get; set; }
        public long achievementId36FinishFlag { get; set; }
        public long achievementId37FinishFlag { get; set; }
        public long achievementId38FinishFlag { get; set; }
        public long achievementId39FinishFlag { get; set; }
        public long achievementId40FinishFlag { get; set; }
        public long achievementId41FinishFlag { get; set; }
        public long achievementId42FinishFlag { get; set; }
        public long achievementId43FinishFlag { get; set; }
        public long achievementId44FinishFlag { get; set; }
        public long achievementId45FinishFlag { get; set; }
        public long achievementId46FinishFlag { get; set; }
        public long achievementId47FinishFlag { get; set; }
        public long achievementId48FinishFlag { get; set; }
        public long achievementId49FinishFlag { get; set; }
        public long achievementId50FinishFlag { get; set; }
        public long achievementId51FinishFlag { get; set; }
        public long achievementId52FinishFlag { get; set; }
        public long achievementId53FinishFlag { get; set; }
        public long achievementId54FinishFlag { get; set; }
        public long achievementId55FinishFlag { get; set; }
        public long achievementId56FinishFlag { get; set; }
        public long achievementId57FinishFlag { get; set; }
        public long achievementId58FinishFlag { get; set; }
        public long achievementId59FinishFlag { get; set; }
        public long achievementId60FinishFlag { get; set; }
        public long achievementId61FinishFlag { get; set; }
        public long achievementId62FinishFlag { get; set; }
        public long achievementId63FinishFlag { get; set; }
        public long achievementId64FinishFlag { get; set; }
        public long achievementId65FinishFlag { get; set; }
        public long achievementId66FinishFlag { get; set; }
        public long achievementId67FinishFlag { get; set; }
        public long achievementId68FinishFlag { get; set; }
        public long achievementId69FinishFlag { get; set; }
        public long achievementId70FinishFlag { get; set; }
        public long achievementId71FinishFlag { get; set; }
        public long achievementId72FinishFlag { get; set; }
        public long achievementId73FinishFlag { get; set; }
        public long achievementId74FinishFlag { get; set; }
        public long achievementId75FinishFlag { get; set; }
        public long achievementId76FinishFlag { get; set; }
        public long achievementId77FinishFlag { get; set; }
        public long achievementId78FinishFlag { get; set; }
        public long achievementId79FinishFlag { get; set; }
        public long achievementId80FinishFlag { get; set; }
        public long achievementId81FinishFlag { get; set; }
        public long achievementId82FinishFlag { get; set; }
        public long achievementId83FinishFlag { get; set; }
        public long achievementId84FinishFlag { get; set; }
        public long achievementId85FinishFlag { get; set; }
        public long achievementId86FinishFlag { get; set; }
        public long achievementId87FinishFlag { get; set; }
        public long achievementId88FinishFlag { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userPlant
    {
        public long id { get; set; }
        public long plantId { get; set; }
        public long plantItemId { get; set; }
        public string startDate { get; set; }
        public long status { get; set; }
    }
    public class fkapi_userItemList
    {
        public long id { get; set; }
        public long itemId { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userCharacterList
    {
        public long id { get; set; }
        public long itemId { get; set; }
        public long characterId { get; set; }
        public long characterLevelNum { get; set; }
        public long characterLevelExperience { get; set; }
        public long characterSkillLevelNum { get; set; }
        public long hitPointBonus { get; set; }
        public long attackBonus { get; set; }
        public long defenseBonus { get; set; }
        public long favorabilityValue { get; set; }
        public long favoriteFlag { get; set; }
        public long maxEquipmentSlotCount { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userCharacterPartyList
    {
        public long id { get; set; }
        public long userCharacterId { get; set; }
        public long setNum { get; set; }
        public long rowNum { get; set; }
        public long orderNum { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userCharacterEquipmentList
    {
        public long id { get; set; }
        public long userCharacterId { get; set; }
        public long characterEquipmentId { get; set; }
        public long characterEquipmentSlotNum { get; set; }
        public long characterEquipmentLevelNum { get; set; }
        public long characterEquipmentLevelExperience { get; set; }
        public long favoriteFlag { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userDungeon
    {
        public long id { get; set; }
        public long dungeonId { get; set; }
        public long status { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userStageList
    {
        public long id { get; set; }
        public long stageId { get; set; }
        public long evaluationPoint { get; set; }
        public long status { get; set; }
        public long playCount { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_userMysetNameList
    {
        public long id { get; set; }
        public long setNum { get; set; }
        public string mysetName { get; set; }
    }
    public class fkapi_userPointItemList
    {
        public long id { get; set; }
        public long itemId { get; set; }
        public long pointItemTypeId { get; set; }
        public long point { get; set; }
    }
    public class fkapi_masterLoginBonus
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long dayCount { get; set; }
        public long itemId { get; set; }
        public long amount { get; set; }
        public long characterLevelNum { get; set; }
        public long characterLevelExperience { get; set; }
    }
    public class fkapi_masterLoginBonusList
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long dayCount { get; set; }
        public long itemId { get; set; }
        public long amount { get; set; }
        public long characterLevelNum { get; set; }
        public long characterLevelExperience { get; set; }
    }
    public class fkapi_masterLimitationLoginBonus
    {
    }
    public class fkapi_masterAdministratorMailScheduleList
    {
    }
    public class fkapi_userEventItemList
    {
        public long id { get; set; }
        public long eventTypeId { get; set; }
        public long eventId { get; set; }
        public long itemId { get; set; }
        public long totalAcquisitionNumber { get; set; }
        public long amount { get; set; }
    }
    public class fkapi_givingMasterComebackLoginBonusList
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long dayCount { get; set; }
        public long loginBonusGroupId { get; set; }
        public long comebackLoginBonusGroupId { get; set; }
        public long comebackLoginBonusItemGroupId { get; set; }
        public string textureName { get; set; }
    }
    public class fkapi_masterComebackLoginBonusList
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long dayCount { get; set; }
        public long loginBonusGroupId { get; set; }
        public long comebackLoginBonusGroupId { get; set; }
        public long comebackLoginBonusItemGroupId { get; set; }
        public string textureName { get; set; }
    }
    public class fkapi_userComebackLoginBonusList
    {
        public long id { get; set; }
        public long comebackLoginBonusGroupId { get; set; }
        public long dayCount { get; set; }
    }
    public class fkapi_masterComebackLoginBonusItemList
    {
        public long id { get; set; }
        public long itemId { get; set; }
        public long amount { get; set; }
        public long characterLevelNum { get; set; }
        public long characterLevelExperience { get; set; }
        public long characterMaxEquipmentSlotCount { get; set; }
        public long characterSkillLevelNum { get; set; }
    }
    public class fkapi_masterComebackLoginBonusGroupList
    {
        public long id { get; set; }
        public long loginBonusTypeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string message1 { get; set; }
        public string message2 { get; set; }
        public long dormancyDay { get; set; }
        public string registrationDate { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
    public class fkapi_userGachaTicketList
    {
        public long gachaGroupId { get; set; }
        public long itemId { get; set; }
        public long amount { get; set; }
        public long purchaseCount { get; set; }
    }
    public class fkapi_userBoostList
    {
    }
    public class fkapi_userMissionList
    {
        public long id { get; set; }
        public long missionId { get; set; }
        public long progressCount { get; set; }
        public long status { get; set; }
        public long unlockFlag { get; set; }
    }
    public class fkapi_userCharacterQuestList
    {
        public long id { get; set; }
        public long characterBookId { get; set; }
        public long characterQuestId { get; set; }
        public long status { get; set; }
    }
    public class fkapi_userGardenMakeoverPurchaseItemList
    {
        public long id { get; set; }
        public long itemId { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }
    public class fkapi_masterLoginContinueBonusList
    {
    }
    public class fkapi_userWhaleCharacterPartyList
    {
    }
    public class fkapi_userWhaleMysetNameList
    {
    }
    public class fkapi_userPanelMissionList
    {
        public long panelGroupId { get; set; }
        public long missionId { get; set; }
        public long progressCount { get; set; }
        public long status { get; set; }
    }
    public class fkapi_userGardenCharacterList
    {
    }
}
