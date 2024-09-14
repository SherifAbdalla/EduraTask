using EduraTask.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduraTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenuesController : ControllerBase
    {
        private readonly ISender sender;

        public RevenuesController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpGet("RevenuesByPaymentMethodReport")]
        public async Task<IActionResult> GetByPaymentMethodReport([FromQuery] RevenueByPaymentMethodReportCommand command)
        {
            var revenuesByPaymentMethodReport = await sender.Send(command);
            return new JsonResult(revenuesByPaymentMethodReport);
        }

        [HttpGet("RevenuesByBranchReport")]
        public async Task<IActionResult> GetByBranchReport([FromQuery] RevenueByBranchReportCommand command)
        {
            var revenueByBranchReport = await sender.Send(command);
            return new JsonResult(revenueByBranchReport);
        }

        [HttpGet("RevenuesByServiceReport")]
        public async Task<IActionResult> GetByServiceReport([FromQuery] RevenueByServiceReportCommand command)
        {
            var revenuesByServiceReport = await sender.Send(command);
            return new JsonResult(revenuesByServiceReport);
        }
    }
}
