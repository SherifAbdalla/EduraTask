using EduraTask.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduraTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly ISender sender;

        public AppointmentsController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpGet("AppointmentsByServiceReport")]
        public async Task<IActionResult> GetByServiceReport([FromQuery] AppointmentsByServiceReportCommand command)
        {
            var appointmentsByServiceReport = await sender.Send(command);
            return new JsonResult(appointmentsByServiceReport);
        }

        [HttpGet("AppointmentsByBranchReport")]
        public async Task<IActionResult> GetByBranchReport([FromQuery] AppointmentsByBranchReportCommand command)
        {
            var appointmentsByBranchReport = await sender.Send(command);
            return new JsonResult(appointmentsByBranchReport);
        }

        [HttpGet("AppointmentsByStatusReport")]
        public async Task<IActionResult> GetByStatusReport([FromQuery] AppointmentsByStatusReportCommand command)
        {
            var appointmentsByStatusReport = await sender.Send(command);
            return new JsonResult(appointmentsByStatusReport);
        }
    }
}
