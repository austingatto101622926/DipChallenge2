using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_WPF
{
    public class Control
    {
        public Control(Home home)
        {
            Home = home;
            Events = new Events(this);
        }

        public Home Home { get; set; }
        public Events Events { get; set; }
    }
}
