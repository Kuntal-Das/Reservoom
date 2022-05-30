using Models;
using System;

namespace ReserVoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string UserName => _reservation.UserName;
        public string RoomID => _reservation.RoomID?.ToString();
        public String StartDate => _reservation.StartTime.ToString("d");
        public String EndDate => _reservation.EndTime.ToString("d");
        public TimeSpan Length => _reservation.Length;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}