using Microsoft.AspNetCore.Mvc;

namespace omar_hesham_C42_mon_Thu_8pm_mvc01.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This Is Index Action";
        }
        public string AboutUs()
        {
            return "This Is About Action";
        }
    }
}
