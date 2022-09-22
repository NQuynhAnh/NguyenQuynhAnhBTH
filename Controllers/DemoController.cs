using Microsoft.AspNetCore.Mvc;
using NguyenQuynhAnhBTH.Models.Process;

namespace NguyenQuynhAnhBTH.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double heSoA, double heSoB, double heSoC)
        {
           
            string message = "";
            message = gpt.GiaiPhuongTrinhBacHai(heSoA, heSoB, heSoC);
            ViewBag.thongBao = message;
            return View();
        }    
    }
}