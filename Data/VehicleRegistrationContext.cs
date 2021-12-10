using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleRegistration.Models;

namespace VehicleRegistration.Data
{
    public class VehicleRegistrationContext : DbContext
    {
        public VehicleRegistrationContext (DbContextOptions<VehicleRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleTypes> VehicleTypes { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
