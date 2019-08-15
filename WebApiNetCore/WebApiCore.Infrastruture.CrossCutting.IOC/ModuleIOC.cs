using Autofac;
using WebApiCore.Infrastruture.CrossCutting.IOC;

namespace WebApiNetCore.Domain.Models
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC.Load(builder);
            
            #endregion
        }
    }
}
