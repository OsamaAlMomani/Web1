using RModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataInterface
{
    public interface IProductRepository: IRepository<Product>
    {
        public void Update(Product Item);
        public void Save();
    }
}
