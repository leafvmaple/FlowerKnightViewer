using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_campaign_serial_schedule campaign_serial_schedule;
	public class fkapi_campaign_serial_schedule
	{
		public fkapi_campaignSerialScheduleList[] campaignSerialScheduleList { get; set; }
		public fkapi_userCampaignSerialList[] userCampaignSerialList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_campaignSerialScheduleList
	{
		public long id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string url { get; set; }
		public long campaignSerialTypeId { get; set; }
		public long maxUserInputCount { get; set; }
		public long isDisplayLimitCount { get; set; }
		public long orderNum { get; set; }
		public string publishedStartDate { get; set; }
		public string publishedEndDate { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
	public class fkapi_userCampaignSerialList
	{
		public long id { get; set; }
		public long userId { get; set; }
		public long campaignSerialScheduleId { get; set; }
		public long campaignSerialId { get; set; }
		public string serialCode { get; set; }
		public string created { get; set; }
	}
}
