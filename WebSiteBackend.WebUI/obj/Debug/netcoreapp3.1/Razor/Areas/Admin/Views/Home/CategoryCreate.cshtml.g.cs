#pragma checksum "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e2ef1cb63da8deed2ec9d46720a5b680e752cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_CategoryCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/CategoryCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e2ef1cb63da8deed2ec9d46720a5b680e752cc", @"/Areas/Admin/Views/Home/CategoryCreate.cshtml")]
    public class Areas_Admin_Views_Home_CategoryCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels.CategoryCreateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
 using (Html.BeginForm("CategoryCreate","Home",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-header\">\n            Kategori\n        </div>\n        <div class=\"card-body\">\n            \n            <div class=\"form-group\">\n                ");
#nullable restore
#line 17 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
           Write(Html.TextBoxFor(m=>m.Name,new {@class="form-control form-control-user"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 18 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
           Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 21 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
           Write(Html.DropDownListFor(m=>m.Language,new List<SelectListItem>{
                new SelectListItem {Text="Türkçe",Value="1"},
                new SelectListItem {Text="İngilizce",Value="2"}
            },new {@class="form-control form-control-user"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 25 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <input type=\"submit\" value=\"Kaydet\" class=\"btn btn-primary\"/>\n        </div>\n    </div>\n");
#nullable restore
#line 30 "C:\Users\ÇİĞDEM\Source\Repos\WebSiteBackend-main\WebSiteBackend.WebUI\Areas\Admin\Views\Home\CategoryCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels.CategoryCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
