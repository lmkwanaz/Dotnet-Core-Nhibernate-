using System;
using System.Collections.Generic;
using Lwandile.Data.Entity;
using Lwandile.Data.Models;
using Lwandile.Repository;

namespace Lwandile.Domain
{
    public class LwandieDomain : ILwandieDomain
    {
        ILwandieRepository _repository;
        private readonly ConnectionString _connectionString;

        //public LwandieDomain(ILwandieRepository repository)
        //{
        //    _repository = repository;
        //}

        public LwandieDomain(ILwandieRepository repository, ConnectionString connectionString)
        {
            _repository = repository;
            _connectionString = connectionString;
        }

        public List<Artist> GetArtists(string Artists, string Music)
        {
            return _repository.GetArtists(Artists, Music);
        }
    }
}
