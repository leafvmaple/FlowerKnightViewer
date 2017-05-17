using System;
using System.ComponentModel;
using FlowerViewer.Views.Contents;
using System.Text;
using FlowerViewer.Models;
using FlowerViewer.Models.Data.Interface;

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
            Tools.ClickEvent += BrowerAutoBattle;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //e.Cancel = true;

            //var dialog = new ExitDialog { Owner = this, };
            //dialog.Show();

            base.OnClosing(e);
        }

        public void BrowerAutoBattle(Object sender, EventArgs message)
        {
            if (Intelligent.Current.WebHandle == IntPtr.Zero)
            {
                Intelligent.Current.WebHandle = FlowerWebBrower.Handle;
                StringBuilder className = new StringBuilder(100);
                while (className.ToString() != "Internet Explorer_Server")
                {
                    Intelligent.Current.WebHandle = WinAPI.GetWindow(Intelligent.Current.WebHandle, 5);
                    WinAPI.GetClassName(Intelligent.Current.WebHandle, className, className.Capacity);
                }
            }

            Intelligent.Current.ToggleAutoBattle(!Models.Settings.Current.IsAutoBattle);
        }
    }
}
