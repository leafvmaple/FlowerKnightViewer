﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FlowerViewer.Models;
using FlowerViewer.Views;
using FlowerViewer.ViewModels;
using System.Diagnostics;
using System.IO;
using FlowerWrapper;
using AppSettings = FlowerViewer.Properties.Settings;
using Settings = FlowerViewer.Models.Settings;

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

            Helper.SetRegistryFeatureBrowserEmulation();
            Helper.SetMMCSSTask();

            Settings.Load();
            FlowerClient.Current.Proxy.UpstreamProxySettings = Settings.Current.ProxySettings;
            FlowerClient.Current.Proxy.Startup(AppSettings.Default.LocalProxyPort);

            //DispatcherHelper.UIDispatcher = this.Dispatcher;
            ProductInfo = new ProductInfo();

            ViewModelRoot = new MainWindowViewModel();
            this.MainWindow = new MainWindow { DataContext = ViewModelRoot };
            this.MainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            FlowerClient.Current.Proxy.Shutdown();
            Settings.Current.Save();
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
