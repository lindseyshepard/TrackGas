using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MilesPerGallon.Models
{
    public class MilesPerGallonContext : DbContext
    {
        public MilesPerGallonContext (DbContextOptions<MilesPerGallonContext> options)
            : base(options)
        {
        }

        public DbSet<MilesPerGallon.Models.Car> Car { get; set; }
    }
}
