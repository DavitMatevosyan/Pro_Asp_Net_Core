#pragma checksum "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7643a277890a8aaba955eee6cedb0db971e536e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Thanks.cshtml", typeof(AspNetCore.Views_Home_Thanks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7643a277890a8aaba955eee6cedb0db971e536e0", @"/Views/Home/Thanks.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartyInvites.Models.GuestResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(71, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(102, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa20fcc8bf5745d69ce5e1a6e6fa0cfa", async() => {
                BeginContext(108, 177, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width\"/>\r\n        <title>Thanks</title>\r\n        <link rel=\"stylesheet\" href=\"lib/bootstrap/dist/css/bootstrap.css\"/>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(292, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(300, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe35bcfd9e3d4aed8e3d0af235514d36", async() => {
                BeginContext(326, 42, true);
                WriteLiteral("\r\n        <p>\r\n            <h1>Thank you, ");
                EndContext();
                BeginContext(369, 10, false);
#line 17 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml"
                      Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(379, 8, true);
                WriteLiteral("!</h1>\r\n");
                EndContext();
#line 18 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml"
             if(Model.WillAttend == true){

#line default
#line hidden
                BeginContext(431, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(449, 33, true);
                WriteLiteral("It\'s great that you are coming.\r\n");
                EndContext();
#line 20 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml"
            }else{

#line default
#line hidden
                BeginContext(502, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(520, 21, true);
                WriteLiteral("Sorry to hear that.\r\n");
                EndContext();
#line 22 "D:\Programming\C Sharp\Pro  asp.net core mvc 2\Book code\InvitesProjects\PartyInvites\Views\Home\Thanks.cshtml"
            }

#line default
#line hidden
                BeginContext(556, 103, true);
                WriteLiteral("        </p>\r\n        Click <a asp-action=\"ListResponses\">Here</a>\r\n        to see who is coming.\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(666, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartyInvites.Models.GuestResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591