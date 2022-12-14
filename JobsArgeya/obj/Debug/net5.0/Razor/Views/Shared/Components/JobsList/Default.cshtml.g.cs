#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be5ddd87d428bb18b588f6a38b328cb8eafbb7c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be5ddd87d428bb18b588f6a38b328cb8eafbb7c", @"/Views/Shared/Components/JobsList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_JobsList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container shadow-sm p-3 mb-5 bg-body rounded"">
    <div class=""container"">
        <h2 style=""font-size:40px; margin-bottom:25px; margin-top:25px;"" class=""text-center"">Kendine Uygun Pozisyona Ba??vur</h2>
        <p style=""text-align:center; margin-top:20px; margin-bottom:20px;"">
            Geli??imin ve e??lencenin tad??n?? ayn?? anda ????karmak m??? Neden olmas??n? ??stedi??in Pozisyona m?? ba??vurmak istiyorsun?
            Kendi ba??ar?? hikayeni, ayn?? dili konu??tu??un bir ekiple birlikte yazmak ister misin?
            <strong>Hemen CV'ni ve ba??vuru formunu g??nder.</strong>
        </p>
        <div class=""row"">
            <div class=""col"">
                <div class=""text-center"">
                    <a href=""/job""");
            BeginWriteAttribute("style", " style=\"", 756, "\"", 859, 8);
            WriteAttributeValue("", 764, "vertical-align:", 764, 15, true);
            WriteAttributeValue(" ", 779, "middle;", 780, 8, true);
            WriteAttributeValue(" ", 787, "background:", 788, 12, true);
#nullable restore
#line 15 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 799, ViewData["SiteColor"], 799, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 821, ";", 821, 1, true);
            WriteAttributeValue(" ", 822, "border-color:", 823, 14, true);
#nullable restore
#line 15 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 836, ViewData["SiteColor"], 836, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 858, ";", 858, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-lg btn-primary active w-50"" title=""Hemen Ba??vur"">Hemen Ba??vur <i class=""fa-solid fa-link""></i></a>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container shadow-sm p-3 mb-5 bg-body rounded"">
    <div class=""container"">
        <h1 class=""text-center"" style=""font-size:40px; margin-bottom:25px; margin-top:25px;"">A????k Pozisyonlar</h1>
        <ul class=""responsive-table"">
            <table id=""anaEkran"" class=""table table-hover text-end"" style=""border-collapse:separate; border-spacing: 0 15px; "">
                <tbody>
");
#nullable restore
#line 28 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
                       if (Model != null)
                        {
                            foreach (JobsViewModel JobsVm in Model)
                            {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
             if (JobsVm.IsActive == "true")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td class=\"container border\" style=\"font-size:large; vertical-align:middle; font-weight:bold; text-align:left; padding:30px 50px 30px 50px\"><a class=\"text-body\"");
            BeginWriteAttribute("title", " title=\"", 1836, "\"", 1860, 1);
#nullable restore
#line 35 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 1844, JobsVm.JobTitle, 1844, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1900, 2);
            WriteAttributeValue("", 1868, "/jobdetail/index/", 1868, 17, true);
#nullable restore
#line 35 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 1885, JobsVm.JobSlug, 1885, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
                                                                                                                                                                                                                                 Write(JobsVm.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n    <td class=\"container border\" style=\"vertical-align:middle;\"><a");
            BeginWriteAttribute("href", " href=\"", 1994, "\"", 2033, 2);
            WriteAttributeValue("", 2001, "/jobdetail/index/", 2001, 17, true);
#nullable restore
#line 36 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 2018, JobsVm.JobSlug, 2018, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 2058, "\"", 2183, 9);
            WriteAttributeValue("", 2066, "float:right;", 2066, 12, true);
            WriteAttributeValue(" ", 2078, "align-items:center;", 2079, 20, true);
            WriteAttributeValue(" ", 2098, "width:125px;", 2099, 13, true);
            WriteAttributeValue(" ", 2111, "background:", 2112, 12, true);
#nullable restore
#line 36 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 2123, ViewData["SiteColor"], 2123, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2145, ";", 2145, 1, true);
            WriteAttributeValue(" ", 2146, "border-color:", 2147, 14, true);
#nullable restore
#line 36 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 2160, ViewData["SiteColor"], 2160, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2182, ";", 2182, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" data-bs-target=\"#demo\"");
            BeginWriteAttribute("title", " title=\"", 2221, "\"", 2245, 1);
#nullable restore
#line 36 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 2229, JobsVm.JobTitle, 2229, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??lan?? ??ncele <span style=\"line-height:12px; font-size:17px;\">&#x2192;</span></a></td>\n</tr> ");
#nullable restore
#line 37 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
        }
                                } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </ul>
    </div>
</div>

<div class=""container shadow-sm p-3 mb-5 bg-body rounded"">
    <div class=""container"">
        <h3 style=""font-size:40px; margin-bottom:25px; margin-top:25px;"" class=""text-center"">Stajyerlik Ba??vurusu</h3>
        <p style=""text-align:center; margin-top:20px; margin-bottom:20px;"">
            Hem geli??mek hem de ????renmek mi istiyorsun? Projeler geli??tirip kendini i?? hayat??na al????t??rmak m?? istiyorsun?
            ??n??nde m??kemmel duran bir f??rsat var.
            <strong class=""text-center""> Hemen staj ba??vurunu yap.</strong>
            Ayn?? dili konu??tu??un bu ekibin bir par??as?? ol.
        </p>
        <div class=""row"">
            <div class=""col"">
                <div class=""text-center"">
                    <a href=""/job/intern""");
            BeginWriteAttribute("style", " style=\"", 3199, "\"", 3302, 8);
            WriteAttributeValue("", 3207, "vertical-align:", 3207, 15, true);
            WriteAttributeValue(" ", 3222, "middle;", 3223, 8, true);
            WriteAttributeValue(" ", 3230, "background:", 3231, 12, true);
#nullable restore
#line 57 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 3242, ViewData["SiteColor"], 3242, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3264, ";", 3264, 1, true);
            WriteAttributeValue(" ", 3265, "border-color:", 3266, 14, true);
#nullable restore
#line 57 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Shared\Components\JobsList\Default.cshtml"
WriteAttributeValue("", 3279, ViewData["SiteColor"], 3279, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3301, ";", 3301, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-lg btn-primary w-50 rounded\" title=\"Hemen Ba??vur\">Staj Ba??vurunu Yap <i class=\"fa-solid fa-link\"></i></a>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
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
