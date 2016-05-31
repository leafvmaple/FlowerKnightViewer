using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_box_gacha_schedule box_gacha_schedule;
	public class fkapi_box_gacha_schedule
	{
		public object[] boxGachaList { get; set; }
		public object[] userBoxGachaList { get; set; }
		public object[] userBoxGachaRateList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
}
