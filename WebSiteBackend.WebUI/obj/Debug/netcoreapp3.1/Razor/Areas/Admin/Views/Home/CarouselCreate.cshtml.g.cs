#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6519eeea9352195d0af92d09dc06946dd90409b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_CarouselCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/CarouselCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6519eeea9352195d0af92d09dc06946dd90409b7", @"/Areas/Admin/Views/Home/CarouselCreate.cshtml")]
    public class Areas_Admin_Views_Home_CarouselCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselCreateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
   Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
 using (Html.BeginForm("CarouselCreate", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card"">
                    <div class=""card-header"">
                        Carousel
                    </div>
                    <div class=""card-body"">

                        <div class=""form-group"">
                            ");
#nullable restore
#line 16 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.LabelFor(m => m.Header, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 17 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.TextBoxFor(m => m.Header, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 18 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 21 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.LabelFor(m => m.Image, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 22 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.EditorFor(m => m.Image, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 23 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 26 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.LabelFor(m => m.Detail, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 27 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.TextBoxFor(m => m.Detail, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 28 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 31 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.DropDownListFor(m => m.Language, new List<SelectListItem>{
                new SelectListItem {Text="Türkçe",Value="1"},
                new SelectListItem {Text="İngilizce",Value="2"}
            }, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 35 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <input type=\"submit\" value=\"Kaydet\" class=\"btn btn-primary\" />\n                    </div>\n                </div>");
#nullable restore
#line 39 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselCreate.cshtml"
                      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
