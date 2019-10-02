using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorkd/Welcome/
        public IActionResult Welcome(int ID, string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, numTimes = {numTimes}, ID: {ID}");
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    } 
}