using DataAccess.DataInterface;
using IGames.Data;
using IGames.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataImplemntation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) :base(db)
        {
            _db= db;

        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.categories.Update(category); 
        }
    }
}
