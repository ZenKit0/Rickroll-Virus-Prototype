using System;

namespace Rickroll {
    class Program {
        static void Main(string[] args) {
            Audio audio = new Audio();
            audio.SetMaxVolume();

            Browser browser = new Browser();
            browser.StartRickroll();
            browser.StartCMD();

            Environment.Exit(0);
        }
    }
}
