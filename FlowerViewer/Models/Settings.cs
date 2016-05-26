using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Livet;

namespace FlowerViewer.Models
{
    [Serializable]
    public class Settings : NotificationObject
    {
        public static Settings Current { get; set; }

        public static void Load()
        {
            //try
            //{
            //    Current = filePath.ReadXml<Settings>();
            //}
            //catch (Exception ex)
            //{
            //    Current = GetInitialSettings();
            //    System.Diagnostics.Debug.WriteLine(ex);
            //}

            Current = GetInitialSettings();
        }
        public static Settings GetInitialSettings()
        {
            return new Settings
            {
            };
        }

        #region ProxySettings 変更通知

        private ProxySettings _ProxySettings;

        public ProxySettings ProxySettings
        {
            get { return this._ProxySettings ?? (this._ProxySettings = new ProxySettings()); }
            set
            {
                if (this._ProxySettings != value)
                {
                    this._ProxySettings = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion
    }
}
