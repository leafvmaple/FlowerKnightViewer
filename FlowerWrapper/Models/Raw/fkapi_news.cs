using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_news
	{
		public fkapi_masterNewsList[] masterNewsList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_masterNewsList
	{
		public string url { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
		public long orderNum { get; set; }
		public long id { get; set; }
	}
}
