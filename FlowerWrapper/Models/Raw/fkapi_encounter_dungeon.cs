using System;

namespace FlowerWrapper.Models.Raw
{
	public class fkapi_encounter_dungeon
	{
		public fkapi_masterDungeonList[] masterDungeonList { get; set; }
		public fkapi_masterStageList[] masterStageList { get; set; }
		public fkapi_userEncounterOpenStageList[] userEncounterOpenStageList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
	public class fkapi_masterDungeonList
	{
	}
	public class fkapi_masterStageList
	{
	}
	public class fkapi_userEncounterOpenStageList
	{
	}
