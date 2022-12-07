using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RModel.Models;

namespace IGames.DataAccess.Data.ApplicationDbContext
{
    public class cs : DbContext
    {
        public cs (DbContextOptions<cs> options)
            : base(options)
        {
        }

        public DbSet<RModel.Models.Product> Product { get; set; } = default!;
    }
}
