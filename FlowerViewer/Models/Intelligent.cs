using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlowerViewer.Models.Data.Interface;

namespace FlowerViewer.Models
{
    public class Intelligent
    {
        public const int AUTO_GO_TIMEOUT = 330;
        public Timer _TimerAutoBattle;

        public IntPtr WebHandle { get; set; } = IntPtr.Zero;

        private static Intelligent _Current = null;
        public static Intelligent Current
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new Intelligent();
                }
                return _Current;
            }
        }

        private Intelligent()
        {
            _TimerAutoBattle = new Timer(new TimerCallback(AutoClickBattleMouse), this, Timeout.Infinite, AUTO_GO_TIMEOUT);
        }

        public void ToggleAutoBattle(bool bAutoBattle)
        {
            if (bAutoBattle)
            {
                _TimerAutoBattle.Change(0, AUTO_GO_TIMEOUT);
            }
            else
            {
                _TimerAutoBattle.Change(Timeout.Infinite, AUTO_GO_TIMEOUT);
            }

            Settings.Current.IsAutoBattle = bAutoBattle;
        }

        private void AutoClickBattleMouse(object data)
        {
            if (!Settings.Current.IsAutoBattle || WebHandle == IntPtr.Zero)
            {
                _TimerAutoBattle.Change(Timeout.Infinite, AUTO_GO_TIMEOUT);
                return;
            }
            int x = 855, y = 545;
            IntPtr lParam = (IntPtr)((y << 16) | x);
            IntPtr wParam = IntPtr.Zero;
            const uint downCode = 0x201;
            const uint upCode = 0x202;
            WinAPI.SendMessage(WebHandle, downCode, wParam, lParam);
            WinAPI.SendMessage(WebHandle, upCode, wParam, lParam);
        }
    }
}
