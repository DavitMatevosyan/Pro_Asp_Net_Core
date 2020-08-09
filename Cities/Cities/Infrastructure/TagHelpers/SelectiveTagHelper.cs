using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cities.Infrastructure.TagHelpers
{
    [HtmlTargetElement(Attributes ="show-for-action")]
    public class SelectiveTagHelper :TagHelper
    {
        public string ShowForAction { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!ViewContext.RouteData.Values["action"].ToString().Equals(ShowForAction, System.StringComparison.OrdinalIgnoreCase))
            {
                output.SuppressOutput();
            }
        }
    }
}
