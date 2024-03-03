using StreamingManagement.DAL.DBO;
using Microsoft.EntityFrameworkCore;

namespace StreamingManagement.DAL
{
    public class StreamingDbContext : DbContext
    {
        public StreamingDbContext(DbContextOptions<StreamingDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Distribution> Distribution { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Show> Show { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Actor
            modelBuilder.Entity<Actor>()
                .HasKey(x => x.id_actor);

            modelBuilder.Entity<Actor>()
                .Property(x => x.id_actor);

            modelBuilder.Entity<Actor>()
                .Property(x => x.actor_name)
                .HasMaxLength(50);

            modelBuilder.Entity<Actor>()
                .Property(x => x.actor_surname)
                .HasMaxLength(50);

            modelBuilder.Entity<Actor>()
                .Property(x => x.age);

            modelBuilder.Entity<Actor>()
                .Property(x => x.salary);

            modelBuilder.Entity<Actor>()
                .Property(x => x.gender);

            //Distribution
            modelBuilder.Entity<Distribution>()
                .HasKey(x => x.id_distribution);
                
            modelBuilder.Entity<Distribution>()
                .HasOne(x => x.actor)
                .WithMany(x => x.distributions)
                .HasForeignKey(x => x.id_actor);

            modelBuilder.Entity<Distribution>()
                .HasOne(x => x.movie)
                .WithMany(x => x.distributions)
                .HasForeignKey(x => x.id_movie);

            modelBuilder.Entity<Distribution>()
                .Property(x => x.id_movie);

            modelBuilder.Entity<Distribution>()
                .Property(x => x.id_actor);

            //Movie
            modelBuilder.Entity<Movie>()
               .HasKey(x => x.id_movie);

            modelBuilder.Entity<Movie>()
                .Property(x => x.id_movie);

            modelBuilder.Entity<Movie>()
                .Property(x => x.id_provider);

            modelBuilder.Entity<Movie>()
                .Property(x => x.movie_name)
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                .Property(x => x.director_name)
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                .Property(x => x.category);

            modelBuilder.Entity<Movie>()
                .HasOne(x => x.provider)
                .WithMany(x => x.movies)
                .HasForeignKey(x => x.id_provider);

            //Provider
            modelBuilder.Entity<Provider>()
               .HasKey(x => x.id_provider);

            modelBuilder.Entity<Provider>()
                .Property(x => x.id_provider);

            modelBuilder.Entity<Provider>()
                .Property(x => x.provider_name)
                .HasMaxLength(50);

            modelBuilder.Entity<Provider>()
                .Property(x => x.movie_number);

            modelBuilder.Entity<Provider>()
                .Property(x => x.show_number);

            modelBuilder.Entity<Provider>()
                .Property(x => x.cost);

            //Show
            modelBuilder.Entity<Show>()
               .HasKey(x => x.id_show);

            modelBuilder.Entity<Show>()
                .Property(x => x.id_show);

            modelBuilder.Entity<Show>()
                .Property(x => x.id_provider);

            modelBuilder.Entity<Show>()
                .Property(x => x.show_name)
                .HasMaxLength(50);

            modelBuilder.Entity<Show>()
                .Property(x => x.season_number);

            modelBuilder.Entity<Show>()
                .Property(x => x.episode_number);

            modelBuilder.Entity<Show>()
                .HasOne(x => x.provider)
                .WithMany(x => x.shows)
                .HasForeignKey(x => x.id_provider);

        }
    }
}
