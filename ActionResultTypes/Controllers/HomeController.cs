using ActionResultTypes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ActionResultTypes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ShowEmployee()
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = 1,
                FirstName = "Paul",
                LastName = "Andrew",
                Location = "Mumbai",
                Email = "Paul@geeksarray.com"
            };
            return View(employee);
        }

        public ContentResult ContentResultTest()
        {
            return Content("<b>Hello from GeeksArray</b>", "text/html", System.Text.Encoding.UTF8);
        }

        public RedirectResult RedirectResultTest()
        {
            //return Redirect("https://geeksarray.com");
            //return RedirectPermanent("https://google.com");
            //return RedirectPreserveMethod("https://geeksarray.com");
            return RedirectPermanentPreserveMethod("https://geeksarray.com");
        }

        public FileResult FileResultTest()
        {
            return File("~/downloads/pdf-sample.pdf", "application/pdf");
        }

        public StatusCodeResult StatusCodeResultTest()
        {
            return StatusCode(200);            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
