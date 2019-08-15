using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using WebApiCore.Infrastructure.Repository;
using WebApiCore.Infrastruture.CrossCutting.Adapter;
using WebApiCore.Infrastruture.CrossCutting.Adapter.Interfaces;
using WebApiCore.Infrastruture.CrossCutting.Adapter.Mappers;
using WebApiNetCore.Application;
using WebApiNetCore.Application.Interfaces;
using WebApiNetCore.Application.Services;
using WebApiNetCore.Domain.Core.Interfaces.Repositorys;
using WebApiNetCore.Domain.Core.Interfaces.Services;
using WebApiNetCore.Domain.Services;

namespace WebApiCore.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<IServiceProduto>().As<IServiceProduto>();
            #endregion

            #region IOC Repositorys Patterns
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion

        }
    }
}
