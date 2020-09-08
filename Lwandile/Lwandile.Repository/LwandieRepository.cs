using System;
using System.Collections.Generic;
using System.Linq;
using Lwandile.Data;
using Lwandile.Data.Entity;
using Lwandile.Data.Models;


namespace Lwandile.Repository
{
    public class LwandieRepository : ILwandieRepository
    {
        private readonly LwandileSession _nhibernateSession;
        private ConnectionString _connectionString;
        //private IOptions<ConnectionString> _connect;
        // private static ILog _logger;

        //public LwandieRepository(LwandileSession nhibernateSession)
        //{
        //    //_logger = logger;
        //    _nhibernateSession = nhibernateSession;
        //}

        public LwandieRepository(LwandileSession nhibernateSession, ConnectionString connectionString)
        {
            //_logger = logger;
            _nhibernateSession = nhibernateSession;
            _connectionString = connectionString;
        }

        public List<Artist> GetArtists(string originalName, string connectionString)
        {
            //if (this._connectionString.MusicLibrary == null)
            //    this._connectionString = connectionString;

            _connectionString.MusicLibrary = connectionString;

            using (var session = _nhibernateSession.CreateSession(_connectionString.MusicLibrary))
            {
                try
                {
                    var query = session.QueryOver<Artist>();

                    if (originalName != null)
                        query.Where(p => p.OriginalName == originalName);

                    return query.List<Artist>()
                        .ToList();

                }
                catch (Exception ex)
                {
                    // _logger.Error("Error on GetUsers", ex);
                    throw ex;
                }
            }
        }
    }
}
