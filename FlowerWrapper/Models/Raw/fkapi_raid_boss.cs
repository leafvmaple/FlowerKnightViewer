using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_raid_boss
	{
		public fkapi_userRaidBossUserList[] userRaidBossUserList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userRaidBossUserList
	{
	}
