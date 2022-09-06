
using System.Runtime.InteropServices;

namespace Rickroll {
    class Audio {

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private enum Keys {
            VolumeMute = 173,
            VolumeDown,
            VolumeUp
        }
        
        private void VolumeUp() => keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
        public void SetMaxVolume() {
            for (int i = 0; i < 400; i++) {
                VolumeUp();
            }
        }
    }
}
