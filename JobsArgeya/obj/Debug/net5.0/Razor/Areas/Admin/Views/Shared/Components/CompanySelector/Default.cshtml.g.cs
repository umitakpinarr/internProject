#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\CompanySelector\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22612b34a81f395752303884371915ec42758ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_CompanySelector_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/CompanySelector/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22612b34a81f395752303884371915ec42758ee", @"/Areas/Admin/Views/Shared/Components/CompanySelector/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e132fafa218d2fa3e61abc3075a7a88ecf0a1023", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_CompanySelector_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CompanyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""dropdown"" style=""vertical-align:center;"">
    <button class=""btn btn-light dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        Şirket Seç
    </button>
    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
");
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\CompanySelector\Default.cshtml"
         foreach (CompanyViewModel Model in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 442, "\"", 476, 2);
            WriteAttributeValue("", 449, "/admin/home/index/", 449, 18, true);
#nullable restore
#line 10 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\CompanySelector\Default.cshtml"
WriteAttributeValue("", 467, Model.Id, 467, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\CompanySelector\Default.cshtml"
                                                                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 11 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Shared\Components\CompanySelector\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591