using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_friend friend;
	public class fkapi_friend
	{
		public fkapi_userFriendInformationList[] userFriendInformationList { get; set; }
		public fkapi_userMissionList[] userMissionList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_userFriendInformationList
	{
		public int userId { get; set; }
		public string openSocialId { get; set; }
		public string userName { get; set; }
		public int userLevelNum { get; set; }
		public int character1Id { get; set; }
		public int character1LevelNum { get; set; }
		public int character1SkillLevelNum { get; set; }
		public int character2Id { get; set; }
		public int character2LevelNum { get; set; }
		public int character2SkillLevelNum { get; set; }
		public int character3Id { get; set; }
		public int character3LevelNum { get; set; }
		public int character3SkillLevelNum { get; set; }
		public int character4Id { get; set; }
		public int character4LevelNum { get; set; }
		public int character4SkillLevelNum { get; set; }
		public int character5Id { get; set; }
		public int character5LevelNum { get; set; }
		public int character5SkillLevelNum { get; set; }
		public string lastPlayed { get; set; }
		public int totalEvaluationPoint { get; set; }
		public int totalPower { get; set; }
		public string created { get; set; }
		public int deputyLeaderCharacterId { get; set; }
	}
}
