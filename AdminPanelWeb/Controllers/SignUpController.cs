using Microsoft.AspNetCore.Mvc;

namespace AdminPanelWeb.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
