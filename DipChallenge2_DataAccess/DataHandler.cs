using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess
{
    public class DataHandler
    {
        public Handler<Event> Event;
        public Handler<Client> Client;
        public Handler<Tour> Tour;
        public Handler<Booking> Booking; 

        public DataHandler(string baseAddress)
        {
            Event = new Handler<Event>(baseAddress, "events");
            Client = new Handler<Client>(baseAddress, "clients");
            Tour = new Handler<Tour>(baseAddress, "tours");
            Booking = new Handler<Booking>(baseAddress, "bookings");
        }
    }
}
   