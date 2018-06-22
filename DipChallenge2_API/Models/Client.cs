namespace DipChallenge2_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Bookings = new HashSet<Booking>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientID { get; set; }

        [StringLength(50)]
        public string GivenName { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
