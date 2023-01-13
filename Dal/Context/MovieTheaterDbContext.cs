using Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Context
{
    public class MovieTheaterDbContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<MovieAndCategory> MoviesAndCategories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost; database = MovieTheaterDb;Trusted_Connection = true; TrustServerCertificate = true");
                base.OnConfiguring(optionsBuilder);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieAndCategory>().HasKey(x => new { x.MovieId, x.CategoryId });


            base.OnModelCreating(modelBuilder);
        }

    }
}
