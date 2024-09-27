using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>
        /// <param name="requestBody">The input is number</param>
        /// <returns>An HTTP response with a body echoing the request body.</returns>
        /// <example>
        /// POST https://localhost:7246/api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "request body"
        /// Entered number is 5 -> requestBody:5 -> Shh.. the secret is 5
        /// POST https://localhost:7246/api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "request body"
        /// Entered number is -200 -> requestBody:-200 -> Shh.. the secret is -200
        /// POST https://localhost:7246/api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "request body"
        /// Entered number is 400 -> requestBody:400 -> Shh.. the secret is 400
        /// </example>
        [HttpPost(template:"Secret")]
        public string Secret([FromBody] int requestBody)
        {
            return $"Shh.. the secret is {requestBody}" ;
        }
    }
}
