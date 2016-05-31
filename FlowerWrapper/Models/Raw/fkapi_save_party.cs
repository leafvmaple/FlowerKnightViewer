using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_save_party save_party;
	public class fkapi_save_party
	{
		public long testFlag { get; set; }
		public fkapi_userMissionList[] userMissionList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userMissionList
	{
		public long id { get; set; }
		public long missionId { get; set; }
		public long progressCount { get; set; }
		public long status { get; set; }
		public long unlockFlag { get; set; }
	}
}
