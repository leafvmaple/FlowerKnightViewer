using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_present_box present_box;
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
		public long id { get; set; }
		public long sendUserId { get; set; }
		public long receiveUserId { get; set; }
		public string subject { get; set; }
		public string body { get; set; }
		public long sendUserTypeId { get; set; }
		public long itemCategoryId { get; set; }
		public long itemId { get; set; }
		public long amount { get; set; }
		public long characterLevelNum { get; set; }
		public long characterLevelExperience { get; set; }
		public long characterMaxEquipmentSlotCount { get; set; }
		public long characterSkillLevelNum { get; set; }
		public long status { get; set; }
		public string receivedDate { get; set; }
		public string limitDate { get; set; }
	}
}
