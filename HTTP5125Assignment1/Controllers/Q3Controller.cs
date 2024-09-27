using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one integer number parameter and provides a response message.
        /// </summary>
        /// <param name="number">The input is number</param>
        /// <returns>An HTTP response with a body indicating the usage, displaying the cubic value of the input.</returns>
        /// <example>
        /// GET https://localhost:7246/api/q3/cube/4 -> 64 
        /// GET https://localhost:7246/api/q3/cube/-4 -> -64
        /// GET https://localhost:7246/api/q3/cube/10 -> 1000
        /// GET https://localhost:7246/api/q3/cube/-7 -> -343
        /// GET https://localhost:7246/api/q3/cube/9 -> 729
        /// </example>
        [HttpGet(template: "Cube/{number}")]
        public int Cube(int number)
        {
            return number * number * number;
        }
    }
}
