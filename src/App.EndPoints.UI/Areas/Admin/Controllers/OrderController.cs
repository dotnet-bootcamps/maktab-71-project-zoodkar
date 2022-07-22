using App.Domain.Core.Services.AppService.Order;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.UI.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }
        public async Task<IActionResult> Index()
        {
            var list =await _orderAppService.GetAll();
            return View(list);
        }
    }
}
