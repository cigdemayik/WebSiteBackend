#pragma checksum "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9491da5998aa8285033999fd1a394f9bce3617b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Create), @"mvc.1.0.view", @"/Views/Blog/Create.cshtml")]
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
#line 1 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
using WebSiteBackend.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
using WebSiteBackend.Business.Abstracts.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9491da5998aa8285033999fd1a394f9bce3617b", @"/Views/Blog/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a3a3947bba1fab229491847e61ca530884a0f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
  

    Layout = "~/Views/Private/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9491da5998aa8285033999fd1a394f9bce3617b5892", async() => {
                WriteLiteral("\r\n    <div id=\"layoutAuthentication\">\r\n        <div");
                BeginWriteAttribute("id", " id=\"", 253, "\"", 258, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-5"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Blog Ekle</h3></div>
                                <div class=""card-body"">

                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9491da5998aa8285033999fd1a394f9bce3617b6842", async() => {
                    WriteLiteral("\r\n                                        <div>\r\n");
#nullable restore
#line 24 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                             using (Html.BeginForm("Create", "Blog", FormMethod.Post))
                                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <div class=\"form-group\">\r\n");
                    WriteLiteral("                                                ");
#nullable restore
#line 28 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.TextBoxFor(x => x.Header, default, new { @class = "form-control col-md-8", @id = "Name", @placeholder = "Bir Başlık Giriniz" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 29 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.TextBoxFor(x => x.Image, default, new { @class = "form-control col-md-8", @id = "Name", @placeholder = "Bir Resim Adı Ekleyiniz" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 30 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.TextBoxFor(x => x.Category, default, new { @class = "form-control col-md-8", @id = "Name", @placeholder = "Bir Kategori Adı Giriniz" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 31 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.TextBoxFor(x => x.ReleaseTime, default, new { @class = "form-control col-md-8", @id = "Name", @placeholder = "Yayın Tarihi Giriniz" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 32 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.TextBoxFor(x => x.Content, default, new { @class = "form-control col-md-8", @id = "Name", @placeholder = "Konu" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </div>\r\n");
#nullable restore
#line 34 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                           Write(Html.ValidationMessageFor(x => x.Header, "", new { @class = "text-danger form-text" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Burcu\source\repos\WebSiteBackend\WebSiteBackend.WebUI\Views\Blog\Create.cshtml"
                                                                                                                                       

                                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <div>\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9491da5998aa8285033999fd1a394f9bce3617b10725", async() => {
                        WriteLiteral("Ekle");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </main>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
