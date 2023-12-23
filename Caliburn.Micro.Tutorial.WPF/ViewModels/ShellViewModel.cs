using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Tutorial.WPF.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
        private readonly IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public Task About()
        {
            return _windowManager.ShowDialogAsync(IoC.Get<AboutViewModel>());
        }

        public Task EditCategories()
        {
            var viewmodel = IoC.Get<CategoryViewModel>();
            return ActivateItemAsync(viewmodel, new CancellationToken());
        }

        protected async override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await EditCategories();
        }

        public bool CanFileMenu
        {
            get
            {
                return false;
            }
        }
    }
}
