using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm() => View();

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response) 
        {
            if (ModelState.IsValid)
            {
                repository.AddResponse(response);
                return View("Thanks", response);
            }
            else{
                return View();
            }
        }

        public ViewResult ListResponses() =>
            View(repository.Responses.Where(r => r.WillAttend == true));
    }
}