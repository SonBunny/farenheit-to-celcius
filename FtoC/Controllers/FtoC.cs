using Microsoft.AspNetCore.Mvc;

namespace FtoC.Controllers
{
    public class FtoC : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String ftoc(double f)
        {
            double c = (f - 32) * 100 / 180;

            string result = "The converted Fareinheit " + f + " is equiavalent to " + c + " degree celcius.";
            return result;
        }


    }
}
