using Models;
using ReserVoom.Commands;
using ReserVoom.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReserVoom.ViewModels
{
    public class ReservationListViewModel : ViewModelBase
    {
        public ICommand MakeReservationCommand { get; }

        private readonly Hotel _hotel;
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ReservationListViewModel(Hotel hotel, NavigationService<ViewModelBase> navigateToMakeReservationService)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            //NavigationService<ViewModelBase> makeReservationNavigationService =
            //    new NavigationService<ViewModelBase>(navigationStore, () => new MakeReservationViewModel(hotel, navigationStore));

            MakeReservationCommand = new NavigateCommand(navigateToMakeReservationService);

            UpdateReservationList();
        }

        private void UpdateReservationList()
        {
            var reservations = _hotel.GetAllReservations();
            foreach (var item in reservations)
            {
                _reservations.Add(new ReservationViewModel(item));
            }
        }
    }
}
