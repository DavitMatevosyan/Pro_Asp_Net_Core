#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87fe9865c660e34d1e28bc6b40dab219f5505a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fe9865c660e34d1e28bc6b40dab219f5505a82", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d87be17500f32afe77b961f9581353c7ee307e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(50, 161, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h2>Person</h2></div>\r\n\r\n<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr><th>PersonId:</th><td>");
            EndContext();
            BeginContext(212, 14, false);
#line 10 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                         Write(Model.PersonId);

#line default
#line hidden
            EndContext();
            BeginContext(226, 44, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>First Name:</th><td>");
            EndContext();
            BeginContext(271, 15, false);
#line 11 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Last Name:</th><td>");
            EndContext();
            BeginContext(330, 14, false);
#line 12 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(344, 38, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Role:</th><td>");
            EndContext();
            BeginContext(383, 10, false);
#line 13 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                     Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(393, 38, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>City:</th><td>");
            EndContext();
            BeginContext(432, 23, false);
#line 14 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                     Write(Model.HomeAddress?.City);

#line default
#line hidden
            EndContext();
            BeginContext(455, 41, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Country:</th><td>");
            EndContext();
            BeginContext(497, 26, false);
#line 15 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Index.cshtml"
                        Write(Model.HomeAddress?.Country);

#line default
#line hidden
            EndContext();
            BeginContext(523, 20, true);
            WriteLiteral("</td></tr>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591