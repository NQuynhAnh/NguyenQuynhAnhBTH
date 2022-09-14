using Microsoft.AspNetCore.Mvc;
using NguyenQuynhAnhBTH.Models;

 namespace NguyenQuynhAnhBTH.Controllers
 {
     public class EmployeeController : Controller
     {
         public ActionResult Index()
        {
            List<Employee> StdList= new List<Employee>
            { 
                new Employee { EmployeeID = 1, EmployeeName = "Nguyen Van A", EmployeeAge = 18 },
                new Employee { EmployeeID = 2, EmployeeName = "Nguyen Van B", EmployeeAge = 18 },
                new Employee { EmployeeID = 3, EmployeeName = "Nguyen Van C", EmployeeAge = 18 },
                new Employee { EmployeeID = 4, EmployeeName = "Nguyen Van D", EmployeeAge = 18 },
                new Employee { EmployeeID = 5, EmployeeName = "Nguyen Van E", EmployeeAge = 18 },
                new Employee { EmployeeID = 6, EmployeeName = "Nguyen Van F", EmployeeAge = 18 },
                new Employee { EmployeeID = 7, EmployeeName = "Nguyen Van G", EmployeeAge = 18 },
            };
            ViewData["Employees"] = StdList;
            return View();
        }
       
        // [HttpPost]
        // public IActionResult Create(Employee std)
        // {
        //     string message = std.EmployeeID + "_";
        //     message += std.EmployeeName + "_";
        //     message += std.EmployeeAge;
        //     ViewBag.TT = message;
        //     return View();
        // }  
     }
 }