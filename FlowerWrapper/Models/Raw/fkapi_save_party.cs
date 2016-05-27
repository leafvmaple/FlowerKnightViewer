using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_save_party
	{
		public int testFlag { get; set; }
		public fkapi_userMissionList[] userMissionList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userMissionList
	{
		public int id { get; set; }
		public int missionId { get; set; }
		public int progressCount { get; set; }
		public int status { get; set; }
		public int unlockFlag { get; set; }
	}
