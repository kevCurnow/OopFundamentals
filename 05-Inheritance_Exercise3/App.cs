using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise3
{
    public enum AppStatus
    {
        NotStarted = 1,
        WorkingOn,
        InProduction,
    }

    public class App
    {
        public string AppName { get; set; }
        public AppStatus AppStatus;
        private List<Developer> _developersOnApp;
        //private readonly List<Developer> _developersOnApp = new List<Developer>();

        public App()
        {

        }

        public App(string appName, AppStatus appStatus, List<Developer> developersOnApp)
        {
            AppName = appName;
            AppStatus = appStatus;
            _developersOnApp = developersOnApp;
        }

        public void AddDevToList(Developer dev)
        {
            _developersOnApp.Add(dev);
        }

    }
}
