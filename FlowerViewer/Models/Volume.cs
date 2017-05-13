using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vannatech.CoreAudio.Constants;
using Vannatech.CoreAudio.Enumerations;
using Vannatech.CoreAudio.Externals;
using Vannatech.CoreAudio.Interfaces;

namespace FlowerViewer.Models
{
    class Volume : NotificationObject, IAudioSessionEvents
    {
        private ISimpleAudioVolume   _SimpleAudioVolume;
        private IAudioSessionControl _SessionControl;
        private static Volume        _Volume;

        private bool _IsMute;

        public bool IsMute
        {
            get { return this._IsMute; }
            private set
            {
                if (this._IsMute != value)
                {
                    this._IsMute = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public static Volume Instance()
        {
            if (_Volume == null)
            {
                _Volume = new Volume();

                var deviceEnumeratorType = Type.GetTypeFromCLSID(new Guid(ComCLSIDs.MMDeviceEnumeratorCLSID));
                var devenum = (IMMDeviceEnumerator)Activator.CreateInstance(deviceEnumeratorType);

                IMMDevice device;
                devenum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out device);

                object objSessionManager;
                device.Activate(new Guid(ComIIDs.IAudioSessionManager2IID), (uint)CLSCTX.CLSCTX_INPROC_SERVER, IntPtr.Zero, out objSessionManager);
                var sessionManager = objSessionManager as IAudioSessionManager2;
                if (sessionManager == null) throw new Exception("Session is not found.");

                IAudioSessionEnumerator sessions;
                sessionManager.GetSessionEnumerator(out sessions);

                ISimpleAudioVolume simpleAudioVolume;
                sessionManager.GetSimpleAudioVolume(Guid.Empty, 0, out simpleAudioVolume);
                _Volume._SimpleAudioVolume = simpleAudioVolume;

                simpleAudioVolume.GetMute(out _Volume._IsMute);

                sessionManager.GetAudioSessionControl(Guid.Empty, 0, out _Volume._SessionControl);
                _Volume._SessionControl.RegisterAudioSessionNotification(_Volume);
            }
            return _Volume;
        }

        public void ToggleMute()
        {
            _SimpleAudioVolume.SetMute(!IsMute, Guid.NewGuid());

            bool bValue;
            _SimpleAudioVolume.GetMute(out bValue);

            IsMute = bValue;
        }

        public int OnChannelVolumeChanged(uint channelCount, IntPtr newVolumes, uint channelIndex, ref Guid eventContext)
        {
            return 0;
        }

        public int OnDisplayNameChanged(string displayName, ref Guid eventContext)
        {
            return 0;
        }

        public int OnGroupingParamChanged(ref Guid groupingId, ref Guid eventContext)
        {
            return 0;
        }

        public int OnIconPathChanged(string iconPath, ref Guid eventContext)
        {
            return 0;
        }

        public int OnSessionDisconnected(AudioSessionDisconnectReason disconnectReason)
        {
            return 0;
        }

        public int OnSimpleVolumeChanged(float volume, bool isMuted, ref Guid eventContext)
        {
            return 0;
        }

        public int OnStateChanged(AudioSessionState state)
        {
            return 0;
        }
    }
}
