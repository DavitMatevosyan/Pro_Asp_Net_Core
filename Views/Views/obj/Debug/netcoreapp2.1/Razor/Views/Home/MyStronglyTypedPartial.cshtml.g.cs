#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\MyStronglyTypedPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51de1650bee8201af4e2ee139cf40a54214fbc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyStronglyTypedPartial), @"mvc.1.0.view", @"/Views/Home/MyStronglyTypedPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MyStronglyTypedPartial.cshtml", typeof(AspNetCore.Views_Home_MyStronglyTypedPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51de1650bee8201af4e2ee139cf40a54214fbc6", @"/Views/Home/MyStronglyTypedPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyStronglyTypedPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 82, true);
            WriteLiteral("\r\n<div class=\"bg-info\">\r\n    this is the message from the partial view\r\n    <ul>\r\n");
            EndContext();
#line 6 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\MyStronglyTypedPartial.cshtml"
         foreach (string str in Model)
        {

#line default
#line hidden
            BeginContext(161, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(178, 3, false);
#line 8 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\MyStronglyTypedPartial.cshtml"
           Write(str);

#line default
#line hidden
            EndContext();
            BeginContext(181, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\MyStronglyTypedPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(199, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591