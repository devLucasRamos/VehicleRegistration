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

        public DbSet<VehicleRegistration.Models.VehicleTypes> VehicleTypes { get; set; }
    }
}
