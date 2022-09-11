using Microsoft.AspNetCore.Mvc;
using NguyenQuynhAnhBTH.Models;

namespace NguyenQuynhAnhBTH.Controllers
 {
    public class StudentController: Controller
    {
        //code hôm trước oke
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult Index(Person pr)
        // {
        //     ViewBag.ThongBao = pr.PersonId + "_" + pr.PersonName + "_" + pr.PersonAge;
        //     return View();
        // }
        
        //code mới k chạy được
        public ActionResult Index()
        {
            List<Student> StdList= new List<Student>
            { 
                new Student { StudentID = 1, StudentName = "Nguyen Van A", StudentAge = 18 },
                new Student { StudentID = 2, StudentName = "Nguyen Van B", StudentAge = 18 },
                new Student { StudentID = 3, StudentName = "Nguyen Van C", StudentAge = 18 },
                new Student { StudentID = 4, StudentName = "Nguyen Van D", StudentAge = 18 },
                new Student { StudentID = 5, StudentName = "Nguyen Van E", StudentAge = 18 },
                new Student { StudentID = 6, StudentName = "Nguyen Van F", StudentAge = 18 },
                new Student { StudentID = 7, StudentName = "Nguyen Van G", StudentAge = 18 },
            };
            ViewData["Students"] = StdList;
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string message = std.StudentID + "_";
            message += std.StudentName + "_";
            message += std.StudentAge;
            ViewBag.TT = message;
            return View();
        }  
    }
 }