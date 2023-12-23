using Caliburn.Micro.Tutorial.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn.Micro.Tutorial.WPF
{
    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            LogManager.GetLog = type => new DebugLog(type);
            Initialize();
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewForAsync(typeof(ShellViewModel));
        }
    }
}
