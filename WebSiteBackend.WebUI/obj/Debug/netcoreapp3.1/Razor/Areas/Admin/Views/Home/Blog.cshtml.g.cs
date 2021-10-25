#pragma checksum "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266cc97b1dcafedc4aed113e3a9fe209fc148bb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Blog), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"266cc97b1dcafedc4aed113e3a9fe209fc148bb0", @"/Areas/Admin/Views/Home/Blog.cshtml")]
    public class Areas_Admin_Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels.BlogModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
       Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\n\n        <div class=\"card shadow mb-4\">\n            <div class=\"card-header py-3\">\n                Blog Tablosu\n                ");
#nullable restore
#line 9 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
           Write(Html.ActionLink("Ekle", "BlogCreate", "Home", null, new { @class = "btn btn-primary float-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 11 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                 if (Model.Count <= 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-center\">Hiç Veri Yok</p>\n");
#nullable restore
#line 14 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                  }
                 else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card-body"">
                 <div class=""table-responsive"">
                  <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                          <thead>
                           <tr>
                            <th>Başlık</th>
                            <th>Konu</th>
                            <th>İmage Url</th>
                            <th>Kategori Adı</th>
                            <th>Dil</th>
                            <th>İşlem</th>
                           </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                             foreach (var item in Model)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 35 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 36 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 37 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 39 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                         if (((int)item.Language) == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\"Türkçe\"</td> \n");
#nullable restore
#line 42 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                            }
                                        else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\"İngilizce\";</td>\n");
#nullable restore
#line 46 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\n                                            ");
#nullable restore
#line 48 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                       Write(Html.ActionLink("Güncelle", "BlogUpdate", "Home", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 49 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                       Write(Html.ActionLink("Sil", "BlogDelete", "Home", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                </tr>\n");
#nullable restore
#line 52 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tbody>\n                  </table>\n                </div>\n            </div>\n");
#nullable restore
#line 58 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels.BlogModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
