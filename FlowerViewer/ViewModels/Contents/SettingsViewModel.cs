using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels.Contents
{
    public class SettingsViewModel : TabItemViewModel
    {
        public override string Name
        {
            get { return "Settings"; }

            protected set { throw new NotImplementedException(); }
        }
    }
}
