using System;

namespace FlowerWrapper.Models.Raw
{
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
		public long userId { get; set; }
		public string openSocialId { get; set; }
		public string userName { get; set; }
		public long userLevelNum { get; set; }
		public long character1Id { get; set; }
		public long character1LevelNum { get; set; }
		public long character1SkillLevelNum { get; set; }
		public long character2Id { get; set; }
		public long character2LevelNum { get; set; }
		public long character2SkillLevelNum { get; set; }
		public long character3Id { get; set; }
		public long character3LevelNum { get; set; }
		public long character3SkillLevelNum { get; set; }
		public long character4Id { get; set; }
		public long character4LevelNum { get; set; }
		public long character4SkillLevelNum { get; set; }
		public long character5Id { get; set; }
		public long character5LevelNum { get; set; }
		public long character5SkillLevelNum { get; set; }
		public string lastPlayed { get; set; }
		public long totalEvaluationPoint { get; set; }
		public long totalPower { get; set; }
		public string created { get; set; }
		public long deputyLeaderCharacterId { get; set; }
	}
}
