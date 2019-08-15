using WebApiCore.Infrastructure.Data;
using WebApiNetCore.Domain;
using WebApiNetCore.Domain.Core.Interfaces.Repositorys;

namespace WebApiCore.Infrastructure.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente> , IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context) 
            : base(Context)
        {
            _context = Context;
        }
    }
}
