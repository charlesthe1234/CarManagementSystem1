using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarManagementSystem1.Domain;
using CarManagementSystem1.Configuration.Entities;

namespace CarManagementSystem1.Data
{
    public class CarManagementSystem1Context : DbContext
    {
        public CarManagementSystem1Context (DbContextOptions<CarManagementSystem1Context> options)
            : base(options)
        {
        }

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
        }
    }
}
