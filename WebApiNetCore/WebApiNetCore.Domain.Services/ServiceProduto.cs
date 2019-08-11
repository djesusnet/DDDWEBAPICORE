using WebApiNetCore.Domain.Core.Interfaces.Repositorys;
using WebApiNetCore.Domain.Core.Interfaces.Services;

namespace WebApiNetCore.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto RepositoryProduto)
            : base(RepositoryProduto)
        {
            _repositoryProduto = RepositoryProduto;
        }

        //public IEnumerable<Produto> BuscarPorNome(string nome)
        //{
        //    return _repositoryProduto.BuscarPorNome(nome);
        //}
    }
}
