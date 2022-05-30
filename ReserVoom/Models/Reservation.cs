using System;

namespace Models
{
    public class Reservation
    {
        public string UserName { get; }
        public RoomID RoomID { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime - StartTime;

        public Reservation(string userName, RoomID roomID, DateTime startDate, DateTime endTime)
        {
            UserName = userName;
            RoomID = roomID;
            StartTime = startDate;
            EndTime = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (RoomID != reservation.RoomID) return false;

            if (StartTime <= reservation.StartTime && EndTime >= reservation.StartTime)
            {
                return true;
            }
            else if (StartTime <= reservation.EndTime && EndTime >= reservation.EndTime)
            {
                return true;
            }

            return false;
        }
    }
}