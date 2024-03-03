using StreamingManagement.DAL.DBO;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace StreamingManagement.DAL.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly StreamingDbContext _dbContext;

        public ShowRepository(StreamingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Show show)
        {
            await _dbContext.Show.AddAsync(show);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Show> GetById(int id_show)
        {
            return await _dbContext.Show.FindAsync(id_show);
        }

        public async Task<List<Show>> GetAll()
        {
            var results = _dbContext.Show.ToList();
            return results;
        }

        public async Task Update(Show show)
        {
            _dbContext.Show.Entry(show).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id_show)
        {
            var result = await this.GetById(id_show);

            if (result != null)
            {
                _dbContext.Show.Remove(result);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
