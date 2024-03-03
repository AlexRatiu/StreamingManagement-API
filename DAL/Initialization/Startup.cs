using StreamingManagement.DAL.Repositories;
using StreamingManagement.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL.Initialization
{
    public static class DALStartup
    {
        public static void Init(IConfiguration configuration, IServiceCollection services)
        {
            var connectionString = configuration.GetConnectionString("Develop");
            services.AddDbContextPool<StreamingDbContext>(option => option.UseSqlServer(connectionString));


            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IDistributionRepository, DistributionRepository>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IProviderRepository, ProviderRepository>();
            services.AddTransient<IShowRepository, ShowRepository>();
        }
    }
}
