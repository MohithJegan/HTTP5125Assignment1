using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage.</returns>
        /// <example>
        /// GET https://localhost:7246/api/q1/welcome -> Welcome to 5125!
        /// </example>
        [HttpGet(template:"Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
