using System.Collections.Generic;
using System.Linq;
using Exceptions;

namespace Models
{
    public class ReservationBook
    {
        private List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservations.Where(r => r.UserName == userName);
        }

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