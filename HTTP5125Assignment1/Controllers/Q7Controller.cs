using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="days">The input is day in number format</param>
        /// <returns>An HTTP response with the response body indicating the usage, add or subtract the days entered to the today's date or the current day's date based on the input.</returns>
        /// <example>
        /// Consider today's date or current day date is 2024-09-20 [20th September 2024]
        /// GET https://localhost:7246/api/q7/timemachine?days=1 -> days:1 -> 2024-09-21 -> Adds the date as the input >= 0
        /// GET https://localhost:7246/api/q7/timemachine?days=-1 -> days:-1 -> 2024-09-19 -> Subtracts the date as the input < 0
        /// GET https://localhost:7246/api/q7/timemachine?days=5 -> days: 5 -> 2024-09-25 -> Adds the date as the input >= 0
        /// GET https://localhost:7246/api/q7/timemachine?days=8 -> days:8 -> 2024-09-28 -> Adds the date as the input >= 0
        /// GET https://localhost:7246/api/q7/timemachine?days=10 -> days:10 -> 2024-09-30 -> Adds the date as the input >= 0
        /// </example>
        [HttpGet(template:"TimeMachine")]
        public string TimeMachine(int days)
        {
            DateTime today = DateTime.Today;
            return (today.AddDays(days)).ToString("yyyy-MM-dd");
        }
    }
}
