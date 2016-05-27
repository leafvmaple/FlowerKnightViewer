using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_event_detail
	{
		public fkapi_eventDetailList[] eventDetailList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_eventDetailList
	{
		public string eventName { get; set; }
		public string introductionImageUrl { get; set; }
		public string dungeonListBannerUrl { get; set; }
		public string detailUrl { get; set; }
		public int firstDungeonId { get; set; }
		public int secondDungeonId { get; set; }
		public int pageType { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
		public int eventItemId { get; set; }
		public fkapi_summonRaidBossList[] summonRaidBossList { get; set; }
		public fkapi_summonBossSchedule[] summonBossSchedule { get; set; }
		public int isExchangeAllComplete { get; set; }
	}
	public class fkapi_summonRaidBossList
	{
	}
	public class fkapi_summonBossSchedule
	{
	}
