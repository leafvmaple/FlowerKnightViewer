using System;

namespace FlowerWrapper.Models.Raw
{
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
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string url { get; set; }
		public int campaignSerialTypeId { get; set; }
		public int maxUserInputCount { get; set; }
		public int isDisplayLimitCount { get; set; }
		public int orderNum { get; set; }
		public string publishedStartDate { get; set; }
		public string publishedEndDate { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
	public class fkapi_userCampaignSerialList
	{
		public int id { get; set; }
		public int userId { get; set; }
		public int campaignSerialScheduleId { get; set; }
		public int campaignSerialId { get; set; }
		public string serialCode { get; set; }
		public string created { get; set; }
	}
