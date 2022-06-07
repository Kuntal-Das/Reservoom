using ReserVoom.Commands;
using ReserVoom.Services;
using ReserVoom.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReserVoom.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private int _roomNumber;

        public int RoomNumber
        {
            get => _roomNumber;
            set
            {
                _roomNumber = value;
                OnPropertyChanged();
            }
        }

        private int _floorNumber;

        public int FloorNumber
        {
            get => _floorNumber;
            set
            {
                _floorNumber = value;
                OnPropertyChanged();
            }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged();
            }

        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        //public MakeReservationViewModel(Models.Hotel hotel, NavigationStore<ViewModelBase> navigationStore)
        public MakeReservationViewModel(Models.Hotel hotel, NavigationStore<ViewModelBase> navigationStore)
        {
            UserName = string.Empty;
            RoomNumber = 0;
            FloorNumber = 0;
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;

            NavigationService<ViewModelBase> ReservationListNavigationService =
                new NavigationService<ViewModelBase>(navigationStore, () => new ReservationListViewModel(hotel, navigationStore));

            SubmitCommand = new SubmitReservationCommand(this, hotel, ReservationListNavigationService);

            CancelCommand = new NavigateCommand(ReservationListNavigationService);
        }
    }
}
