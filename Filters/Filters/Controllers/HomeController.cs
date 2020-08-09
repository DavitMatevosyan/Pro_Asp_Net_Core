using Filters.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Filters.Controllers
{
    // infrastructure.httpsonly, infrastructure.profileattribute, ..ViewResultDetailsAttribute
    //[Profile]
    //[ViewResultDetails]
    //[RangeExceptionFilter]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[ServiceFilter(typeof(TimeFilter))]
    [Message("This is the controller-scoped Filter", Order = 10)]
    public class HomeController : Controller
    {
        [Message("this is the first action-scoped filter", Order = 1)]
        [Message("This is the second action-scoped filter", Order = -1)]
        public ViewResult Index() =>
            View("Message", "This is the index action on the Home controller");

        public ViewResult SecondAction() =>
            View("Message", "This is the SectionAction on the Home Controller");
    
        public ViewResult GenerateException(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            else
            {
                return View("Message", $"The value is {id}");
            }
        }
    }
}