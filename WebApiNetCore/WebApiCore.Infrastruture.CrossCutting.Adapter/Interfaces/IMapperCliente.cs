using System.Collections.Generic;
using WebApiNetCore.Application.DTO;
using WebApiNetCore.Domain;

namespace WebApiCore.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}
