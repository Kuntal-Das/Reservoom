using System;
using Models;

namespace Exceptions
{
    [System.Serializable]
    public class ReservationConflictException : Exception
    {
        public Reservation? PresentReservation {get;} 
        public Reservation? IncommingReservation {get;}
        public ReservationConflictException(Reservation presentReservation, Reservation incommingReservation)
        {
            PresentReservation = presentReservation;
            IncommingReservation = incommingReservation;
        }
        public ReservationConflictException(string message, Reservation presentReservation, Reservation incommingReservation) : base(message)
        {
            PresentReservation = presentReservation;
            IncommingReservation = incommingReservation;
        }
        public ReservationConflictException(string message, System.Exception inner, Reservation presentReservation, Reservation incommingReservation) : base(message, inner)
        {
            PresentReservation = presentReservation;
            IncommingReservation = incommingReservation;
        }
        protected ReservationConflictException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}