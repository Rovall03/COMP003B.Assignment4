using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{

    public class AdoptionController : Controller
    {
        private static List<AdoptionRequest> adoptionRequests = new List<AdoptionRequest>();

        [HttpGet]
        public IActionResult Apply(int catId)
        {
            var request = new AdoptionRequest { CatId = catId };
            return View(request);
        }

        [HttpPost]
        public IActionResult Apply(AdoptionRequest request)
        {
            if (!ModelState.IsValid) return View(request);

            request.Id = adoptionRequests.Count + 1;
            adoptionRequests.Add(request);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
