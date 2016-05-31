using System;

namespace FlowerWrapper.Models.Raw
{
	//fkapi_encounter_dungeon encounter_dungeon;
	public class fkapi_encounter_dungeon
	{
		public object[] masterDungeonList { get; set; }
		public object[] masterStageList { get; set; }
		public object[] userEncounterOpenStageList { get; set; }
		public string errorMessage { get; set; }
		public string resultCode { get; set; }
		public string buildVersion { get; set; }
		public string serverTime { get; set; }
	}
}
