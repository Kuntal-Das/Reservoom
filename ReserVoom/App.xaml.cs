using Exceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReserVoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Golden Eve");

            try
            {
                hotel.MakeReservation(new Reservation(
                    "Kuntal Das",
                    new RoomID(1, 2),
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)
                ));

                hotel.MakeReservation(new Reservation(
                    "Kuntal Das",
                    new RoomID(1, 3),
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)
                ));

                var reservations = hotel.GetReservationsForUser();
            }
            catch (ReservationConflictException ex)
            {

            }

            base.OnStartup(e);
        }
    }
}
