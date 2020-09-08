using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Lwandile.Data.Entity;

namespace Lwandile.Data.Map
{
    class ArtistMap : ClassMap<Artist>
    {
        public ArtistMap()
        {
            Id(p => p.ArtistID);
            Map(p => p.OriginalName);
            Map(p => p.Age);
        }
    
    }
}
