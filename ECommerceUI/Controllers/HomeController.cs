
using ECommerce.BLL.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ECommerceUI.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public async Task<ActionResult> Index()
        {
            var me = await categoryService.GetAll();
            //await categoryService.TransacionTest();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}