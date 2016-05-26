using System;
using System.ComponentModel;

namespace FlowerViewer.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //e.Cancel = true;

            //var dialog = new ExitDialog { Owner = this, };
            //dialog.Show();

            base.OnClosing(e);
        }
    }
}
