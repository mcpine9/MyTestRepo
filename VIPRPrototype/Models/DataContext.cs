using System.Data.Entity;

namespace VIPRPrototype.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Chart> Charts { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Provider> Providers { get; set; }

    }
}