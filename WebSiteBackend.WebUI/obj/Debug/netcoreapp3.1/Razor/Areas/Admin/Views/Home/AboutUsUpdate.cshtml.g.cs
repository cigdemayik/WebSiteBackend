#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1311273bc44f0df84d096f6d52226243e66d060b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_AboutUsUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/AboutUsUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1311273bc44f0df84d096f6d52226243e66d060b", @"/Areas/Admin/Views/Home/AboutUsUpdate.cshtml")]
    public class Areas_Admin_Views_Home_AboutUsUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels.AboutUsUpdateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
 using (Html.BeginForm("AboutUsUpdate","Home",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Hakkımızda\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"form-group row\">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 474, "\"", 491, 1);
#nullable restore
#line 16 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
WriteAttributeValue("", 482, Model.Id, 482, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 19 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
           Write(Html.LabelFor(m=>m.Content,new {@class="col-sm-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
           Write(Html.TextBoxFor(m=>m.Content,new {@class="form-control form-control-user col-sm-9"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
           Write(Html.ValidationMessageFor(m=>m.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
#nullable restore
#line 24 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
           Write(Html.LabelFor(m=>m.Language,new {@class="col-sm-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
           Write(Html.DropDownListFor(m=>((int)m.Language),new List<SelectListItem>{
                new SelectListItem {Text="Türkçe",Value="1"},
                new SelectListItem {Text="İngilizce",Value="2"}
            },new {@class="form-control form-control-user col-sm-9"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
       Write(Html.ValidationMessageFor(m=>((int)m.Language)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <input type=\"submit\" value=\"Güncelle\" class=\"btn btn-primary\"/>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\AboutUsUpdate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels.AboutUsUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591