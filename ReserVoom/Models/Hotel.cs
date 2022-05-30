using System.Collections.Generic;

namespace Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            _reservationBook = new();
            Name = name;
        }

        /// <summary>
        /// Get the reservation for a User
        /// </summary>
        /// <param name="userName"> The UserName of the User. </param>
        /// <returns> The Reservation for the user. </returns> 
        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservationBook.GetReservationsForUser(userName);
        }

        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation"> The Incomming Reservation. </param>
        /// <exception cref="ReservationConflictException"></exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}