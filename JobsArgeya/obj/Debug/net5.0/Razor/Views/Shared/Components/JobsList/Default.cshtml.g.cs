#pragma checksum "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4dcbe9a91cd0b75363c52e4679ef8f5dfff8c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_JobsList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/JobsList/Default.cshtml")]
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
#line 1 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4dcbe9a91cd0b75363c52e4679ef8f5dfff8c1e", @"/Views/Shared/Components/JobsList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_JobsList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
   

    <div class=""container shadow-sm p-3 mb-5 bg-body rounded"">
        <div class=""container"">
            <h1 style=""font-size:40px; margin-bottom:25px; margin-top:25px;"">Açık Pozisyonlar</h1>
            <ul class=""responsive-table"">
                <table id=""anaEkran"" class=""table table-hover text-end"" style=""border-collapse:separate; border-spacing: 0 15px; "">
                    <tbody>
");
#nullable restore
#line 11 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
                           if (Model != null)
                            {
                                foreach (JobsViewModel jobsVm in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td class=\"container border\" style=\"font-size:large; vertical-align:middle; font-weight:bold; text-align:left; padding:30px 50px 30px 50px\"><a class=\"text-body\"");
            BeginWriteAttribute("title", " title=\"", 852, "\"", 876, 1);
#nullable restore
#line 16 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 860, jobsVm.jobTitle, 860, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 877, "\"", 916, 2);
            WriteAttributeValue("", 884, "/jobdetail/index/", 884, 17, true);
#nullable restore
#line 16 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 901, jobsVm.jobSlug, 901, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
                                                                                                                                                                                                                                                                     Write(jobsVm.jobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                                        <td class=\"container border\" style=\"vertical-align:middle;\"><a");
            BeginWriteAttribute("href", " href=\"", 1046, "\"", 1085, 2);
            WriteAttributeValue("", 1053, "/jobdetail/index/", 1053, 17, true);
#nullable restore
#line 17 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 1070, jobsVm.jobSlug, 1070, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"float:right; align-items:center; width:125px;\" type=\"button\" data-bs-target=\"#demo\">İlanı İncele <span style=\"line-height:12px; font-size:17px;\">&#x2192;</span></a></td>\n                                    </tr>\n");
#nullable restore
#line 19 "C:\Users\Freeman\Desktop\internPorject-main\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </ul>\n        </div>\n    </div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
