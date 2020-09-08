using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lwandile.Data.Entity;

namespace LwandileAPIs.Data
{
    public class MusicLibrary : DbContext
    {
        public MusicLibrary (DbContextOptions<MusicLibrary> options)
            : base(options)
        {
        }

        public DbSet<Lwandile.Data.Entity.Title> Title { get; set; }

        public DbSet<Lwandile.Data.Entity.Artist> Artist { get; set; }
    }
}
