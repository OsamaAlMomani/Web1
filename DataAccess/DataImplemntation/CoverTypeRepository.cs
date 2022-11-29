using DataAccess.DataInterface;
using IGames.Data;
using RModel.Models;

namespace DataAccess.DataImplemntation
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;

        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CoverType Cover)
        {
            _db.covertpye.Update(Cover);
        }
    }
}
