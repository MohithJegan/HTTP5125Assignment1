using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <param name="name">The input of the user's name</param>
        /// <returns>An HTTP response with a body indicating the usage, echoing the value of 'name' parameter.</returns>
        /// <example>
        /// GET https://localhost:7246/api/q2/greeting?name=Gary -> Get method with one parameter -> name: Gary -> Hi Gary !
        /// GET https://localhost:7246/api/q2/greeting?name=Ren%C3%A9e -> Get method with one parameter -> name: Renée -> Hi  Renée !
        /// GET https://localhost:7246/api/q2/greeting?name=John%20Doe -> Get method with one parameter -> name: John Doe -> Hi John Doe !
        /// </example>
        [HttpGet(template:"Greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name} !";
        }
    }
}
