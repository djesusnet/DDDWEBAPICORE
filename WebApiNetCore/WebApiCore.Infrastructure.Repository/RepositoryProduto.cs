using WebApiCore.Infrastructure.Data;
using WebApiNetCore.Domain;
using WebApiNetCore.Domain.Core.Interfaces.Repositorys;

namespace WebApiCore.Infrastructure.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {

        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
