using CarManagementSystem1.Configuration.Entities;
using CarManagementSystem1.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarManagementSystem1.Data
{
    public class CarManagementSystem1Context(DbContextOptions<CarManagementSystem1Context> options) : IdentityDbContext<CarManagementSystem1User>(options)
    {
        public DbSet<CarManagementSystem1.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarManagementSystem1.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarManagementSystem1.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarManagementSystem1.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarManagementSystem1.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarManagementSystem1.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
