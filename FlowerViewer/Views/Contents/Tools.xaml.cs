using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowerViewer.Views.Contents
{
    /// <summary>
    /// Tools.xaml 的交互逻辑
    /// </summary>
    public partial class Tools : UserControl
    {
        public static event EventHandler<EventArgs> ClickEvent;
        public Tools()
        {
            InitializeComponent();
        }

        private void ToggleAutoBattle(object sender, RoutedEventArgs e)
        {
            ClickEvent(sender, new EventArgs());
        }
    }
}
