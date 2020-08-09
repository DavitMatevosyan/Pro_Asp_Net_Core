using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UsingViewComponents.Models;

namespace UsingViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private ICityRepository repository;

        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }

        // for the argument to be valid use  ", new { showList = true } " text in the _Layout file
        public IViewComponentResult Invoke(bool showList)
        {
            if (showList)
            {
                return View("CityList", repository.Cities);
            } 
            return View(new CityViewModel()
            {
                Cities = repository.Cities.Count(),
                Population = repository.Cities.Sum(c => c.Population)
            });
        }
    }
}
