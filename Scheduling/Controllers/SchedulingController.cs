using Microsoft.AspNetCore.Mvc;
using Scheduling.Services;

namespace Scheduling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulingController : Controller
    {

        #region Fields

        private readonly ISchedulingService schedulingService;

        #endregion



        #region Constructor

        public SchedulingController(ISchedulingService schedulingService)
        {
            this.schedulingService = schedulingService ?? throw new ArgumentNullException(nameof(schedulingService));
        }


        #endregion



        #region Actions
        // This assumes that ExchangeRateImportFromDate should be accessed with a GET request.
        // If it should be accessed with a POST request, replace [HttpGet] with [HttpPost].
        [HttpGet] // Add the route template if necessary
        public IActionResult ExchangeRateImportFromDate(
            [FromQuery] DateTime date,
            CancellationToken cancellationToken
            )
        {
            bool isCompleted = schedulingService.GetExchangeRate(date, cancellationToken);

            if (!isCompleted)
                return BadRequest();

            return Ok(isCompleted);
        }

        #endregion
    }
}
