#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c28ccc812bf48e2fe1e3df0786e8694d85508772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28ccc812bf48e2fe1e3df0786e8694d85508772", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"toolbar-area hidden-md\"");
            BeginWriteAttribute("style", " style=\"", 56, "\"", 104, 3);
            WriteAttributeValue("", 64, "background:", 64, 11, true);
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue(" ", 75, Model.SiteColor, 76, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 92, "!important;", 93, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-5\">\n                <div class=\"toolbar-contact\">\n                    <ul>\n                        <li><i class=\"flaticon-email\"></i><a");
            BeginWriteAttribute("href", " href=\"", 327, "\"", 353, 2);
            WriteAttributeValue("", 334, "mailto:", 334, 7, true);
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 341, Model.Email, 341, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                        <li><i class=\"flaticon-call\"></i><a");
            BeginWriteAttribute("href", " href=\"", 436, "\"", 459, 2);
            WriteAttributeValue("", 443, "tel:", 443, 4, true);
#nullable restore
#line 9 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 447, Model.Phone, 447, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                    </ul>\n                </div>\n            </div>\n            <div class=\"col-md-7\">\n                <div class=\"toolbar-sl-share\">\n                    <ul>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 710, 1);
#nullable restore
#line 16 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 695, Model.Facebook, 695, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-facebook\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 828, 1);
#nullable restore
#line 17 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 812, Model.Instagram, 812, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-instagram\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 924, "\"", 945, 1);
#nullable restore
#line 18 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 931, Model.Twitter, 931, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fa-brands fa-twitter\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1061, 1);
#nullable restore
#line 19 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1046, Model.Linkedin, 1046, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank""><i class=""fa-brands fa-linkedin""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<header id=""rs-header"" class=""rs-header"">
    <div class=""menu-area menu-sticky"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8"">
                    <div class=""logo-area"">
                        <a href=""/""><img");
            BeginWriteAttribute("src", " src=\"", 1494, "\"", 1527, 2);
            WriteAttributeValue("", 1500, "/uploads/images/", 1500, 16, true);
#nullable restore
#line 32 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1516, Model.Logo, 1516, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""logo"" style=""max-height:40px; height:40px;""></a>
                    </div>
                </div>
                <div class=""col-lg-4 text-right"">
                    <div class=""rs-menu-area"">
                        <div class=""main-menu"">
                            <div class=""mobile-menu"">
                                <a class=""rs-menu-toggle""");
            BeginWriteAttribute("style", " style=\"", 1889, "\"", 1932, 3);
            WriteAttributeValue("", 1897, "color:", 1897, 6, true);
#nullable restore
#line 39 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue(" ", 1903, Model.SiteColor, 1904, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1920, "!important;", 1921, 12, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fa fa-bars""></i>
                                </a>
                            </div>
                            <nav class=""rs-menu pr-65"">
                                <ul class=""nav-menu"">
                                    <li>
                                        <a href=""/"">A????k Pozisyonlar</a>
                                    </li>
                                    <li>
                                        <a href=""/contact"">Bize Ula????n</a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SettingsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
