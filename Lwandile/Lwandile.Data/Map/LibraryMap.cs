using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Lwandile.Data.Entity;

namespace Lwandile.Data.Map
{
    class LibraryMap : ClassMap<Library>
    {
        public LibraryMap()
        {
            CompositeId()
              .KeyProperty(x => x.ArtistID)
              .KeyProperty(x => x.TitleID);
        }
    
    }
}
