using Microsoft.AspNetCore.Mvc;
using PriceQuote.Models;


namespace PriceQuote.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.PriceQuote = "";
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PriceQuoteModel pq)
        {
            if (ModelState.IsValid)
            {
                ViewBag.amount = pq.Amount().ToString("c2");
                ViewBag.total = pq.Total().ToString("c2");
            }
            else
            {
                ModelState.AddModelError("","Please fix all validation errors.");
                return View(pq);
            }
            return View(pq);
        }
    }
}
