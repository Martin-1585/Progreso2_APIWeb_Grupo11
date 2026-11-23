using Progreso2_APIWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Progreso2_APIWeb.Controllers
{
    public class ClimasController : Controller
    {
        private readonly OpenMeteoServices _service = new OpenMeteoServices();

        public async Task<ActionResult> Index()
        {
            var clima = await _service.GetClimaAsync();
            return View(clima);
        }
    }
}