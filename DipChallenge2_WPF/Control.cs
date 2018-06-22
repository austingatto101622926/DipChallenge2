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
        }

        public Home Home { get; set; }
        public Events Events { get; set; }
    }
}
