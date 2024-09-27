using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a form-encoded body containing two parameters.
        /// </summary>
        /// <param name="smallQuantity">The input is number decimal type</param>
        /// <param name="largeQuantity">The input is number decimal type</param>
        /// <returns>An HTTP response with a body, returns the checkout summary for an order.</returns>
        /// <example>
        /// Checkout summary for an order -> ((smallPrice * smallQuantity) + (largePrice * largeQuantity)) + 13% Tax, Where smallPrice is $25.50 & largePrice is $40.50
        /// POST https://localhost:7246/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "smallQuantity=1&largeQuantity=1"
        /// -> The total price is $74.58
        /// POST https://localhost:7246/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "smallQuantity=2&largeQuantity=1"
        /// -> The total price is $103.40
        /// POST https://localhost:7246/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "smallQuantity=100&largeQuantity=100"
        /// -> The total price is $7458.00
        /// POST https://localhost:7246/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "smallQuantity=50&largeQuantity=50"
        /// -> The total price is $3,729.00
        /// </example>
        [HttpPost(template:"SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm] decimal smallQuantity, [FromForm] decimal largeQuantity)
        {
            decimal smallPrice = 25.50M;
            decimal largePrice = 40.50M;
            decimal price = (smallPrice * smallQuantity + largePrice * largeQuantity);
            decimal totalPrice = price + (price * 13 / 100);
            return $"{smallQuantity} Small @ {smallPrice.ToString("C")} = {Math.Round(smallPrice * smallQuantity, 2).ToString("C")}; {largeQuantity} Large @ {largePrice.ToString("C")} = {Math.Round(largePrice * largeQuantity, 2).ToString("C")}; Subtotal = {Math.Round(price,2).ToString("C")}; Tax = {Math.Round(price * 13 / 100, 2).ToString("C")} HST; Total = {Math.Round(totalPrice, 2).ToString("C")}";
        }
    }
}
