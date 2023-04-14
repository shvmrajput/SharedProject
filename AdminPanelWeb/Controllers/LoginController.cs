using Microsoft.AspNetCore.Mvc;

namespace AdminPanelWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
