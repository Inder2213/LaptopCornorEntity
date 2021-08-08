using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaptopCornor.Models;

namespace LaptopCornor.Data
{
    public class LaptopCornorContext : DbContext
    {
        public LaptopCornorContext (DbContextOptions<LaptopCornorContext> options)
            : base(options)
        {
        }

        public DbSet<LaptopCornor.Models.Asus> Asus { get; set; }

        public DbSet<LaptopCornor.Models.HP> HP { get; set; }

        public DbSet<LaptopCornor.Models.Acessory> Acessory { get; set; }

        public DbSet<LaptopCornor.Models.Customer> Customer { get; set; }
    }
}
