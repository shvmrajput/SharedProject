using Microsoft.AspNetCore.Authorization;
using AdminPanelApi.Auth;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AdminPanelWeb.Services.Interfaces;

namespace AdminPanelWeb.Controllers
{
    //new code//
    


    public class UserController : Controller
    {
        private readonly IAdminPanelWeb _service;
        public UserController(IAdminPanelWeb service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        public async Task<IActionResult> Index()
        {
            var products = await _service.Find();
            return View();
        }


    }
}
