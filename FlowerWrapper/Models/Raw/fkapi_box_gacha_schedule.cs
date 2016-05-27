using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_box_gacha_schedule
	{
		public fkapi_boxGachaList[] boxGachaList { get; set; }
		public fkapi_userBoxGachaList[] userBoxGachaList { get; set; }
		public fkapi_userBoxGachaRateList[] userBoxGachaRateList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_boxGachaList
	{
	}
	public class fkapi_userBoxGachaList
	{
	}
	public class fkapi_userBoxGachaRateList
	{
	}
