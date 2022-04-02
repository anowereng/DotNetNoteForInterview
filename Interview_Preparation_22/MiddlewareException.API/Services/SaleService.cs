using DomainService;
using MailSender;
using System.Threading.Tasks;

namespace MiddlewareException.API.Services
{
    public class SaleService : ISaleService
    {
        private IMailService _mailService;
        private ISaleManager _manager;
        public SaleService(IMailService mailService, ISaleManager manager)
        {
            _mailService = mailService;
            _manager = manager;
        }


        public async Task<Sale> Add(Sale model)
        {
            var sale = await _manager.Add(model);
            await _mailService.SendMailAfterSale(sale);
            return sale;
        }
    }
}
