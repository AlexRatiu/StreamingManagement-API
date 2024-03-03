using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace StreamingManagement.DAL.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly StreamingDbContext _dbContext;

        public ProviderRepository(StreamingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Provider provider)
        {
            await _dbContext.Provider.AddAsync(provider);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Provider> GetById(int id_provider)
        {
            return await _dbContext.Provider.FindAsync(id_provider);
        }

        public async Task<List<Provider>> GetAll()
        {
            var results = _dbContext.Provider.ToList();
            return results;
        }

        public async Task Update(Provider provider)
        {
            _dbContext.Provider.Entry(provider).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id_provider)
        {
            var result = await this.GetById(id_provider);

            if (result != null)
            {
                _dbContext.Provider.Remove(result);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
