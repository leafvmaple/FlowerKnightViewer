// 
// 该文件由 "FlowerProxy.Endpoints.tt" 生成
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Fiddler;

namespace FlowerWrapper
{
	partial class FlowerProxy
	{
		/// <summary>
		/// Endpoint "/api/v1/user/login" 传输协议
		/// </summary>
		public IObservable<Session> api_user_login
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/user/login"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/master/getMaster" 传输协议
		/// </summary>
		public IObservable<Session> api_master_getMaster
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/master/getMaster"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/config/getNews" 传输协议
		/// </summary>
		public IObservable<Session> api_config_getNews
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/config/getNews"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/friend/getFriendAcceptList" 传输协议
		/// </summary>
		public IObservable<Session> api_friend_getFriendAcceptList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/friend/getFriendAcceptList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/present/getPresentBoxList" 传输协议
		/// </summary>
		public IObservable<Session> api_present_getPresentBoxList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/present/getPresentBoxList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/friend/getFriendList" 传输协议
		/// </summary>
		public IObservable<Session> api_friend_getFriendList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/friend/getFriendList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/raidBoss/getRaidBossList" 传输协议
		/// </summary>
		public IObservable<Session> api_raidBoss_getRaidBossList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/raidBoss/getRaidBossList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/character/getBook" 传输协议
		/// </summary>
		public IObservable<Session> api_character_getBook
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/character/getBook"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/character/saveParty" 传输协议
		/// </summary>
		public IObservable<Session> api_character_saveParty
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/character/saveParty"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/dungeon/getEventDungeonList" 传输协议
		/// </summary>
		public IObservable<Session> api_dungeon_getEventDungeonList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/dungeon/getEventDungeonList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/dungeon/getEncounterDungeonList" 传输协议
		/// </summary>
		public IObservable<Session> api_dungeon_getEncounterDungeonList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/dungeon/getEncounterDungeonList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/story/getStoryList" 传输协议
		/// </summary>
		public IObservable<Session> api_story_getStoryList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/story/getStoryList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/event/getEventDetail" 传输协议
		/// </summary>
		public IObservable<Session> api_event_getEventDetail
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/event/getEventDetail"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/gacha/getGachaSchedule" 传输协议
		/// </summary>
		public IObservable<Session> api_gacha_getGachaSchedule
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/gacha/getGachaSchedule"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/boxGacha/getBoxGachaSchedule" 传输协议
		/// </summary>
		public IObservable<Session> api_boxGacha_getBoxGachaSchedule
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/boxGacha/getBoxGachaSchedule"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/exchange/getExchangeList" 传输协议
		/// </summary>
		public IObservable<Session> api_exchange_getExchangeList
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/exchange/getExchangeList"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/campaignSerial/getCampaignSerialSchedule" 传输协议
		/// </summary>
		public IObservable<Session> api_campaignSerial_getCampaignSerialSchedule
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/campaignSerial/getCampaignSerialSchedule"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/character/getBook" 传输协议
		/// </summary>
		public IObservable<Session> api_character_getBook
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/character/getBook"); }
		}

		/// <summary>
		/// Endpoint "/api/v1/mission/setPanelMissionStatus" 传输协议
		/// </summary>
		public IObservable<Session> api_mission_setPanelMissionStatus
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/api/v1/mission/setPanelMissionStatus"); }
		}

	}
}
