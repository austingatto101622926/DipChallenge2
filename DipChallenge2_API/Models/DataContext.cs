namespace DipChallenge2_API.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=AzureDB")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.Payment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Client>()
                .Property(e => e.GivenName)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Fee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.TourName)
                .IsFixedLength();

            modelBuilder.Entity<Tour>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
