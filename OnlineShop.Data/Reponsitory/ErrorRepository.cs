using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Reponsitory
{
    public interface IErrorrRepository : IRepository<Error>
    {
    }

    public class ErrorrRepository : RepositoryBase<Error>, IErrorrRepository
    {
        public ErrorrRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}