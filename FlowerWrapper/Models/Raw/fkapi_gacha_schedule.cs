using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_gacha_schedule
	{
		public fkapi_gachaGroupScheduleList[] gachaGroupScheduleList { get; set; }
		public fkapi_paymentGachaTicketList[] paymentGachaTicketList { get; set; }
		public fkapi_userGachaTicketList[] userGachaTicketList { get; set; }
		public int nowWeekId { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_gachaGroupScheduleList
	{
		public string name { get; set; }
		public int gachaGroupId { get; set; }
		public int parentId { get; set; }
		public int campaign { get; set; }
		public int ticketOnly { get; set; }
		public int orderNum { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int drawCount { get; set; }
		public int probabilityRarity1 { get; set; }
		public int probabilityRarity2 { get; set; }
		public int probabilityRarity3 { get; set; }
		public int probabilityRarity4 { get; set; }
		public int probabilityRarity5 { get; set; }
		public int probabilityRarity6 { get; set; }
		public int weekId { get; set; }
		public int tabOrderNum { get; set; }
		public string tabName { get; set; }
		public int bannerOrderNum { get; set; }
		public int bannerRotationInterval { get; set; }
		public string bannerTitleName { get; set; }
		public string bannerImageUrl { get; set; }
		public string bannerTitleImageFile { get; set; }
		public string bannerImageFile { get; set; }
		public string bannerVoiceUrl { get; set; }
		public string bannerVoiceFile { get; set; }
	}
	public class fkapi_paymentGachaTicketList
	{
		public int paymentId { get; set; }
		public int gachaGroupId { get; set; }
		public int relGachaGroupId { get; set; }
	}
	public class fkapi_userGachaTicketList
	{
		public int gachaGroupId { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int purchaseCount { get; set; }
	}
