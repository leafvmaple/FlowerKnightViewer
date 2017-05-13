using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerWrapper.Interface
{
	/// <summary>
	/// プロキシ設定の種類を表します。
	/// </summary>
	public enum ProxyType
	{
		/// <summary>
		/// プロキシを使用せず、直接サーバーに接続します。
		/// </summary>
		DirectAccess,

		/// <summary>
		/// システムのプロキシ設定を使用します。
		/// </summary>
		SystemProxy,

		/// <summary>
		/// 指定のプロキシ設定を使用します。
		/// </summary>
		SpecificProxy,
	}
}
