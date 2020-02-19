using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;

namespace rip
{
    public class Volume
    {
        public AudioEndpointVolume Load()
        {
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            return DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia).AudioEndpointVolume;
        }

        public void Mute()
        {
            var vol = Load();
            vol.Mute = true;
        }

        public void Unmute()
        {
            var vol = Load();
            vol.Mute = false;
        }
    }
}
