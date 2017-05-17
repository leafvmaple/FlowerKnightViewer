using System;
using System.Collections.Generic;
using System.Linq;
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
        private IntPtr webHandle = IntPtr.Zero;
        public Tools()
        {
            InitializeComponent();
        }

        private void ToggleAutoBattle()
        {
            if (webHandle == IntPtr.Zero)
            {
                webHandle = mainWeb.Handle;
                StringBuilder className = new StringBuilder(100);
                while (className.ToString() != "Internet Explorer_Server") // 浏览器组件类获取
                {
                    webHandle = GetWindow(webHandle, 5); // 获取子窗口的句柄
                    GetClassName(webHandle, className, className.Capacity);
                }
            }
            if (DataUtil.Game.isAuto)
            {
                MiscHelper.SetAutoGo(false);
            }
            else if (DataUtil.Game.canAuto)
            {
                MiscHelper.SetAutoGo(true);
            }
        }
    }
}
