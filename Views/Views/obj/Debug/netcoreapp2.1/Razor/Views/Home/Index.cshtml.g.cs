#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e51b863f8a7fba3c4f40b64cbcec8355fd62eca"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e51b863f8a7fba3c4f40b64cbcec8355fd62eca", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "str", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Header", async() => {
                BeginContext(68, 28, true);
                WriteLiteral("\r\n<div class=\"bg-success\">\r\n");
                EndContext();
#line 8 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
     foreach (string str in new[] { "Home", "List", "Edit" })
    {

#line default
#line hidden
                BeginContext(166, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(174, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaae4ffd7ae45109d7ba066afaea2c8", async() => {
                    BeginContext(226, 3, false);
#line 10 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
                                                      Write(str);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(233, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(242, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
            }
            );
            BeginContext(253, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("body", async() => {
                BeginContext(270, 36, true);
                WriteLiteral("\r\n\r\nThis is a list of fruit names:\r\n");
                EndContext();
#line 18 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
     foreach (string name in Model)
    {

#line default
#line hidden
                BeginContext(350, 18, true);
                WriteLiteral("         <span><b>");
                EndContext();
                BeginContext(369, 4, false);
#line 20 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
             Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(373, 13, true);
                WriteLiteral("</b></span>\r\n");
                EndContext();
#line 21 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\Views\Views\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            BeginContext(396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Footer", async() => {
                BeginContext(415, 60, true);
                WriteLiteral("\r\n<div class=\"bg-success\">\r\n    This is the footer\r\n</div>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
