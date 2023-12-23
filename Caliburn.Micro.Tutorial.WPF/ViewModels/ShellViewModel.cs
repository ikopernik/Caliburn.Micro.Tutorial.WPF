using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Tutorial.WPF.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
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
    }
}
