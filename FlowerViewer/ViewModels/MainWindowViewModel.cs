using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerViewer.Models;
using Livet;
using FlowerWrapper;

namespace FlowerViewer.ViewModels
{
    public class MainWindowViewModel : WindowViewModel
    {
        public NavigatorViewModel Navigator { get; private set; }

        public MainWindowViewModel()
        {
            this.Title = App.ProductInfo.Title;
            this.Navigator = new NavigatorViewModel();

            this.UpdateMode();
        }

        private Mode _Mode;
        public Mode Mode
        {
            get { return this._Mode; }
            set
            {
                this._Mode = value;
                switch (value)
                {
                    case Mode.NotStarted:
                        this.Content = StartContentViewModel.Instance;
                        this.StatusBar = StartContentViewModel.Instance;
                        //StatusService.Current.Set(Properties.Resources.StatusBar_NotStarted);
                        //ThemeService.Current.ChangeAccent(Accent.Purple);
                        break;
                    case Mode.Started:
                        this.Content = MainContentViewModel.Instance;
                        //StatusService.Current.Set(Properties.Resources.StatusBar_Ready);
                        //ThemeService.Current.ChangeAccent(Accent.Blue);
                        break;
                    case Mode.InSortie:
                        //ThemeService.Current.ChangeAccent(Accent.Orange);
                        break;
                }

                this.RaisePropertyChanged();
            }
        }

        #region Content 変更通知

        private ViewModel _Content;
        public ViewModel Content
        {
            get { return this._Content; }
            set
            {
                if (this._Content != value)
                {
                    this._Content = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region StatusBar 変更通知

        private ViewModel _StatusBar;
        public ViewModel StatusBar
        {
            get { return this._StatusBar; }
            set
            {
                if (this._StatusBar != value)
                {
                    this._StatusBar = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        private void UpdateMode()
        {
            //this.Mode = FlowerClient.Current.IsStarted
            //    ? FlowerClient.Current.IsInSortie
            //        ? Mode.InSortie
            //        : Mode.Started
            //    : Mode.NotStarted;

            this.Mode = Mode.Started;
        }
    }
}
