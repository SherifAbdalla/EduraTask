using EduraTask.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduraTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ISender sender;

        public CustomersController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var customerDemographicsReport = await sender.Send(new CustomerDemographicsReportCommand());
            return new JsonResult(customerDemographicsReport);
        }
    }
}
