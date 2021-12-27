#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5f8b1d868b76f2e2fc5dcba08a23eb13a25ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Product), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5f8b1d868b76f2e2fc5dcba08a23eb13a25ecc", @"/Areas/Admin/Views/Home/Product.cshtml")]
    public class Areas_Admin_Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels.ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
   Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-header py-3\">\r\n            Ürün Tablosu\r\n            ");
#nullable restore
#line 9 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
       Write(Html.ActionLink("Ekle", "ProductCreate", "Home", null, new { @class = "btn btn-primary float-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 11 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
         if (Model.Count <= 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-center\">Hiç Veri Yok</p> ");
#nullable restore
#line 13 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
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
                    <th>Ad</th>
                    <th>Ürün</th>
                    <th>Image Url</th>
                    <th>Dil</th>
                    <th>Aktif</th>
                    <th>İşlem</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                   Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                     if (((int)item.Language) == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Türkçe\"</td>\r\n");
#nullable restore
#line 40 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"İngilizce\";</td>\r\n");
#nullable restore
#line 44 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                     if ((item.Active) == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Aktif\"</td> ");
#nullable restore
#line 47 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                                 }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\"Pasif\"</td>");
#nullable restore
#line 50 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 52 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                                       Write(Html.ActionLink("Güncelle", "ProductUpdate", "Home", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 53 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                                       Write(Html.ActionLink("Sil", "ProductDelete", "Home", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                                            </tr>");
#nullable restore
#line 55 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
#nullable restore
#line 60 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\Product.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
