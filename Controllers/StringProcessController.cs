using Microsoft.AspNetCore.Mvc;
using NguyenQuynhAnhBTH.Models;

namespace NguyenQuynhAnhBTH.Controllers
{
    public class StringProcessController : Controller
    {
        StringProcess spc = new StringProcess(); 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LowerUpper()
        {
            return View();
        }

        public IActionResult UpperToLower()
        {
            return View();
        }

        public IActionResult CapitalizeOneFirstCharacter()
        {
            return View();
        }

        public IActionResult VietHoaCacKyTuDau()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(string chuoi)
        {
            string message = "";
            message = spc.RemoveRemainingWhiteSpace(chuoi);
            ViewBag.message = message;
            return View();
        }

         

        [HttpPost]
        public IActionResult LowerUpper(string chuoi)
        {
            string message = "";
            message = spc.LowerToUpper(chuoi);
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public IActionResult UpperToLower(string chuoi)
        {
            string message = "";
            message = spc.UpperToLower(chuoi);
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public IActionResult CapitalizeOneFirstCharacter(string chuoi)
        {
            string message = "";
            message = spc.CapitalizeOneFirstCharacter(chuoi);
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public IActionResult VietHoaCacKyTuDau(string chuoi)
        {
            string message = "";
            message = spc.CapitalizeFirstCharacter(chuoi);
            ViewBag.message = message;
            return View();
        }
    }
}