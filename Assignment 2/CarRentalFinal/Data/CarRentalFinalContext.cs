#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalFinal.Models;

namespace CarRentalFinal.Data
{
    public class CarRentalFinalContext : DbContext
    {
        public CarRentalFinalContext (DbContextOptions<CarRentalFinalContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalFinal.Models.Car> Car { get; set; }

        public DbSet<CarRentalFinal.Models.Client> Client { get; set; }
    }
}
