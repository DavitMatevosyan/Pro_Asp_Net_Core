#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc2d036348e3982c733952a146a755439655115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Header), @"mvc.1.0.view", @"/Views/Home/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Header.cshtml", typeof(AspNetCore.Views_Home_Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc2d036348e3982c733952a146a755439655115", @"/Views/Home/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d87be17500f32afe77b961f9581353c7ee307e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Header.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Headers";

#line default
#line hidden
            BeginContext(84, 91, true);
            WriteLiteral("\r\n<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr><th>Accept:</th><td>");
            EndContext();
            BeginContext(176, 12, false);
#line 8 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Header.cshtml"
                       Write(Model.Accept);

#line default
#line hidden
            EndContext();
            BeginContext(188, 49, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Accept-Encoding:</th><td>");
            EndContext();
            BeginContext(238, 20, false);
#line 9 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Header.cshtml"
                                Write(Model.AcceptEncoding);

#line default
#line hidden
            EndContext();
            BeginContext(258, 49, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Accept-Language:</th><td>");
            EndContext();
            BeginContext(308, 21, false);
#line 10 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\MvcModels\MvcModels\Views\Home\Header.cshtml"
                                Write(Model.AcceeptLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(329, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
