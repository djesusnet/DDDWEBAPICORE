using System;
using System.Collections.Generic;
using WebApiCore.Infrastruture.CrossCutting.Adapter;
using WebApiCore.Infrastruture.CrossCutting.Adapter.Interfaces;
using WebApiNetCore.Application.DTO;
using WebApiNetCore.Application.Interfaces;
using WebApiNetCore.Domain.Core.Interfaces.Services;

namespace WebApiNetCore.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;
       



        public ApplicationServiceCliente(IServiceCliente ServiceCliente
                                         , MapperCliente MapperCliente)
        {
            _serviceCliente = ServiceCliente;
            _mapperCliente = MapperCliente;
         
        }


        public void Add(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Add(objCliente);
        }

        public void Dispose()
        {
            _serviceCliente.Dispose();
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objClientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientes(objClientes);

        }

        public ClienteDTO GetById(int id)
        {
            var objcliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperToDTO(objcliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Update(objCliente);
        }
    }
}
