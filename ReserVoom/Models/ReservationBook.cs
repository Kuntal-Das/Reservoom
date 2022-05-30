using System.Collections.Generic;
using System.Linq;
using Exceptions;

namespace Models
{
    public class ReservationBook
    {
        private List<Reservation> _reservations;

        /// <summary>
        /// Make a Reservation Books
        /// </summary>
        public ReservationBook()
        {
            _reservations = new();
        }
        /// <summary>
        /// Get All Reservations for the hotel object
        /// </summary>
        /// <returns>All the Reservations in the hotel</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }
        /// <summary>
        /// Make a Reservation in the Hotel
        /// </summary>
        /// <param name="reservation">Reservation to be made</param>
        /// <exception cref="ReservationConflictException">If Conflicts with any other aleady present Reservation</exception>
        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}