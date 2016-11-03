using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore.Controllers
{
    public class HomeController : Controller
    {

        HtmlEncoder _htmlEncoder;
        JavaScriptEncoder _javaScriptEncoder;
        UrlEncoder _urlEncoder;

        public HomeController(HtmlEncoder htmlEncoder,
                              JavaScriptEncoder javascriptEncoder,
                              UrlEncoder urlEncoder)
        {
            _htmlEncoder = htmlEncoder;
            _javaScriptEncoder = javascriptEncoder;
            _urlEncoder = urlEncoder;
        }

        public IActionResult Car()
        {
            var encodedName = _htmlEncoder.Encode("lamborghini");
            return View(new Car() { Id = 1, Name = encodedName });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CarContext : DbContext
    {
        public CarContext()
            : base()
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
