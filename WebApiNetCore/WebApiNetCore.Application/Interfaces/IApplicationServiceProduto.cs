using System.Collections.Generic;
using WebApiNetCore.Application.DTO.DTO;

namespace WebApiNetCore.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);

        void Dispose();

    }
}
