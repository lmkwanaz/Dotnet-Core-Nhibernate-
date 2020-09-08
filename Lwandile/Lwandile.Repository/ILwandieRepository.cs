using System;
using System.Collections.Generic;
using System.Text;
using Lwandile.Data.Entity;
using Lwandile.Data.Models;

namespace Lwandile.Repository
{
    public interface ILwandieRepository
    {
        List<Artist> GetArtists(string Artist, string connectionString);
    }
}
