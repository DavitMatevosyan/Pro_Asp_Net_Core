#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "251d8af17279658d209d12fd4d5565422f3709c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Address), @"mvc.1.0.view", @"/Views/Home/Address.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Address.cshtml", typeof(AspNetCore.Views_Home_Address))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\_ViewImports.cshtml"
using MvcModels.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251d8af17279658d209d12fd4d5565422f3709c2", @"/Views/Home/Address.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d87be17500f32afe77b961f9581353c7ee307e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Address : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<AddressSummary>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Address", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
   
    Layout = "_Layout";
    ViewBag.Title = "Address";

#line default
#line hidden
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(126, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(130, 662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f914dec7924431389da6b2c3de86c1b", async() => {
                BeginContext(171, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
         for (int i = 0; i < 3; i++)
        {

#line default
#line hidden
                BeginContext(222, 75, true);
                WriteLiteral("            <fieldset class=\"form-group\">\r\n                <legend>Address ");
                EndContext();
                BeginContext(299, 5, false);
#line 14 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
                            Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(305, 121, true);
                WriteLiteral("</legend>\r\n                <div class=\"form-group\">\r\n                    <label>City:</label>\r\n                    <input");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 426, "\"", 442, 3);
                WriteAttributeValue("", 433, "[", 433, 1, true);
#line 17 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
WriteAttributeValue("", 434, i, 434, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 436, "].City", 436, 6, true);
                EndWriteAttribute();
                BeginContext(443, 162, true);
                WriteLiteral(" class=\"form-control\"/>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Country:</label>\r\n                    <input");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 605, "\"", 624, 3);
                WriteAttributeValue("", 612, "[", 612, 1, true);
#line 21 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
WriteAttributeValue("", 613, i, 613, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 615, "].Country", 615, 9, true);
                EndWriteAttribute();
                BeginContext(625, 74, true);
                WriteLiteral(" class=\"form-control\"/>\r\n                </div>\r\n            </fieldset>\r\n");
                EndContext();
#line 24 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
        }

#line default
#line hidden
                BeginContext(710, 75, true);
                WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(792, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(808, 151, true);
            WriteLiteral("    <table class=\"table table-sm table-bordered table-striped\">\r\n        <tr>\r\n            <th>City</th>\r\n            <th>Country</th>\r\n        </tr>\r\n");
            EndContext();
#line 36 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
         foreach (var address in Model)
        {

#line default
#line hidden
            BeginContext(1011, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1050, 12, false);
#line 39 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
               Write(address.City);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1090, 15, false);
#line 40 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
               Write(address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
        }

#line default
#line hidden
            BeginContext(1142, 18, true);
            WriteLiteral("    </table>\r\n    ");
            EndContext();
            BeginContext(1160, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7927eaa85643729f74d855e22f8413", async() => {
                BeginContext(1208, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1216, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Address.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<AddressSummary>> Html { get; private set; }
    }
}
#pragma warning restore 1591