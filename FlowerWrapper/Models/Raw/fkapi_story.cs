using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_story story;
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
		public long id { get; set; }
		public long userId { get; set; }
		public long storyId { get; set; }
	}
}
