using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_friend_accept friend_accept;
	public class fkapi_friend_accept
	{
		public fkapi_userFriendInformationList[] userFriendInformationList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
}
