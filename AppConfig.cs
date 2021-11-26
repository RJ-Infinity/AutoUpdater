using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoUpdater
{
    internal class AppConfig
    {
        public string InstallLocation;
        public Version Version;
        public string App { get; }
        public bool AutoUpdate;
        public AppConfig(string app)
        {
            App = app;
        }
    }
}
