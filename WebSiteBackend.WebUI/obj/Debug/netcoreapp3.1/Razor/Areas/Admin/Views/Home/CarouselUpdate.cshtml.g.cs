#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b19c9ef62cf9f07d16194b17da809d89bf0e8cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_CarouselUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/CarouselUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b19c9ef62cf9f07d16194b17da809d89bf0e8cb", @"/Areas/Admin/Views/Home/CarouselUpdate.cshtml")]
    public class Areas_Admin_Views_Home_CarouselUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselUpdateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
   Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
 using (Html.BeginForm("CarouselUpdate", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card"">
                    <div class=""card-header"">
                        Kategori
                    </div>
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 575, "\"", 592, 1);
#nullable restore
#line 15 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
WriteAttributeValue("", 583, Model.Id, 583, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 19 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.LabelFor(m => m.Header, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 20 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.TextBoxFor(m => m.Header, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 21 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Header, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 24 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.LabelFor(m => m.Image, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 25 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.EditorFor(m => m.Image, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 26 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Image, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 29 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.LabelFor(m => m.Detail, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 30 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.TextBoxFor(m => m.Detail, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 31 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Detail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.DropDownListFor(m => m.Language, new List<SelectListItem>{
          new SelectListItem {Text="Türkçe",Value="1"},
          new SelectListItem {Text="İngilizce",Value="2"}
      }, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 38 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Language, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 41 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.DropDownListFor(m => m.Active, new List<SelectListItem>{
          new SelectListItem {Text="Aktif",Value="true"},
          new SelectListItem {Text="Pasif",Value="false"}
      }, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 45 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Active, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n\n                        <input type=\"submit\" value=\"Güncelle\" class=\"btn btn-primary\" />\n                    </div>\n                </div>");
#nullable restore
#line 50 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CarouselUpdate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
