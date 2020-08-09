using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>
            View("Result", new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });

        public ViewResult CustomVariable(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable)
            };
            //            r.Data["Id"] = RouteData.Values["id"]; RouteData.Values["id"] the value of "id" is received from startup.cs mapRoute method
            r.Data["Id"] = id ?? "<no value>";
            //  r.Data["catchall"] = RouteData.Values["catchall"];
            r.Data["Url"] = Url.Action("CustomVariable", "Home", new { id = 100 });
            return View("Result", r);
        }
    }
}