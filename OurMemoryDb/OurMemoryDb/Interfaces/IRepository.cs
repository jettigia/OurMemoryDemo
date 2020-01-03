using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IRepository<EntityType>
    {
        Task<EntityType> CreateEntity(EntityType entity);
        Task<EntityType> ReadEntity(string id);
        Task<EntityType> UpdateEntity(EntityType entity);
        Task<bool> DeleteEntity(EntityType entity);
    }
}
