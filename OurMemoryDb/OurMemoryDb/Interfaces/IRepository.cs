using System;
using System.Threading.Tasks;

namespace OurMemoryDb
{
    public interface IRepository<EntityType>
    {
        Task<EntityType> CreateEntityAsync(EntityType entity);
        Task<EntityType> ReadEntityAsync(Guid userId);
        Task<EntityType> UpdateEntityAsync(EntityType entity);
        Task<bool> DeleteEntityAsync(EntityType entity);
    }
}
