using DataAccess.DataImplemntation;
using DataAccess.DataInterface;
using IGames.DataInterface;
using Microsoft.EntityFrameworkCore;
using RModel.Models;

namespace IGames.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<CoverType> covertype { get; set; }
        public DbSet<Product> products { get; set; }    

    }
}