using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserVoom.Stores
{
    public class HotelStore
    {
        public readonly Hotel hotel;

        public HotelStore(Hotel hotel)
        {
            this.hotel = hotel;
        }
    }
}
