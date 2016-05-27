using System;

namespace FlowerWrapper.Models.Raw
{
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
		public int characterId { get; set; }
		public int status { get; set; }
		public string created { get; set; }
	}
	public class fkapi_userCharacterBookGroupList
	{
		public int id { get; set; }
		public int characterBookId { get; set; }
		public int status { get; set; }
		public int favorabilityValue { get; set; }
		public string created { get; set; }
	}
}
