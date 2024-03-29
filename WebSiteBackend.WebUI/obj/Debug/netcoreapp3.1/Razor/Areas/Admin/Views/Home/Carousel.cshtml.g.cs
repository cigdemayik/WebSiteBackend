#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c7feb59222dba4030ee78a5508bd02c085b66f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Carousel), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Carousel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c7feb59222dba4030ee78a5508bd02c085b66f", @"/Areas/Admin/Views/Home/Carousel.cshtml")]
    public class Areas_Admin_Views_Home_Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
   Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-header py-3\">\r\n            Carousel Tablosu\r\n            ");
#nullable restore
#line 9 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
       Write(Html.ActionLink("Ekle", "CarouselCreate", "Home", null, new { @class = "btn btn-primary float-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 11 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
         if (Model.Count <= 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center\">Hiç Veri Yok</p> ");
#nullable restore
#line 13 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                                        }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card-body"">
    <div class=""table-responsive"">
        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Başlık</th>
                    <th>İmage Url</th>
                    <th>Detay</th>
                    <th>Aktif Mi?</th>
                    <th>Dil</th>
                    <th>İşlem</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                   Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                   Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                   Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                     if ((item.Active) == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Aktif\"</td> ");
#nullable restore
#line 38 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                                 }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Pasif\"</td>");
#nullable restore
#line 41 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                     if (((int)item.Language) == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"İngilizce\"</td>\r\n");
#nullable restore
#line 46 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Türkçe\"</td>\r\n");
#nullable restore
#line 50 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                   Write(Html.ActionLink("Güncelle", "CarouselUpdate", "Home", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 53 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
                   Write(Html.ActionLink("Sil", "CarouselDelete", "Home", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n                </div>\r\n            </div>            \r\n");
#nullable restore
#line 62 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Carousel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels.CarouselModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
