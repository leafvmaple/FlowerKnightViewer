using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FlowerViewer.Models.Data.Xml;
using Livet;

namespace FlowerViewer.Models
{
    [Serializable]
    public class Settings : NotificationObject
    {
        private static readonly string _FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "leafvmaple.com",
            "FlowerViewer",
            "Settings.xml");

        public static Settings Current { get; set; }

        public static void Load()
        {
            try
            {
                Current = _FilePath.ReadXml<Settings>();
            }
            catch (Exception ex)
            {
                Current = GetInitialSettings();
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private bool _TopMost;

        public bool TopMost
        {
            get { return this._TopMost; }
            set
            {
                if (this._TopMost != value)
                {
                    this._TopMost = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public static Settings GetInitialSettings()
        {
            return new Settings
            {
                IsAutoBattle = false,
            };
        }

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

        private string _Culture;

        public string Culture
        {
            get { return this._Culture; }
            set
            {
                if (this._Culture != value)
                {
                    this._Culture = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private bool _IsAutoBattle;

        public bool IsAutoBattle
        {
            get { return this._IsAutoBattle; }
            set
            {
                if (this._IsAutoBattle != value)
                {
                    this._IsAutoBattle = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        public void Save()
        {
            try
            {
                this.WriteXml(_FilePath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
