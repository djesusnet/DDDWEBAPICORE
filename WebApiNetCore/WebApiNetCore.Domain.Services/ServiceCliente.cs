using WebApiNetCore.Domain.Core.Interfaces.Repositorys;
using WebApiNetCore.Domain.Core.Interfaces.Services;

namespace WebApiNetCore.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }

    }
}
