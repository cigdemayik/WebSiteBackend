#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Home\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a7105926225fd06d4ec2c87dbf17c01c30fc053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Error), @"mvc.1.0.view", @"/Views/Home/Error.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.Business.Abstracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a7105926225fd06d4ec2c87dbf17c01c30fc053", @"/Views/Home/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288eb7cd150c6fffb65bf68ba8b78299e034ea1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a7105926225fd06d4ec2c87dbf17c01c30fc0533640", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>ERROR</title>

    <!-- Google font -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:200,400,700"" rel=""stylesheet"">

    <!-- Custom stlylesheet -->
    <link type=""text/css"" rel=""stylesheet"" href=""css/style.css"" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
          <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
          <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
        <![endif]-->

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a7105926225fd06d4ec2c87dbf17c01c30fc0535570", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"notfound\">\r\n        <div class=\"notfound\">\r\n            <div class=\"notfound-404\">\r\n                <h1>Oops!</h1>\r\n                <h2>");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Home\Error.cshtml"
               Write(ViewBag.Code);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ERROR</h2>\r\n            </div>\r\n            ");
#nullable restore
#line 36 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Home\Error.cshtml"
       Write(Html.ActionLink("Anasayfa", "Index", "Home", null, new { @class = "btn custom-btn " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- This templates was made by Colorlib (https://colorlib.com) -->\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
