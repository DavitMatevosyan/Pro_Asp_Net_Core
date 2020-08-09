using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //     public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });

        public StatusCodeResult Index() => NotFound();

        public RedirectResult Result() => Redirect("/Example/Index");

        public RedirectToRouteResult Redirect() =>
            RedirectToRoute(new { controller = "Example", action = "Index", ID = "MyID" });

//        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
        
    
    }
}