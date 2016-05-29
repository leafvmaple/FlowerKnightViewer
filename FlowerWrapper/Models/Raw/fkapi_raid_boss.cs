using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_raid_boss raid_boss;
	public class fkapi_raid_boss
	{
		public object[] userRaidBossUserList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
}
