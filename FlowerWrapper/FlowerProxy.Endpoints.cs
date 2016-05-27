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

	}
}
