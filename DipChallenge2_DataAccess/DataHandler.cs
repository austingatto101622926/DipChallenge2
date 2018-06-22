using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess
{
    public class DataHandler
    {
        public EventHandler Event;

        public DataHandler(string baseAddress)
        {
            Event = new EventHandler(baseAddress);
        }
    }
}
