using ReserVoom.Stores;
using ReserVoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserVoom.Services
{
    public class ParameterisedNavigationService<TParameter, TViewModel>
        where TViewModel : ViewModelBase
    {
        private readonly NavigationStore<TViewModel> _navigationStore;
        private readonly Func<TParameter, TViewModel> _createViewModel;

        public void Navigate(TParameter parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}
