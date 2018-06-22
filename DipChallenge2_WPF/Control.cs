using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipChallenge2_DataAccess;

namespace DipChallenge2_WPF
{
    public class Control
    {
        public DataHandler DH;

        public Control(Home home)
        {
            DH = new DataHandler("https://dipchallenge2.azurewebsites.net/");

            Home = home;
            Events = new Events(this);
            Bookings = new Bookings(this);
            Clients = new Clients(this);
        }

        public Home Home { get; set; }
        public Events Events { get; set; }
        public Bookings Bookings { get; set; }
        public Clients Clients { get; set; }
    }
}
