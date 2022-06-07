using Exceptions;
using Models;
using ReserVoom.Stores;
using ReserVoom.ViewModels;
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
        //private readonly Hotel _hotel;
        private readonly HotelStore _hotelStore;
        private readonly NavigationStore<ViewModelBase> _navigationStore;

        public App()
        {
            _hotelStore = new HotelStore(new("ReserVoom"));
            _navigationStore = new();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ReservationListViewModel(_hotelStore.hotel, _navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
