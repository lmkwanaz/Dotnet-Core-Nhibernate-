using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lwandile.Data;
using Lwandile.Domain;
using Lwandile.Repository;
using Ninject.Core;
using Ninject.Core.Behavior;

namespace LwandileAPIs.Ioc
{
    public class LwandieModule : StandardModule
    {
        //private readonly ILog _logger;
        public LwandieModule()
        {
            //try
            //{

            //    log4net.Config.XmlConfigurator.Configure();
            //    _logger = LogManager.GetLogger("EllensonQuaverWebAPI");
            //    _logger.Debug("EllensonQuaverWebAPI starting...");
            //}
            //catch (Exception ex)
            //{
            //    EventLog.WriteEntry("EllensonQuaverWebAPI", string.Format("Failed to initialize module. {0}", ex.ToString()), EventLogEntryType.Error);
            //}
        }
        public override void Load()
        {
            //Bind<NSessionService>().To<UniversitySession>().Using<SingletonBehavior>();
            Bind<LwandileSession>().ToSelf().Using<SingletonBehavior>();
            Bind<ILwandieRepository>().To<LwandieRepository>();
            Bind<ILwandieDomain>().To<LwandieDomain>();
            //Bind<ILog>().ToConstant(_logger); new NotImplementedException();
        }
    }
}
