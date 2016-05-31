using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_event_detail event_detail;
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
		public long firstDungeonId { get; set; }
		public long secondDungeonId { get; set; }
		public long pageType { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
		public long eventItemId { get; set; }
		public object[] summonRaidBossList { get; set; }
		public object[] summonBossSchedule { get; set; }
		public long isExchangeAllComplete { get; set; }
	}
}
