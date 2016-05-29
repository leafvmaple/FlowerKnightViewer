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

        private static MainContentViewModel _Instance = new MainContentViewModel();
        public static MainContentViewModel Instance
        {
            get { return _Instance; }
        }

        private MainContentViewModel()
        {
            Knight = new KnightViewModel();
        }
    }
}
