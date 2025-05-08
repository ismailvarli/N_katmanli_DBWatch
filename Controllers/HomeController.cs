using System.Diagnostics;
using BLL;
using Microsoft.AspNetCore.Mvc;
using N_katmanli_DBWatch.Models;

namespace N_katmanli_DBWatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly Saatservice saatservice;

        public HomeController()
        {
            saatservice = new Saatservice();
        }

        public IActionResult Index()
        {
            var saat = saatservice.GetAll();

            return View(saat);
        }
    }
}
