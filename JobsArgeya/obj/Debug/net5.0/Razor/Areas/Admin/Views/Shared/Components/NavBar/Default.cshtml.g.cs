#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\NavBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193639ca03b4b85d5fe637a136f5842873377da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_NavBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/NavBar/Default.cshtml")]
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
#line 1 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya.Business;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193639ca03b4b85d5fe637a136f5842873377da3", @"/Areas/Admin/Views/Shared/Components/NavBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29c4efeca20d05fa780116077cc9b21592b6f26", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_NavBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/panel/assets/images/logo-dark.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/panel/assets/images/logo_sm_dark.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"leftside-menu\">\r\n\r\n    <!-- LOGO -->\r\n    <a href=\"/admin/home/index\" class=\"logo text-center logo-light\">\r\n        <span class=\"logo-lg\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "193639ca03b4b85d5fe637a136f5842873377da35371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 174, "~/uploads/", 174, 10, true);
#nullable restore
#line 6 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\NavBar\Default.cshtml"
AddHtmlAttributeValue("", 184, ViewData["DarkLogo"], 184, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n    </a>\r\n\r\n    <!-- LOGO -->\r\n    <a href=\"/admin/home/index\" class=\"logo text-center logo-dark\">\r\n        <span class=\"logo-lg\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "193639ca03b4b85d5fe637a136f5842873377da37247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n        <span class=\"logo-sm\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "193639ca03b4b85d5fe637a136f5842873377da38511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </span>
    </a>

    <div class=""h-100"" id=""leftside-menu-container"" data-simplebar>

        <!--- Sidemenu -->
        <ul class=""side-nav"">

            <li class=""side-nav-title side-nav-item""></li>

            <li class=""side-nav-item"">
                <a href=""/admin/home/index"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-clipboard""></i>
                    <span>Başvurular</span>
                </a>
                <a href=""/admin/jobs/add"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""uil-focus-add""></i>
                    <span>İlan Ekle</span>
                </a>
                <a href=""/admin/jobs/list"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-clipboard""></i>
                    <span>İlanları Görüntüle</span>
                </a>
                <");
            WriteLiteral(@"a href=""/admin/mail/index"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-mail""></i>
                    <span>Mail Listesi</span>
                </a>
                <a href=""/admin/mail/send"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-mail""></i>
                    <span>Mail Listesine Gönder</span>
                </a>
                <a href=""/admin/contact/index"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-mail""></i>
                    <span>İletişim Formu</span>
                </a>
");
#nullable restore
#line 52 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\NavBar\Default.cshtml"
                 if (User.IsInRole("SuperAdmin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <a href=""/admin/user/index"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                        <i class=""dripicons-network-3""></i>
                        <span>Kullanıcı İşlemleri</span>
                    </a>
                    <a href=""/admin/company/index"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                        <i class=""dripicons-network-3""></i>
                        <span>Şirket İşlemleri</span>
                    </a>
");
#nullable restore
#line 62 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\NavBar\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <a href=""/admin/settings/"" aria-expanded=""false"" aria-controls=""sidebarDashboards"" class=""side-nav-link"">
                    <i class=""dripicons-gear""></i>
                    <span>Site Ayarları</span>
                </a>
            </li>
        </ul>
    </div>
    <!-- Sidebar -left -->

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
