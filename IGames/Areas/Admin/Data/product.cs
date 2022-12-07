using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RModel.Models;

namespace DataAccess.Data.ApplicationDbContext
{
    public class product : DbContext
    {
        public product (DbContextOptions<product> options)
            : base(options)
        {
        }

        public DbSet<RModel.Models.Product> Product { get; set; } = default!;
    }
}
