using System;
using System.Collections.Generic;
using System.Text;
using Lwandile.Data.Entity;
using Lwandile.Data.Models;

namespace Lwandile.Domain
{
    public interface ILwandieDomain
    {
        List<Artist> GetArtists(string Artists, String Music);
    }
}
