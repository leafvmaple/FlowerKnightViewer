using System;

namespace FlowerWrapper.Models.Raw
{
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
		public fkapi_userExchangeList[] userExchangeList { get; set; }
	}
	public class fkapi_masterExchangeList
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string comment { get; set; }
		public int materialItemId { get; set; }
		public int materialAmount { get; set; }
		public int exchangeItemId { get; set; }
		public int exchangeAmount { get; set; }
		public int exchangeGroupId { get; set; }
		public int exchangeNum { get; set; }
		public int nextExchangeNum { get; set; }
		public int exchangeLimitCount { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
		public int characterSkillLevelNum { get; set; }
		public int characterMaxEquipmentSlotCount { get; set; }
		public string textureName { get; set; }
	}
	public class fkapi_masterExchangeGroupList
	{
		public int id { get; set; }
		public int exchangeTypeId { get; set; }
		public int exchangeCategoryId { get; set; }
		public int exchangeExhibitionTypeId { get; set; }
		public int orderNum { get; set; }
		public string exchangeLimitText { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
	public class fkapi_masterExchangeCategoryList
	{
		public int id { get; set; }
		public int groupId { get; set; }
		public string name { get; set; }
		public int orderNum { get; set; }
		public string comment { get; set; }
		public string commentStartdate { get; set; }
		public string commentEnddate { get; set; }
		public string bannerImageUrl { get; set; }
	}
	public class fkapi_masterExchangeCategoryGroupList
	{
		public int id { get; set; }
		public string name { get; set; }
		public int orderNum { get; set; }
	}
	public class fkapi_userExchangeList
	{
	}
