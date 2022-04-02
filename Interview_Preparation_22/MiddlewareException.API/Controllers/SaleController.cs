using DomainService;
using MailSender;
using Microsoft.AspNetCore.Mvc;
using MiddlewareException.API.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MiddlewareException.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private ISaleService _saleService;
        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpPost]
        public async Task<APIResponse> IndexAsync(Sale model)
        {
            // throw exception and pass middleware 
            var result = await _saleService.Add(model);
            return new APIResponse { Data = result, MessageType = Enum.GetName(typeof(MessageType), MessageType.Success), Message = "Save Success", StatusCode = (int)HttpStatusCode.OK };
        }

        [HttpGet]
        [Route("GetSales")]
        public async Task<APIResponse> GetSales()
        {
            // throw exception and pass middleware 
            var result = new Sale
            {
                CustomerName = "anower ullah",
                OrderDate = DateTime.Now,
                OrderNumber = Guid.NewGuid().ToString(),
                CustomerPhone = "01822339363",
                Id = Guid.NewGuid().ToString(),
                CustomerEmail = "anowereng@gmail.com",
            };
            return new APIResponse {
                Data = result,
                MessageType = Enum.GetName(typeof(MessageType),
                MessageType.Success), 
                Message = "Save Success", 
                StatusCode = (int)HttpStatusCode.OK };
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rng = new Random();
            return Ok(rng.Next(1, 100).ToString());
        }
    }
}
