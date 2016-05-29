using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerWrapper.Models;
using FlowerWrapper;
using Livet;
using Livet.EventListeners;

namespace FlowerViewer.ViewModels
{
    public class KnightViewModel : ViewModel
    {
        public Knight Model
        {
            get
            {
                return FlowerClient.Current.Garden.Knight;
            }
        }

        public KnightViewModel()
        {
            this.CompositeDisposable.Add(new PropertyChangedEventListener(FlowerClient.Current.Garden)
            {
                { "Knight", (sender, args) => this.Update() },
            });
        }

        private void Update()
        {
            this.RaisePropertyChanged("Model");
        }
    }
}
