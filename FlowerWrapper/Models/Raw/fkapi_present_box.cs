using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_present_box
	{
		public fkapi_userMailList[] userMailList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userMailList
	{
		public int id { get; set; }
		public int sendUserId { get; set; }
		public int receiveUserId { get; set; }
		public string subject { get; set; }
		public string body { get; set; }
		public int sendUserTypeId { get; set; }
		public int itemCategoryId { get; set; }
		public int itemId { get; set; }
		public int amount { get; set; }
		public int characterLevelNum { get; set; }
		public int characterLevelExperience { get; set; }
		public int characterMaxEquipmentSlotCount { get; set; }
		public int characterSkillLevelNum { get; set; }
		public int status { get; set; }
		public string receivedDate { get; set; }
		public string limitDate { get; set; }
	}
