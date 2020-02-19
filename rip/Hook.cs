using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rip
{
    class Hook
    {
        private Microsoft.Win32.PowerModeChangedEventHandler handler;

        public Hook() {
            handler = new Microsoft.Win32.PowerModeChangedEventHandler(Proc);
        }

        public void Register()
        {
            Microsoft.Win32.SystemEvents.PowerModeChanged += handler;
        }
        public void Unregister()
        {
            Microsoft.Win32.SystemEvents.PowerModeChanged -= handler;
        }

        private void Proc(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            var vol = new Volume();
            switch ( e.Mode)
            {
                case Microsoft.Win32.PowerModes.Suspend:
                    vol.Mute();
                    break;

                case Microsoft.Win32.PowerModes.Resume:
                    vol.Unmute();
                    break;
            }
        }
    }
}
