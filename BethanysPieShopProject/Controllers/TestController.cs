namespace BethanysPieShopProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
