
using System.Diagnostics;

namespace Rickroll {
    class Browser {
        private string rickrollUrl { get; } = "https://www.youtube.com/watch?v=xvFZjo5PgG0";

        public void StartRickroll() {
            for (int i = 0; i < 50; i++) {
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:{rickrollUrl}"));
            }
        }

        public void StartCMD() {
            Process.Start(new ProcessStartInfo("cmd", $"/c start calc"));
            Process.Start(new ProcessStartInfo("cmd", $"/c start notepad.exe"));
            Process.Start(new ProcessStartInfo("cmd", $"/c start appwiz.cpl"));
            Process.Start(new ProcessStartInfo("cmd", $"/c start ms-settings:"));
            Process.Start(new ProcessStartInfo("cmd", $"/c start taskschd.msc"));
        }
    }
}
