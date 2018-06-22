using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
