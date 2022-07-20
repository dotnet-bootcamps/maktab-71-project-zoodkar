using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        public ServiceController(SericesAppServic appServic)
        {

        }
        public async Task<IActionResult> Index()
        {
            List<Service> = 

            return View();
        }
    }
}
