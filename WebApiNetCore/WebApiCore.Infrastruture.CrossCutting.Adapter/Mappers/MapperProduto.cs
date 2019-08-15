using System.Collections.Generic;
using WebApiCore.Infrastruture.CrossCutting.Adapter.Interfaces;
using WebApiNetCore.Application.DTO.DTO;
using WebApiNetCore.Domain;

namespace WebApiCore.Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperProduto : IMapperProduto
    {


        #region Properties

        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        #endregion

        #region methods

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {

                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor

            };

            return produto;

        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {

                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id
                    ,Nome = item.Nome
                    ,Valor = item.Valor

                };

                produtoDTOs.Add(produtoDTO);
            }


            return produtoDTOs;

        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id
                ,Nome = produto.Nome
                ,Valor = produto.Valor
            };

            return produtoDTO;

        }

        #endregion
    }
}
