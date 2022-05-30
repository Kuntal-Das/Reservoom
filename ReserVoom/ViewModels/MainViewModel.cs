using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserVoom.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Models.Hotel hotel)
        {
            //CurrentViewModel = new ReservationListViewModel();
            CurrentViewModel = new MakeReservationViewModel(hotel);
        }
    }
}
