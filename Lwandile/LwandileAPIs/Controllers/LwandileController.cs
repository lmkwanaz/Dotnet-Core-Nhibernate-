using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICM.JHB.Utility.Ninject;
using Lwandile.Data.Entity;
using Lwandile.Data.Models;
using Lwandile.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace LwandileAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LwandileController : ControllerBase
    {
        protected ILwandieDomain _domain = Ninject_IOC.Container.Get<ILwandieDomain>();
        private readonly IOptions<ConnectionString> appSettings;
        private readonly IConfiguration _conf;
       

        public LwandileController(IOptions<ConnectionString> app, IConfiguration conf)
        {
            appSettings = app;
            _conf = conf;
        }


        [HttpGet]
        public List<Artist> GetArtists(string artist)
        {
            try
            {
                //string Music = "hey";
                string Music = appSettings.Value.MusicLibrary;
                // _logger.Debug("Executing GetCurrencyUniqueCode");

                var passit = _conf.GetConnectionString("ConnectionString");
            
                var uniqueCode = _domain.GetArtists(artist, Music);

                var count = (artist == null) ? 0 : uniqueCode.Count();

               // _logger.Debug(string.Format("#End GetCurrencyUniqueCode. {0} results: ", count));

                return uniqueCode;
            }
            catch (Exception ex)
            {
               // _logger.Error("Error on GetCurrencyUniqueCode.", ex);
                throw ex;
            }
        }

    }
}
