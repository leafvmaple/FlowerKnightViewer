using FlowerViewer.Models;
using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public class VolumeViewModel : ViewModel
    {
        private static Volume _Volume { get; } = Volume.Instance();

        private bool _IsMute = _Volume.GetMute();

        public bool IsMute
        {
            get { return this._IsMute; }
            private set
            {
                if (this._IsMute != value)
                {
                    this._IsMute = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public void ToggleMute()
        {
            _Volume.SetMute(!IsMute);
            IsMute = _Volume.GetMute();
        }
    }
}
