using DomainService;
using System.Threading.Tasks;

namespace MiddlewareException.API.Services
{
    public interface ISaleService 
    {
        Task<Sale> Add(Sale model);
    }
}
