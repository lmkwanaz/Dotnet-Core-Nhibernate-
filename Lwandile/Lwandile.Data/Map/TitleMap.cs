using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Lwandile.Data.Entity;

namespace Lwandile.Data.Map
{
    class TitleMap : ClassMap<Title>
    {
        public TitleMap()
        {
            Id(p => p.TitleID);
            Map(p => p.NameOfSong);
            Map(p => p.Features);
            Map(p => p.ReleaseDate);
        }
    }
}
