using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_login login;
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
		public int loginBonusGroupId { get; set; }
		public fkapi_masterLoginBonusList[] masterLoginBonusList { get; set; }
		public object[] masterLimitationLoginBonus { get; set; }
		public object[] masterAdministratorMailScheduleList { get; set; }
		public fkapi_userEventItemList[] userEventItemList { get; set; }
		public fkapi_givingMasterComebackLoginBonusList[] givingMasterComebackLoginBonusList { get; set; }
		public fkapi_masterComebackLoginBonusList[] masterComebackLoginBonusList { get; set; }
		public fkapi_userComebackLoginBonusList[] userComebackLoginBonusList { get; set; }
		public fkapi_masterComebackLoginBonusItemList[] masterComebackLoginBonusItemList { get; set; }
		public fkapi_masterComebackLoginBonusGroupList[] masterComebackLoginBonusGroupList { get; set; }
		public int gacha5starPurchaseCount { get; set; }
		public fkapi_userGachaTicketList[] userGachaTicketList { get; set; }
		public object[] userBoostList { get; set; }
		public fkapi_userMissionList[] userMissionList { get; set; }
		public fkapi_userCharacterQuestList[] userCharacterQuestList { get; set; }
		public int userCampaignGoodsPurchaseFlag { get; set; }
		public string userRetryPaymentItem { get; set; }
		public int userSpecialGachaPurchaseCount { get; set; }
		public int userGardenMakeoverBgmId { get; set; }
		public fkapi_userGardenMakeoverPurchaseItemList[] userGardenMakeoverPurchaseItemList { get; set; }
		public object[] masterLoginContinueBonusList { get; set; }
		public int nextLoginContinueBonusDateDiff { get; set; }
		public int nextLoginContinueBonusGroupId { get; set; }
		public object[] userWhaleCharacterPartyList { get; set; }
		public object[] userWhaleMysetNameList { get; set; }
		public fkapi_userPanelMissionList[] userPanelMissionList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
		public int loginBonusTypeId { get; set; }
		public object[] userGardenCharacterList { get; set; }
		public string userWhaleTotalPower { get; set; }
	}
	public class fkapi_user
	{
		public int id { get; set; }
		public int attributeId { get; set; }
		public int openSocialId { get; set; }
		public string searchUserId { get; set; }
		public int stamina { get; set; }
		public string staminaTime { get; set; }
		public int battlePoint { get; set; }
		public string battlePointTime { get; set; }
		public int gameMoney { get; set; }
		public int chargeMoney { get; set; }
		public int gachaPoint { get; set; }
		public int raidBossGachaPoint { get; set; }
		public int registrationEndFlag { get; set; }
		public int levelId { get; set; }
		public int levelExperience { get; set; }
		public int maxFriend { get; set; }
		public int maxCharacterBox { get; set; }
		public int maxCharacterEquipmentBox { get; set; }
		public int maxMysetNum { get; set; }
		public int activeCharacterPartySetNum { get; set; }
		public int deputyLeaderCharacterId { get; set; }
		public int deputyLeaderUserCharacterId { get; set; }
		public string newsHideIdList { get; set; }
	}
	public class fkapi_userSearchQuest
	{
		public int searchQuestPoint { get; set; }
		public string searchQuestPointTime { get; set; }
	}
	public class fkapi_userAchievement
	{
		public int id { get; set; }
		public int totalLoginCount { get; set; }
		public string loginDate { get; set; }
		public int friendTotalCount { get; set; }
		public int achievementId1FinishFlag { get; set; }
		public int achievementId2FinishFlag { get; set; }
		public int achievementId3FinishFlag { get; set; }
		public int achievementId4FinishFlag { get; set; }
		public int achievementId5FinishFlag { get; set; }
		public int achievementId6FinishFlag { get; set; }
		public int achievementId7FinishFlag { get; set; }
		public int achievementId8FinishFlag { get; set; }
		public int achievementId9FinishFlag { get; set; }
		public int achievementId10FinishFlag { get; set; }
		public int achievementId11FinishFlag { get; set; }
		public int achievementId12FinishFlag { get; set; }
		public int achievementId13FinishFlag { get; set; }
		public int achievementId14FinishFlag { get; set; }
		public int achievementId15FinishFlag { get; set; }
		public int achievementId16FinishFlag { get; set; }
		public int achievementId17FinishFlag { get; set; }
		public int achievementId18FinishFlag { get; set; }
		public int achievementId19FinishFlag { get; set; }
		public int achievementId20FinishFlag { get; set; }
		public int achievementId21FinishFlag { get; set; }
		public int achievementId22FinishFlag { get; set; }
		public int achievementId23FinishFlag { get; set; }
		public int achievementId24FinishFlag { get; set; }
		public int achievementId25FinishFlag { get; set; }
		public int achievementId26FinishFlag { get; set; }
		public int achievementId27FinishFlag { get; set; }
		public int achievementId28FinishFlag { get; set; }
		public int achievementId29FinishFlag { get; set; }
		public int achievementId30FinishFlag { get; set; }
		public int achievementId31FinishFlag { get; set; }
		public int achievementId32FinishFlag { get; set; }
		public int achievementId33FinishFlag { get; set; }
		public int achievementId34FinishFlag { get; set; }
		public int achievementId35FinishFlag { get; set; }
		public int achievementId36FinishFlag { get; set; }
		public int achievementId37FinishFlag { get; set; }
		public int achievementId38FinishFlag { get; set; }
		public int achievementId39FinishFlag { get; set; }
		public int achievementId40FinishFlag { get; set; }
		public int achievementId41FinishFlag { get; set; }
		public int achievementId42FinishFlag { get; set; }
		public int achievementId43FinishFlag { get; set; }
		public int achievementId44FinishFlag { get; set; }
		public int achievementId45FinishFlag { get; set; }
		public int achievementId46FinishFlag { get; set; }
		public int achievementId47FinishFlag { get; set; }
		public int achievementId48FinishFlag { get; set; }
		public int achievementId49FinishFlag { get; set; }
		public int achievementId50FinishFlag { get; set; }
		public int achievementId51FinishFlag { get; set; }
		public int achievementId52FinishFlag { get; set; }
		public int achievementId53FinishFlag { get; set; }
		public int achievementId54FinishFlag { get; set; }
		public int achievementId55FinishFlag { get; set; }
		public int achievementId56FinishFlag { get; set; }
		public int achievementId57FinishFlag { get; set; }
		public int achievementId58FinishFlag { get; set; }
		public int achievementId59FinishFlag { get; set; }
		public int achievementId60FinishFlag { get; set; }
		public int achievementId61FinishFlag { get; set; }
		public int achievementId62FinishFlag { get; set; }
		public int achievementId63FinishFlag { get; set; }
		public int achievementId64FinishFlag { get; set; }
		public int achievementId65FinishFlag { get; set; }
		public int achievementId66FinishFlag { get; set; }
		public int achievementId67FinishFlag { get; set; }
		public int achievementId68FinishFlag { get; set; }
		public int achievementId69FinishFlag { get; set; }
		public int achievementId70FinishFlag { get; set; }
		public int achievementId71FinishFlag { get; set; }
		public int achievementId72FinishFlag { get; set; }
		public int achievementId73FinishFlag { get; set; }
		public int achievementId74FinishFlag { get; set; }
		public int achievementId75FinishFlag { get; set; }
		public int achievementId76FinishFlag { get; set; }
		public int achievementId77FinishFlag { get; set; }
		public int achievementId78FinishFlag { get; set; }
		public int achievementId79FinishFlag { get; set; }
		public int achievementId80FinishFlag { get; set; }
		public int achievementId81FinishFlag { get; set; }
		public int achievementId82FinishFlag { get; set; }
		public int achievementId83FinishFlag { get; set; }
		public int achievementId84FinishFlag { get; set; }
		public int achievementId85FinishFlag { get; set; }
		public int achievementId86FinishFlag { get; set; }
		public int achievementId87FinishFlag { get; set; }
		public int achievementId88FinishFlag { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userPlant
	{
		public int id { get; set; }
		public int plantId { get; set; }
		public int plantItemId { get; set; }
		public string startDate { get; set; }
		public int status { get; set; }
	}
	public class fkapi_userItemList
	{
		public int id { get; set; }
		public int itemId { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userCharacterList
	{
		public int id { get; set; }
		public int itemId { get; set; }
		public int characterId { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
		public int characterSkillLevelNum { get; set; }
		public int hitPointBonus { get; set; }
		public int attackBonus { get; set; }
		public int defenseBonus { get; set; }
		public int favorabilityValue { get; set; }
		public int favoriteFlag { get; set; }
		public int maxEquipmentSlotCount { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userCharacterPartyList
	{
		public int id { get; set; }
		public int userCharacterId { get; set; }
		public int setNum { get; set; }
		public int rowNum { get; set; }
		public int orderNum { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userCharacterEquipmentList
	{
		public int id { get; set; }
		public int userCharacterId { get; set; }
		public int characterEquipmentId { get; set; }
		public int characterEquipmentSlotNum { get; set; }
		public int characterEquipmentLevelNum { get; set; }
		public int characterEquipmentLevelExperience { get; set; }
		public int favoriteFlag { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userDungeon
	{
		public int id { get; set; }
		public int dungeonId { get; set; }
		public int status { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userStageList
	{
		public int id { get; set; }
		public int stageId { get; set; }
		public int evaluationPoint { get; set; }
		public int status { get; set; }
		public int playCount { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userMysetNameList
	{
		public int id { get; set; }
		public int setNum { get; set; }
		public string mysetName { get; set; }
	}
	public class fkapi_userPointItemList
	{
		public int id { get; set; }
		public int itemId { get; set; }
		public int pointItemTypeId { get; set; }
		public int point { get; set; }
	}
	public class fkapi_masterLoginBonus
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public int dayCount { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
	}
	public class fkapi_masterLoginBonusList
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public int dayCount { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
	}
	public class fkapi_userEventItemList
	{
		public int id { get; set; }
		public int eventTypeId { get; set; }
		public int eventId { get; set; }
		public int itemId { get; set; }
		public int totalAcquisitionNumber { get; set; }
		public int amount { get; set; }
	}
	public class fkapi_givingMasterComebackLoginBonusList
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public int dayCount { get; set; }
		public int loginBonusGroupId { get; set; }
		public int comebackLoginBonusGroupId { get; set; }
		public int comebackLoginBonusItemGroupId { get; set; }
		public string textureName { get; set; }
	}
	public class fkapi_masterComebackLoginBonusList
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public int dayCount { get; set; }
		public int loginBonusGroupId { get; set; }
		public int comebackLoginBonusGroupId { get; set; }
		public int comebackLoginBonusItemGroupId { get; set; }
		public string textureName { get; set; }
	}
	public class fkapi_userComebackLoginBonusList
	{
		public int id { get; set; }
		public int comebackLoginBonusGroupId { get; set; }
		public int dayCount { get; set; }
	}
	public class fkapi_masterComebackLoginBonusItemList
	{
		public int id { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
		public int characterMaxEquipmentSlotCount { get; set; }
		public int characterSkillLevelNum { get; set; }
	}
	public class fkapi_masterComebackLoginBonusGroupList
	{
		public int id { get; set; }
		public int loginBonusTypeId { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string message1 { get; set; }
		public string message2 { get; set; }
		public int dormancyDay { get; set; }
		public string registrationDate { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
	public class fkapi_userGachaTicketList
	{
		public int gachaGroupId { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int purchaseCount { get; set; }
	}
	public class fkapi_userMissionList
	{
		public int id { get; set; }
		public int missionId { get; set; }
		public int progressCount { get; set; }
		public int status { get; set; }
		public int unlockFlag { get; set; }
	}
	public class fkapi_userCharacterQuestList
	{
		public int id { get; set; }
		public int characterBookId { get; set; }
		public int characterQuestId { get; set; }
		public int status { get; set; }
	}
	public class fkapi_userGardenMakeoverPurchaseItemList
	{
		public int id { get; set; }
		public int itemId { get; set; }
		public string created { get; set; }
		public string modified { get; set; }
	}
	public class fkapi_userPanelMissionList
	{
		public int panelGroupId { get; set; }
		public int missionId { get; set; }
		public int progressCount { get; set; }
		public int status { get; set; }
	}
}
