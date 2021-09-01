using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Challenge_Backend_CSharp_.Net.Entities;

namespace Challenge_Backend_CSharp_.Net.Context
{
    public class CharactersContext : DbContext
    {
        public CharactersContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Movie> CMovies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
    }
}
