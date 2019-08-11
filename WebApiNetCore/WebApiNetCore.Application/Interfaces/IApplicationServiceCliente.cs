using System.Collections.Generic;
using WebApiNetCore.Application.DTO;

namespace WebApiNetCore.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        void Dispose();

    }
}
