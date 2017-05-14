using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerViewer.ViewModels.Contents
{
    public class ToolsViewModel : TabItemViewModel
    {
        public override string Name
        {
            get { return "Tools"; }

            protected set{ throw new NotImplementedException(); }
        }
    }
}
