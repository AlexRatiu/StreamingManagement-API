using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace StreamingManagement.DAL.Repositories
{
    public class DistributionRepository : IDistributionRepository
    {
        private readonly StreamingDbContext _dbContext;

        public DistributionRepository(StreamingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Distribution distribution)
        {
            await _dbContext.Distribution.AddAsync(distribution);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Distribution> GetById(int id_distribution)
        {
            return await _dbContext.Distribution.FindAsync(id_distribution);

        }

        public async Task<List<Distribution>> GetAll()
        {
            var results = _dbContext.Distribution.ToList();
            return results;
        }

        public async Task Update(Distribution distribution)
        {
            _dbContext.Distribution.Entry(distribution).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id_distribution)
        {
            var result = await this.GetById(id_distribution);

            if (result != null)
            {
                _dbContext.Distribution.Remove(result);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
