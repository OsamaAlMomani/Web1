using Microsoft.EntityFrameworkCore.Diagnostics;
using IGames.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataInterface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public void Update(Category category);
        public void Save();
    }
}
