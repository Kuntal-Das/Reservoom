using Exceptions;
using Models;
using ReserVoom.Services;
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
        private NavigationService<ViewModelBase> _navigateToReservationListService;
        private NavigationService<ViewModelBase> _navigateToMakeReservationService;

        public App()
        {
            _hotelStore = new HotelStore(new("ReserVoom"));
            _navigationStore = new();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigateToReservationListService = new NavigationService<ViewModelBase>(_navigationStore, createReservationListViewModel);
            _navigateToMakeReservationService = new NavigationService<ViewModelBase>(_navigationStore, createMakeReservationViewModel);

            _navigationStore.CurrentViewModel = new ReservationListViewModel(_hotelStore.hotel, _navigateToMakeReservationService);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private ViewModelBase createReservationListViewModel()
        {
            return new ReservationListViewModel(_hotelStore.hotel, _navigateToMakeReservationService);
        }

        private ViewModelBase createMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotelStore.hotel, _navigateToReservationListService);
        }
    }
}
