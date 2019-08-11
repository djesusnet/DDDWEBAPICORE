using System.Collections.Generic;
using WebApiCore.Infrastruture.CrossCutting.Adapter.Interfaces;
using WebApiNetCore.Application.DTO;
using WebApiNetCore.Domain;

namespace WebApiCore.Infrastruture.CrossCutting.Adapter
{
    public class MapperCliente : IMapperCliente
    {

        #region properties

        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        #endregion


        #region methods

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id
                ,
                Nome = clienteDTO.Nome
                ,
                Sobrenome = clienteDTO.Sobrenome
                ,
                Email = clienteDTO.Email
            };

            return cliente;

        }


        public IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes)
        {


            foreach (var item in clientes)
            {


                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Sobrenome = item.Sobrenome
                   ,
                    Email = item.Email
                };



                clienteDTOs.Add(clienteDTO);

            }



            return clienteDTOs;

        }

        public ClienteDTO MapperToDTO(Cliente Cliente)
        {


            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = Cliente.Id
                ,
                Nome = Cliente.Nome
                ,
                Sobrenome = Cliente.Sobrenome
                ,
                Email = Cliente.Email
            };

            return clienteDTO;

        }

        #endregion

    }
}
