using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class ViewResultDiagnostics : IActionFilter
    {
        private IFilterDiagnostics diagnostics;

        public ViewResultDiagnostics(IFilterDiagnostics diags)
        {
            diagnostics = diags;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // nothing
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            ViewResult vr;
            if ((vr = context.Result as ViewResult) != null)
            {
                diagnostics.AddMessage($"View Name: {vr.ViewName}");
                diagnostics.AddMessage($@"Model Type: {vr.ViewData.Model.GetType().Name}");
            }
        }
    }
}
