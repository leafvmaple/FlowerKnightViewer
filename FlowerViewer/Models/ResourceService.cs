using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerViewer.Properties;
using Livet;
using System.Globalization;

namespace FlowerViewer.Models
{
    /// <summary>
	/// 提供多语言支持
	/// </summary>
	public class ResourceService : NotificationObject
    {
        #region static members

        private static readonly ResourceService _Current = new ResourceService();

        public static ResourceService Current
        {
            get { return _Current; }
        }

        #endregion

        /// <summary>
        /// 支持的语言名称
        /// </summary>
        private readonly string[] _SupportedCultureNames =
        {
            "ja", // Resources.resx
			"en",
            "zh-CN",
            "ko-KR",
        };

        public Resources Resources { get; private set; }

        /// <summary>
        /// 从语言数组遍历出支持的语言选项
        /// </summary>
        public IReadOnlyCollection<CultureInfo> SupportedCultures { get; private set; }

        private ResourceService()
        {
            this.Resources = new Resources();
            this.SupportedCultures = this._SupportedCultureNames
                .Select(x =>
                {
                    try
                    {
                        return CultureInfo.GetCultureInfo(x);
                    }
                    catch (CultureNotFoundException)
                    {
                        return null;
                    }
                })
                .Where(x => x != null)
                .ToList();
        }

        /// <summary>
        /// 从Settings中获取指定的资源文件
        /// </summary>
        public void ChangeCulture(string name)
        {
            Resources.Culture = this.SupportedCultures.SingleOrDefault(x => x.Name == name);

            // 资源不存在是将其置空
            Settings.Current.Culture = Resources.Culture != null
                ? Resources.Culture.Name
                : null;

            this.RaisePropertyChanged("Resources");
        }
    }
}
