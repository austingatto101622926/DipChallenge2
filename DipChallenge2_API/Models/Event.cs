namespace DipChallenge2_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Bookings = new HashSet<Booking>();
        }

        public int EventID { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Fee { get; set; }

        public int TourID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
