using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_event_dungeon
	{
		public fkapi_masterDungeonList[] masterDungeonList { get; set; }
		public fkapi_masterStageList[] masterStageList { get; set; }
		public fkapi_masterStageBannerList[] masterStageBannerList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_masterDungeonList
	{
		public int id { get; set; }
		public int dungeonGroupId { get; set; }
		public string name { get; set; }
		public int orderNum { get; set; }
		public int nextDungeonId { get; set; }
		public int textureName { get; set; }
		public string startTime { get; set; }
		public string endTime { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
		public int restrictionsCountryId { get; set; }
		public string backgroundImageUrl { get; set; }
		public int tabTypeId { get; set; }
	}
	public class fkapi_masterStageList
	{
		public int id { get; set; }
		public string name { get; set; }
		public int dungeonId { get; set; }
		public int useStamina { get; set; }
		public int orderNum { get; set; }
		public int nextStageId { get; set; }
		public string textureName { get; set; }
		public string whaleBattleTextureName { get; set; }
		public string battleTextureName { get; set; }
		public int stageEvaluationItemGroupId { get; set; }
		public int givingExperience { get; set; }
		public int maxDropGameMoney { get; set; }
		public int maxDropGachaPoint { get; set; }
		public int maxDropEventItemPoint { get; set; }
		public string soundName { get; set; }
		public int raidBossId { get; set; }
		public int playCount { get; set; }
		public int maxPlayCount { get; set; }
		public int evaluationPoint { get; set; }
		public int achievementId { get; set; }
		public int recommendTotalPower { get; set; }
	}
	public class fkapi_masterStageBannerList
	{
		public int id { get; set; }
		public string name { get; set; }
		public int dungeonId { get; set; }
		public int eventItemId { get; set; }
		public string imageUrl { get; set; }
		public string imageFile { get; set; }
		public int linkTargetType { get; set; }
		public int linkTarget { get; set; }
	}
