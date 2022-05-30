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

        public MakeReservationViewModel()
        {
            UserName = string.Empty;
            RoomNumber = 0;
            FloorNumber = 0;
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
            //SubmitCommand = ;
            //CancelCommand = ;
        }
    }
}
