using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with an empty body and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage.</returns>
        /// <example>
        /// POST https://localhost:7246/api/q4/knockknock
        /// FORM DATA: (empty)
        /// -> Who’s there?
        /// </example>
        [HttpPost(template:"KnockKnock")]
        public string KnockKnock()
        {
            return "Who’s there?";
        }
    }
}
