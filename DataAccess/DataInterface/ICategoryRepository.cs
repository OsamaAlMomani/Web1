using IGames.DataInterface;

namespace DataAccess.DataInterface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public void Update(Category category);
        public void Save();
    }
}
