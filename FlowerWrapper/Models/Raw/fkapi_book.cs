using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_book book;
	public class fkapi_book
	{
		public fkapi_userCharacterBookList[] userCharacterBookList { get; set; }
		public fkapi_userCharacterBookGroupList[] userCharacterBookGroupList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userCharacterBookList
	{
		public long characterId { get; set; }
		public long status { get; set; }
		public string created { get; set; }
	}
	public class fkapi_userCharacterBookGroupList
	{
		public long id { get; set; }
		public long characterBookId { get; set; }
		public long status { get; set; }
		public long favorabilityValue { get; set; }
		public string created { get; set; }
	}
}
