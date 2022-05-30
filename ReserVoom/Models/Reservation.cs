using System;

namespace Models
{
    public class Reservation
    {
        /// <summary>
        /// UserName of the User the reservation is made
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// Room ID reserved 
        /// </summary>
        public RoomID RoomID { get; }
        /// <summary>
        /// Start Date of the reservation
        /// </summary>
        public DateTime StartDate { get; }
        /// <summary>
        /// End Date of the reservation
        /// </summary>
        public DateTime EndDate { get; }
        /// <summary>
        /// Total time reserved
        /// </summary>
        public TimeSpan Length => EndDate - StartDate;

        /// <summary>
        /// Create Reservation Object
        /// </summary>
        /// <param name="userName">UserName of the User</param>
        /// <param name="roomID">Room Id to Reserve</param>
        /// <param name="startDate">Start Date of the reservation</param>
        /// <param name="endTime">End Date of the reservation</param>
        public Reservation(string userName, RoomID roomID, DateTime startDate, DateTime endTime)
        {
            UserName = userName;
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endTime;
        }
        /// <summary>
        /// Does current reservation is conflicting with the passed in reservations
        /// </summary>
        /// <param name="reservation">Reservation to check against</param>
        /// <returns>if Conflict is Present returns True, else returns false</returns>
        internal bool Conflicts(Reservation reservation)
        {
            if (RoomID != reservation.RoomID) return false;

            if (StartDate <= reservation.StartDate && EndDate >= reservation.StartDate)
            {
                return true;
            }
            else if (StartDate <= reservation.EndDate && EndDate >= reservation.EndDate)
            {
                return true;
            }

            return false;
        }
    }
}