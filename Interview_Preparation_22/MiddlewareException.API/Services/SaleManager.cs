using DomainService;
using MailSender;
using System;
using System.Threading.Tasks;

namespace MiddlewareException.API.Services
{
    public class SaleManager : ISaleManager
    {
     
        public async Task<Sale> Add(Sale model)
        {
            //// some add functionality in backend

            return model;
        }
    }
}
