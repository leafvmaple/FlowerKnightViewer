using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public class MainWindowViewModel : WindowViewModel
    {
        public NavigatorViewModel Navigator { get; private set; }

        public MainWindowViewModel()
        {
            this.Title = App.ProductInfo.Title;
            this.Navigator = new NavigatorViewModel();
        }
    }
}
