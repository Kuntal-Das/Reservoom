using Models;
using ReserVoom.Services;
using ReserVoom.Stores;
using ReserVoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserVoom.Commands
{
    class NavigateCommand : CommandBase
    {
        private readonly NavigationService<ViewModelBase> _navigationService;

        public NavigateCommand(NavigationService<ViewModelBase> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}