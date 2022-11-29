using RModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataInterface
{
    public interface ICoverTypeRepository: IRepository<CoverType>
    {
        public void Update(CoverType Cover);
        public void Save();
    }
}
