#pragma checksum "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98afb8646ecb78f61057d083b74219724801f574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_News), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/News.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98afb8646ecb78f61057d083b74219724801f574", @"/Areas/Admin/Views/Home/News.cshtml")]
    public class Areas_Admin_Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebSiteBackend.WebUI.Areas.Admin.Models.NewsModels.NewsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
   Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\n\n    <div class=\"card shadow mb-4\">\n        <div class=\"card-header py-3\">\n            News Tablosu\n            ");
#nullable restore
#line 9 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
       Write(Html.ActionLink("Ekle", "NewsCreate", "Home", null, new { @class = "btn btn-primary float-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 11 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
         if (Model.Count <= 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center\">Hiç Veri Yok</p> ");
#nullable restore
#line 13 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
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
                    <th>Konu</th>
                    <th>Image</th>
                    <th>Kategori Adı</th>
                    <th>Dil</th>
                    <th>İşlem</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 32 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
               Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 36 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
                 if (((int)item.Language) == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\"Türkçe\"</td>\n");
#nullable restore
#line 39 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
 }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\"İngilizce\";</td>");
#nullable restore
#line 42 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
               Write(Html.ActionLink("Güncelle", "NewsUpdate", "Home", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 45 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
               Write(Html.ActionLink("Sil", "NewsDelete", "Home", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>");
#nullable restore
#line 47 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tbody>\n        </table>\n    </div>\n</div>            ");
#nullable restore
#line 52 "C:\Users\ÇİĞDEM\Desktop\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\News.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebSiteBackend.WebUI.Areas.Admin.Models.NewsModels.NewsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
