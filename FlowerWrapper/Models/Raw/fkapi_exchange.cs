using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_exchange exchange;
	public class fkapi_exchange
	{
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
		public fkapi_masterExchangeList[] masterExchangeList { get; set; }
		public fkapi_masterExchangeGroupList[] masterExchangeGroupList { get; set; }
		public fkapi_masterExchangeCategoryList[] masterExchangeCategoryList { get; set; }
		public fkapi_masterExchangeCategoryGroupList[] masterExchangeCategoryGroupList { get; set; }
		public object[] userExchangeList { get; set; }
	}
	public class fkapi_masterExchangeList
	{
		public long id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string comment { get; set; }
		public long materialItemId { get; set; }
		public long materialAmount { get; set; }
		public long exchangeItemId { get; set; }
		public long exchangeAmount { get; set; }
		public long exchangeGroupId { get; set; }
		public long exchangeNum { get; set; }
		public long nextExchangeNum { get; set; }
		public long exchangeLimitCount { get; set; }
		public long characterLevelNum { get; set; }
		public long characterLevelExperience { get; set; }
		public long characterSkillLevelNum { get; set; }
		public long characterMaxEquipmentSlotCount { get; set; }
		public string textureName { get; set; }
	}
	public class fkapi_masterExchangeGroupList
	{
		public long id { get; set; }
		public long exchangeTypeId { get; set; }
		public long exchangeCategoryId { get; set; }
		public long exchangeExhibitionTypeId { get; set; }
		public long orderNum { get; set; }
		public string exchangeLimitText { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
	public class fkapi_masterExchangeCategoryList
	{
		public long id { get; set; }
		public long groupId { get; set; }
		public string name { get; set; }
		public long orderNum { get; set; }
		public string comment { get; set; }
		public string commentStartdate { get; set; }
		public string commentEnddate { get; set; }
		public string bannerImageUrl { get; set; }
	}
	public class fkapi_masterExchangeCategoryGroupList
	{
		public long id { get; set; }
		public string name { get; set; }
		public long orderNum { get; set; }
	}
}
