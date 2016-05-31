using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_gacha_schedule gacha_schedule;
	public class fkapi_gacha_schedule
	{
		public fkapi_gachaGroupScheduleList[] gachaGroupScheduleList { get; set; }
		public fkapi_paymentGachaTicketList[] paymentGachaTicketList { get; set; }
		public fkapi_userGachaTicketList[] userGachaTicketList { get; set; }
		public long nowWeekId { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_gachaGroupScheduleList
	{
		public string name { get; set; }
		public long gachaGroupId { get; set; }
		public long parentId { get; set; }
		public long campaign { get; set; }
		public long ticketOnly { get; set; }
		public long orderNum { get; set; }
		public long itemId { get; set; }
		public long amount { get; set; }
		public long drawCount { get; set; }
		public long probabilityRarity1 { get; set; }
		public long probabilityRarity2 { get; set; }
		public long probabilityRarity3 { get; set; }
		public long probabilityRarity4 { get; set; }
		public long probabilityRarity5 { get; set; }
		public long probabilityRarity6 { get; set; }
		public long weekId { get; set; }
		public long tabOrderNum { get; set; }
		public string tabName { get; set; }
		public long bannerOrderNum { get; set; }
		public long bannerRotationInterval { get; set; }
		public string bannerTitleName { get; set; }
		public string bannerImageUrl { get; set; }
		public string bannerTitleImageFile { get; set; }
		public string bannerImageFile { get; set; }
		public string bannerVoiceUrl { get; set; }
		public string bannerVoiceFile { get; set; }
	}
	public class fkapi_paymentGachaTicketList
	{
		public long paymentId { get; set; }
		public long gachaGroupId { get; set; }
		public long relGachaGroupId { get; set; }
	}
	public class fkapi_userGachaTicketList
	{
		public long gachaGroupId { get; set; }
		public long itemId { get; set; }
		public long amount { get; set; }
		public long purchaseCount { get; set; }
	}
}
