#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15890a4c1ecb27ede458d7abad98ecedc0377428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Footer), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Footer.cshtml")]
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
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.Business.Abstracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\_ViewImports.cshtml"
using WebSiteBackend.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15890a4c1ecb27ede458d7abad98ecedc0377428", @"/Views/Shared/Components/Footer/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288eb7cd150c6fffb65bf68ba8b78299e034ea1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddressViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
  
    var culture = Context.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
    var displayname = culture.RequestCulture.UICulture.Name;
    var language = culture.RequestCulture.UICulture.Name == "en" ? 1 : 2;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<!-- Footer Start -->

<div class=""footer"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7"">
                <div class=""row"">
                    <div class=""col-md-8"">
                        <div class=""footer-contact"">
                            <h2>");
#nullable restore
#line 22 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                           Write(localizationService.GetByLanguage("Address", language).Result.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p><i class=\"fa fa-map-marker-alt\"></i>");
#nullable restore
#line 23 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                                                              Write(Html.Raw(Model.Address.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><i class=\"fa fa-phone-alt\"></i>");
#nullable restore
#line 24 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                                                         Write(Html.Raw(Model.Address.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><i class=\"fa fa-envelope\"></i>");
#nullable restore
#line 25 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                                                        Write(Html.Raw(Model.Address.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"footer-social\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1463, "\"", 1470, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1549, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1624, "\"", 1631, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-youtube\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1703, "\"", 1710, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1784, "\"", 1791, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-linkedin-in""></i></a>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </div>
    <div class=""copyright"">
        <div class=""container"">
            <p>");
#nullable restore
#line 43 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
          Write(localizationService.GetByLanguage("AllRights", language).Result.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &copy;  ");
#nullable restore
#line 43 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                                                                                         Write(Html.ActionLink("Smyrna Baklava", "Index", "Home", null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\cigdemayik\WebSiteBackend\WebSiteBackend.WebUI\Views\Shared\Components\Footer\Footer.cshtml"
                                                                                                                                                   Write(localizationService.GetByLanguage("Reserved", language).Result.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Footer End -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public WebSiteBackend.Business.Abstracts.Interfaces.ILocalizationResourceService localizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Builder.RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddressViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
