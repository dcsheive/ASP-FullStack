using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using renderviews.Models;
namespace renderviews.Controllers   
{
    public class HelloController : Controller  
    {        
        [HttpGet]
        [Route("")]
        public IActionResult Method()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult OtherMethod(Survey survey)
        {
            return View("Result", survey);
        }
    }
}
