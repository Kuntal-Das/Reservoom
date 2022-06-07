using System.Collections.Generic;

namespace Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }
        /// <summary>
        /// Create Hotel Object
        /// </summary>
        /// <param name="name">Name of the Hotel</param>
        public Hotel(string name)
        {
            _reservationBook = new();
            Name = name;
        }


        /// <summary>
        /// Gets all reservations
        /// </summary>
        /// <returns>All the Reservations for the hotel</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
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