using DataAccess.DataInterface;
using IGames.Data;
using IGames.DataInterface;
using RModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataImplemntation
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) :base(db)
        {
            _db= db;

        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product item)
        {
            var items=_db.products.FirstOrDefault(item);
            if (items != null)
            {
                items.ISBN = item.ISBN;
                items.ID = item.ID; 
                items.Name = item.Name; 
                items.Description = item.Description;
                items.Price = item.Price;
                items.Price50 = item.Price50;
                items.Price100 = item.Price100;
                items.category_R = item.category_R;
                items.Author = item.Author;
                items.Title= item.Title;    
                if (items.ImageUrl!=null)
                {
                    items.ImageUrl= (string)items.ImageUrl;
                }
            }
        }
    }
}
