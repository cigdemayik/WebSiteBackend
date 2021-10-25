#pragma checksum "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac137d167f6deaec77c460ff2a2c9d280e3b5eb6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac137d167f6deaec77c460ff2a2c9d280e3b5eb6", @"/Areas/Admin/Views/Home/Blog.cshtml")]
    public class Areas_Admin_Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels.BlogModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
       Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n\r\n        <div class=\"card shadow mb-4\">\r\n            <div class=\"card-header py-3\">\r\n                Blog Tablosu\r\n                ");
#nullable restore
#line 9 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
           Write(Html.ActionLink("Ekle", "BlogCreate", "Home", null, new { @class = "btn btn-primary float-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 11 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                 if (Model.Count <= 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-center\">Hiç Veri Yok</p>\r\n");
#nullable restore
#line 14 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
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
#line 31 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                             foreach (var item in Model)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 34 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 35 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 39 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                         if (((int)item.Language) == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\"Türkçe\"</td> \r\n");
#nullable restore
#line 42 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                            }
                                        else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\"İngilizce\";</td>\r\n");
#nullable restore
#line 46 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 48 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                       Write(Html.ActionLink("Güncelle", "BlogUpdate", "Home", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 49 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                       Write(Html.ActionLink("Sil", "BlogDelete", "Home", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                  </table>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 58 "D:\SideProjects\WebSite\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Blog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels.BlogModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
