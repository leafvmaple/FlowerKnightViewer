using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels
{
    public class StartContentViewModel : ViewModel
    {
        private static StartContentViewModel _Instance = new StartContentViewModel();
        public static StartContentViewModel Instance
        {
            get { return _Instance; }
        }

        private StartContentViewModel()
        {
            
        }
    }
}
