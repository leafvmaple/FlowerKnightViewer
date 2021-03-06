﻿using FlowerViewer.Models;
using FlowerViewer.ViewModels.Contents;
using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public class MainContentViewModel : ViewModel
    {
        public KnightViewModel Knight { get; private set; }
        public VolumeViewModel Volume { get; private set; }

        public IList<TabItemViewModel> TabItems { get; set; }
        public IList<TabItemViewModel> SystemTabItems { get; set; }

        private TabItemViewModel _SelectedItem;

        public TabItemViewModel SelectedItem
        {
            get { return this._SelectedItem; }
            set
            {
                if (this._SelectedItem != value)
                {
                    this._SelectedItem = value;
                    this.RaisePropertyChanged();

                    App.ViewModelRoot.StatusBar = value;
                }
            }
        }

        private static MainContentViewModel _Instance = new MainContentViewModel();
        public static MainContentViewModel Instance
        {
            get { return _Instance; }
        }

        private MainContentViewModel()
        {
            Knight = new KnightViewModel();
            Volume = new VolumeViewModel();

            TabItems = new List<TabItemViewModel>
            {
                new ToolsViewModel(),
            };
            SystemTabItems = new List<TabItemViewModel>
            {
                new SettingsViewModel(),
#if DEBUG
				//new DebugTabViewModel(),
#endif
			};
        }
    }
}
