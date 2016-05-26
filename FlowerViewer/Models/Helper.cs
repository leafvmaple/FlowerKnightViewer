using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FlowerViewer.Win32;
using Livet;

namespace FlowerViewer.Models
{
    public class Helper
    {
        static Helper()
        {
            var version = Environment.OSVersion.Version;
            IsWindows8OrGreater = (version.Major == 6 && version.Minor >= 2) || version.Major > 6;
        }


        /// <summary>
        /// Windows 8 版本确认。
        /// </summary>
        public static bool IsWindows8OrGreater { get; private set; }

        /// <summary>
        /// 确定是否是设计模式。
        /// </summary>
        public static bool IsInDesignMode
        {
            get { return DesignerProperties.GetIsInDesignMode(new DependencyObject()); }
        }


        public static string CreateScreenshotFilePath()
        {
            //var filePath = Path.Combine(
            //    Settings.Current.ScreenshotFolder,
            //    string.Format("KanColle-{0}", DateTimeOffset.Now.LocalDateTime.ToString("yyMMdd-HHmmssff")));

            //filePath = Path.ChangeExtension(
            //    filePath,
            //    Settings.Current.ScreenshotImageFormat == SupportedImageFormat.Jpeg
            //        ? ".jpg"
            //        : ".png");

            //return filePath;
            return string.Empty;
        }


        /// <summary>
        /// HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION
        /// に WebBrowser 设置注册表让程序使用特定IE打开。
        /// </summary>
        public static void SetRegistryFeatureBrowserEmulation()
        {
            //强制IE浏览器或WebBrowser控件使用指定版本显示网页
            const string key = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";

            try
            {
                var valueName = Process.GetCurrentProcess().ProcessName + ".exe";
                if (Registry.GetValue(key, valueName, null) == null)
                {
                    Registry.SetValue(key, valueName, Properties.Settings.Default.FeatureBrowserEmulation, RegistryValueKind.DWord);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void SetMMCSSTask()
        {
            var index = 0u;
            NativeMethods.AvSetMmThreadCharacteristics("Games", ref index);
        }


        /// <summary>
        /// 清楚IE缓存。
        /// </summary>
        /// <seealso cref="http://support.microsoft.com/kb/326201/ja"/>
        public static Task<bool> DeleteInternetCache()
        {
            return Task.Factory.StartNew(() => DeleteInternetCacheCore());
        }

        private static bool DeleteInternetCacheCore()
        {
            // ReSharper disable InconsistentNaming
            const int CACHEGROUP_SEARCH_ALL = 0x0;
            const int ERROR_NO_MORE_ITEMS = 259;
            const uint CacheEntryType_Cookie = 1048577;
            const uint CacheEntryType_History = 2097153;
            // ReSharper restore InconsistentNaming

            long groupId = 0;
            var cacheEntryInfoBufferSizeInitial = 0;

            var enumHandle = WinInet.FindFirstUrlCacheGroup(0, CACHEGROUP_SEARCH_ALL, IntPtr.Zero, 0, ref groupId, IntPtr.Zero);
            if (enumHandle != IntPtr.Zero && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error()) return false;

            enumHandle = WinInet.FindFirstUrlCacheEntry(null, IntPtr.Zero, ref cacheEntryInfoBufferSizeInitial);
            if (enumHandle != IntPtr.Zero && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error()) return false;

            var cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
            var cacheEntryInfoBuffer = Marshal.AllocHGlobal(cacheEntryInfoBufferSize);
            enumHandle = WinInet.FindFirstUrlCacheEntry(null, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);

            while (true)
            {
                var internetCacheEntry = (INTERNET_CACHE_ENTRY_INFOA)Marshal.PtrToStructure(
                    cacheEntryInfoBuffer, typeof(INTERNET_CACHE_ENTRY_INFOA));
                cacheEntryInfoBufferSizeInitial = cacheEntryInfoBufferSize;

                var type = internetCacheEntry.CacheEntryType;
                var result = false;

                if (type != CacheEntryType_Cookie && type != CacheEntryType_History)
                {
                    result = WinInet.DeleteUrlCacheEntry(internetCacheEntry.lpszSourceUrlName);
                }

                if (!result)
                {
                    result = WinInet.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                }
                if (!result && ERROR_NO_MORE_ITEMS == Marshal.GetLastWin32Error())
                {
                    break;
                }
                if (!result && cacheEntryInfoBufferSizeInitial > cacheEntryInfoBufferSize)
                {
                    cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
                    cacheEntryInfoBuffer = Marshal.ReAllocHGlobal(cacheEntryInfoBuffer, (IntPtr)cacheEntryInfoBufferSize);
                    WinInet.FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                }
            }

            Marshal.FreeHGlobal(cacheEntryInfoBuffer);

            return true;
        }


        /// <summary>
        /// 指定字符串编码。
        /// </summary>
        public static string EncryptString(string source, string password)
        {
            using (var rijndael = new RijndaelManaged())
            {
                byte[] key, iv;
                GenerateKeyFromPassword(password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
                rijndael.Key = key;
                rijndael.IV = iv;

                using (var encryptor = rijndael.CreateEncryptor())
                {
                    var strBytes = Encoding.UTF8.GetBytes(source);
                    var encBytes = encryptor.TransformFinalBlock(strBytes, 0, strBytes.Length);
                    return Convert.ToBase64String(encBytes);
                }
            }
        }

        /// <summary>
        /// 指定字符串解码。
        /// </summary>
        public static string DecryptString(string source, string password)
        {
            try
            {
                using (var rijndael = new RijndaelManaged())
                {
                    byte[] key, iv;
                    GenerateKeyFromPassword(password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
                    rijndael.Key = key;
                    rijndael.IV = iv;

                    using (var decryptor = rijndael.CreateDecryptor())
                    {
                        var strBytes = Convert.FromBase64String(source);
                        var decBytes = decryptor.TransformFinalBlock(strBytes, 0, strBytes.Length);
                        return Encoding.UTF8.GetString(decBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static void GenerateKeyFromPassword(string password, int keySize, out byte[] key, int blockSize, out byte[] iv)
        {
            var salt = Encoding.UTF8.GetBytes("C98534F6-7286-4BED-83A6-10FD5052ABA6");
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt) { IterationCount = 1000 })
            {
                key = deriveBytes.GetBytes(keySize / 8);
                iv = deriveBytes.GetBytes(blockSize / 8);
            }
        }
    }
}