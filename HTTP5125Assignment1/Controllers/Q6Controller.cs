using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="side">The input given is the side of the hexagon(number)</param>
        /// <returns>An HTTP response with a body indicating the usage, and returns the area of the hexagon.</returns>
        /// <example>
        /// Area of regular hexagon -> ((3* (root of 3)) / 2) * (side * side), Where side > 0
        /// GET https://localhost:7246/api/q6/hexagon?side=1 -> Get method with one parameter -> side:1 -> 2.598076211353316
        /// GET https://localhost:7246/api/q6/hexagon?side=1.5 -> Get method with one parameter -> side:1.5 -> 5.845671475544961
        /// GET https://localhost:7246/api/q6/hexagon?side=20 -> Get method with one parameter -> side:20 -> 1039.2304845413264
        /// GET https://localhost:7246/api/q6/hexagon?side=30 -> Get method with one parameter -> side:30 -> 2338.2685982179846
        /// </example>
        [HttpGet(template:"Hexagon")]
        public double Hexagon(double side)
        {
            double result = (3 * Math.Sqrt(3)) / 2 * Math.Pow(side, 2);
            return result;
        }
    }
}
