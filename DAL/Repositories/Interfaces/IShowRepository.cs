using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Repositories.Interfaces
{
    public interface IShowRepository
    {
        Task Create(Show show);

        Task<Show> GetById(int id_show);

        Task<List<Show>> GetAll();

        Task Update(Show show);

        Task Delete(int id_show);
    }
}
