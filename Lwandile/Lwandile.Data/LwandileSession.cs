using System;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Lwandile.Data.Entity;

namespace Lwandile.Data
{
    public class LwandileSession : NSessionService.NSessionService
    {
        protected override void SetSession()
        {
            if (_factory == null)
            {
                _factory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008.ConnectionString(ConfigurationManager.ConnectionStrings["MusicLibrary"].ConnectionString))
                    .Mappings(m =>
                    {
                        m.FluentMappings.AddFromAssemblyOf<Library>();
                    })
                    .BuildSessionFactory();
            }
        }

        //Install system.data.sqlclient to be able to pass a connectionString here
        protected override void SetSession(string connectionString)
        {
            try
            {
                if (_factory == null)
                {
                    _factory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2005.ConnectionString(connectionString))
                        .Mappings(m =>
                        {
                            m.FluentMappings.AddFromAssemblyOf<Library>();
                        })
                        .BuildSessionFactory();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
