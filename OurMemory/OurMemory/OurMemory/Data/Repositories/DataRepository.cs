using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OurMemory.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OurMemory.Data.Repositories
{
    public class DataRepository<DataType> : IDataRepository<DataType>
        where DataType : class, IOurMemoryBase
    {
        private readonly ILogger<DataRepository<DataType>> _logger;
        private readonly OurMemoryContext _context;

        public DataRepository(ILogger<DataRepository<DataType>> logger, OurMemoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Create an object.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Newly created DataType or null if unsuccessful</returns>
        public async Task<DataType> Create(DataType data)
        {
            try
            {
                var newEntity = await _context.Set<DataType>().AddAsync(data);
                await _context.SaveChangesAsync();
                return newEntity.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return null;
        }

        public async Task<DataType> Read(params int[] key)
        {
            try
            {
                return await _context.FindAsync<DataType>(key);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return null;
        }

        public async Task<DataType> Update(int id, DataType data)
        {
            try
            {
                await _context.Set<DataType>().AddAsync(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return null;
        }

        public async Task Delete(int id)
        {
            try
            {
                var entity = await GetById(id);
                _context.Set<DataType>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
        }

        public IQueryable<DataType> GetAll()
        {
            return _context.Set<DataType>().AsNoTracking();
        }


        public async Task<DataType> GetById(int id)
        {
            return await _context.Set<DataType>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }

        Task IDataRepository<DataType>.Create(DataType entity)
        {
            throw new NotImplementedException();
        }

        Task IDataRepository<DataType>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task IDataRepository<DataType>.Update(int id, DataType entity)
        {
            throw new NotImplementedException();
        }
    }
}
