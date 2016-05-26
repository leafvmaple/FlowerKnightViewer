using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FlowerViewer.Models;
using FlowerViewer.ViewModels;
using System.Diagnostics;
using System.IO;

namespace FlowerViewer
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App
    {
        public static ProductInfo ProductInfo { get; private set; }
        public static MainWindowViewModel ViewModelRoot { get; private set; }

        static App()
        {
            // 添加未捕获异常的记录
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => ReportException(sender, args.ExceptionObject as Exception);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.DispatcherUnhandledException += (sender, args) => ReportException(sender, args.Exception);

            //DispatcherHelper.UIDispatcher = this.Dispatcher;
            ProductInfo = new ProductInfo();

            ViewModelRoot = new MainWindowViewModel();
            this.MainWindow = new MainWindow { DataContext = ViewModelRoot };
            this.MainWindow.Show();
        }

        private static void ReportException(object sender, Exception exception)
        {
            #region const
            const string messageFormat = @"
===========================================================
ERROR, date = {0}, sender = {1},
{2}
";
            const string path = "error.log";
            #endregion

            try
            {
                var message = string.Format(messageFormat, DateTimeOffset.Now, sender, exception);

                Debug.WriteLine(message);
                File.AppendAllText(path, message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
