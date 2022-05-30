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

        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ReservationListViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Models.Reservation("Kuntal", new Models.RoomID(1, 2), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("Bishal", new Models.RoomID(1, 3), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("Ammbika", new Models.RoomID(3, 5), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("Swagoto", new Models.RoomID(2, 2), DateTime.Now, DateTime.Now)));
        }
    }
}
