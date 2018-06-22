using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess
{
    public class Client
    {
        public int ClientID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
