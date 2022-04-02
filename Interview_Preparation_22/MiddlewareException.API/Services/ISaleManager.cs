using DomainService;
using System.Threading.Tasks;

namespace MiddlewareException.API.Services
{
    public interface ISaleManager
    {
        Task<Sale> Add(Sale model);
    }
}
