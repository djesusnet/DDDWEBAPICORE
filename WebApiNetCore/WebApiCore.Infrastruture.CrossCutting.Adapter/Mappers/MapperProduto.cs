using System.Collections.Generic;
using WebApiNetCore.Application.DTO.DTO;
using WebApiNetCore.Domain;

namespace WebApiCore.Infrastruture.CrossCutting.Adapter.Mappers
{
    public interface IMapperProduto
    {
        #region Interfaces Mappers
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);

        #endregion

    }
}
