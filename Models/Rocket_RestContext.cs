using Microsoft.EntityFrameworkCore;

namespace Rocket_Rest.Models
{
    public class Rocket_RestContext : DbContext
    {
        public Rocket_RestContext(DbContextOptions<Rocket_RestContext> options)
            : base(options)
        {
        }

        public DbSet<Battery> batteries { get; set; }
        public DbSet<Column> columns { get; set; }
        public DbSet<Elevator> elevators { get; set; }
        public DbSet<Building> buildings { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Lead> leads { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Intervention> interventions { get; set; }
    }
}