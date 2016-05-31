using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_event_dungeon event_dungeon;
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
		public long id { get; set; }
		public long dungeonGroupId { get; set; }
		public string name { get; set; }
		public long orderNum { get; set; }
		public long nextDungeonId { get; set; }
		public long textureName { get; set; }
		public string startTime { get; set; }
		public string endTime { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
		public long restrictionsCountryId { get; set; }
		public string backgroundImageUrl { get; set; }
		public long tabTypeId { get; set; }
	}
	public class fkapi_masterStageList
	{
		public long id { get; set; }
		public string name { get; set; }
		public long dungeonId { get; set; }
		public long useStamina { get; set; }
		public long orderNum { get; set; }
		public long nextStageId { get; set; }
		public string textureName { get; set; }
		public string whaleBattleTextureName { get; set; }
		public string battleTextureName { get; set; }
		public long stageEvaluationItemGroupId { get; set; }
		public long givingExperience { get; set; }
		public long maxDropGameMoney { get; set; }
		public long maxDropGachaPoint { get; set; }
		public long maxDropEventItemPoint { get; set; }
		public string soundName { get; set; }
		public long raidBossId { get; set; }
		public long playCount { get; set; }
		public long maxPlayCount { get; set; }
		public long evaluationPoint { get; set; }
		public long achievementId { get; set; }
		public long recommendTotalPower { get; set; }
	}
	public class fkapi_masterStageBannerList
	{
		public long id { get; set; }
		public string name { get; set; }
		public long dungeonId { get; set; }
		public long eventItemId { get; set; }
		public string imageUrl { get; set; }
		public string imageFile { get; set; }
		public long linkTargetType { get; set; }
		public long linkTarget { get; set; }
	}
}
