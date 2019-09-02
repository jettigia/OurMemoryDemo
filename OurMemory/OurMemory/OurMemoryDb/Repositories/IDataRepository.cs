using OurMemoryData.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemoryDb.Repositories
{
    public interface IDataRepository<DataType>
        where DataType : class, IOurMemoryBase
    {
        Task Create(DataType entity);

        Task Delete(int id);

        IQueryable<DataType> GetAll();

        Task<DataType> GetById(int id);

        Task<DataType> Read(params int[] key);

        Task Update(int id, DataType entity);
    }
}
