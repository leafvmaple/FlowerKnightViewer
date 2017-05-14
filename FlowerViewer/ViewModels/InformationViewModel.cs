using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public class InformationViewModel : ViewModel
    {
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
                }
            }
        }
    }
}
