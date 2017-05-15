using FlowerViewer.Models;
using Livet;
using Livet.EventListeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public abstract class TabItemViewModel : ViewModel
    {
        public abstract string Name { get; protected set; }

        private bool _IsSelected;

        public  bool IsSelected
        {
            get { return this._IsSelected; }
            set
            {
                if (this._IsSelected != value)
                {
                    this._IsSelected = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private int? _Badge;

        public virtual int? Badge
        {
            get { return this._Badge; }
            protected set
            {
                if (this._Badge != value)
                {
                    this._Badge = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private ViewModel _Status;

        public virtual ViewModel Status
        {
            get { return this._Status; }
            protected set
            {
                if (this._Status != value)
                {
                    this._Status = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        protected TabItemViewModel()
        {
            this.CompositeDisposable.Add(new PropertyChangedEventListener(ResourceService.Current)
            {
                (sender, args) => this.RaisePropertyChanged(nameof(this.Name)),
            });
        }
    }
}
