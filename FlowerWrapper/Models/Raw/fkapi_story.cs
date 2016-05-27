using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_story
	{
		public fkapi_userStoryList[] userStoryList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userStoryList
	{
		public int id { get; set; }
		public int userId { get; set; }
		public int storyId { get; set; }
	}
