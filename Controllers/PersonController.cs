using Microsoft.AspNetCore.Mvc;
using NguyenQuynhAnhBTH.Models;

namespace NguyenQuynhAnhBTH.Controllers
{
    public class PersonController: Controller
    {
        public ActionResult Index()
        {
            List<Person> StdList= new List<Person>
            { 
                new Person { PersonId = 1, PersonName = "Nguyen Van A", PersonAge = 18 },
                new Person { PersonId = 2, PersonName = "Nguyen Van B", PersonAge = 18 },
                new Person { PersonId = 3, PersonName = "Nguyen Van C", PersonAge = 18 },
                new Person { PersonId = 4, PersonName = "Nguyen Van D", PersonAge = 18 },
                new Person { PersonId = 5, PersonName = "Nguyen Van E", PersonAge = 18 },
                new Person { PersonId = 6, PersonName = "Nguyen Van F", PersonAge = 18 },
                new Person { PersonId = 7, PersonName = "Nguyen Van G", PersonAge = 18 },
            };
            ViewData["Persons"] = StdList;
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Person std)
        {
            string message = std.PersonId + "_";
            message += std.PersonName + "_";
            message += std.PersonAge;
            ViewBag.TT = message;
            return View();
        }  
    }
}