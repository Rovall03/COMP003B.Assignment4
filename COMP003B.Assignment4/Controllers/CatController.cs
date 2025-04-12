using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class CatController : Controller
    {
        private static List<Cat> cats = new List<Cat>
        {
            new Cat { Id = 1, Name = "Crumpet", Age = 2, Breed = "British Shorthair", Description = "Playful and friendly.", ImageUrl = "https://media.istockphoto.com/id/1361394182/photo/funny-british-shorthair-cat-portrait-looking-shocked-or-surprised.jpg?b=1&s=170667a&w=0&k=20&c=nOa1R7PGaqOaQscx10FpA5ZNenMeDfs-k6VgmmuY4cc=" },
            new Cat { Id = 2, Name = "Whiskers", Age = 4, Breed = "Siamese", Description ="Loves naps and cuddles." , ImageUrl = "https://images2.fanpop.com/images/photos/5100000/Cats-wallpaper-cats-5194568-1280-1024.jpg" },
        };

        public IActionResult Index()
        {
            return View(cats);
        }
        public IActionResult Details(int id)
        {
            // Loop through the list of cats and find the one with the matching ID
            Cat catFound = null;

            foreach (Cat c in cats)
            {
                if
                    (c.Id == id)
                {
                    catFound = c;
                    break;
                }
            }
            if
              (catFound == null)
            {
                return NotFound();
            }
            return View(catFound);
        }

    }
}