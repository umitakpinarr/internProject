#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2cfa7c20ac1f85504cdabed913e12b50e55bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\_ViewImports.cshtml"
using JobsArgeya.Business;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2cfa7c20ac1f85504cdabed913e12b50e55bce", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41a94d43e0c4d0eeb2a532b096286ad61bf5bb0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belirtilmemiş", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Erkek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Kadın", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Job"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
  
    ViewData["Title"] = Localizer.Get("home_breadcrumb_title");
    ViewData["BreadcrumbTitle"] = Localizer.Get("job_breadcrumb_title");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
 if (TempData["successMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 10 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
   Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 12 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
 if (TempData["dangerMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 16 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
   Write(TempData["dangerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 18 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"tools\">\n    <div class=\"container\">\n        <div class=\"t-row\">\n            <div class=\"d-table-cell\">\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 606, "\"", 728, 8);
            WriteAttributeValue("", 614, "margin-top:25px;", 614, 16, true);
            WriteAttributeValue(" ", 630, "margin-bottom:25px;", 631, 20, true);
            WriteAttributeValue(" ", 650, "background-color:", 651, 18, true);
#nullable restore
#line 24 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 668, ViewData["SiteColor"], 668, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 690, ";", 690, 1, true);
            WriteAttributeValue(" ", 691, "border-color:", 692, 14, true);
#nullable restore
#line 24 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 705, ViewData["SiteColor"], 705, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 727, ";", 727, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 729, "\"", 776, 2);
            WriteAttributeValue("", 736, "/", 736, 1, true);
#nullable restore
#line 24 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 737, Context.Request.RouteValues["culture"], 737, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 777, "\"", 818, 1);
#nullable restore
#line 24 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 785, Localizer.Get("job_onlycv_back"), 785, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <span style=\"line-height: 12px; font-size: 20px;\">&#x2190;</span> ");
#nullable restore
#line 25 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                                                                 Write(Localizer.Get("job_onlycv_back"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </a>\n            </div>\n        </div>\n    </div>\n</section>\n<div class=\"container shadow-sm p-3 mb--20 bg-body rounded\">\n    <div class=\"title text-center\">\n        <h1>");
#nullable restore
#line 33 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
       Write(Localizer.Get("job_onlycv_title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p>\n            ");
#nullable restore
#line 35 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
       Write(Localizer.Get("job_onlycv_desc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n  \n    <div class=\"job-apply-form\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2cfa7c20ac1f85504cdabed913e12b50e55bce11222", async() => {
                WriteLiteral("\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"FullName\"><b>");
#nullable restore
#line 42 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                    Write(Localizer.Get("job_form_fullname"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"FullName\" id=\"FullName\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Phone\"><b>");
#nullable restore
#line 46 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                 Write(Localizer.Get("job_form_phone"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"Phone\" id=\"Phone\" class=\"form-control\" placeholder=\"05XXXXXXXXX\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Email\"><b>");
#nullable restore
#line 50 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                 Write(Localizer.Get("job_form_email"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input type=\"email\" name=\"Email\" id=\"Email\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Gender\"><b>");
#nullable restore
#line 54 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                  Write(Localizer.Get("job_form_gender"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <select name=\"Gender\" id=\"Gender\" class=\"form-control\" required>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2cfa7c20ac1f85504cdabed913e12b50e55bce13575", async() => {
#nullable restore
#line 56 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                Write(Localizer.Get("gender_nonselected"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2cfa7c20ac1f85504cdabed913e12b50e55bce15019", async() => {
#nullable restore
#line 57 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                             Write(Localizer.Get("gender_nonspecify"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2cfa7c20ac1f85504cdabed913e12b50e55bce16475", async() => {
#nullable restore
#line 58 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                     Write(Localizer.Get("gender_male"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2cfa7c20ac1f85504cdabed913e12b50e55bce17917", async() => {
#nullable restore
#line 59 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                     Write(Localizer.Get("gender_female"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </select>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"University\"><b>");
#nullable restore
#line 63 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                      Write(Localizer.Get("job_form_university"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"University\" id=\"University\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Faculty\"><b>");
#nullable restore
#line 67 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                   Write(Localizer.Get("job_form_faculty"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"Faculty\" id=\"Faculty\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Resume\"><b>");
#nullable restore
#line 71 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                  Write(Localizer.Get("job_form_resume"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></label>
                <textarea name=""Resume"" id=""Resume"" class=""form-control"" required></textarea>
            </div>
            <div class=""d-flex flex-row"">
                <div class=""form-group mr-auto p-2"" style=""margin-bottom:10px;"">
                    <label for=""FormFile""><b>");
#nullable restore
#line 76 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                        Write(Localizer.Get("job_form_upload"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></label>
                    <input type=""file"" name=""FormFile"" id=""FormFile"" class=""form-control-file"" accept=""application/pdf"" required>
                </div>
                <div class=""form-group p-2"" style=""margin-bottom:10px;"">
                    <img style=""display: inline-block; width: 180px; height: 50px; "" id=""imgCaptcha""");
                BeginWriteAttribute("src", " src=\"", 4083, "\"", 4146, 2);
                WriteAttributeValue("", 4089, "/argeya-captcha?", 4089, 16, true);
#nullable restore
#line 80 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 4105, DateTime.Now.ToString("ddMMyyyyHHmmsss"), 4105, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <a class=\"btn btn-sm small gray\"");
                BeginWriteAttribute("style", " style=\"", 4203, "\"", 4410, 19);
                WriteAttributeValue("", 4211, "display:", 4211, 8, true);
                WriteAttributeValue(" ", 4219, "inline-block;", 4220, 14, true);
                WriteAttributeValue(" ", 4233, "padding:", 4234, 9, true);
                WriteAttributeValue(" ", 4242, "8px;", 4243, 5, true);
                WriteAttributeValue(" ", 4247, "cursor:", 4248, 8, true);
                WriteAttributeValue(" ", 4255, "pointer;", 4256, 9, true);
                WriteAttributeValue(" ", 4264, "vertical-align:", 4265, 16, true);
                WriteAttributeValue(" ", 4280, "top;", 4281, 5, true);
                WriteAttributeValue(" ", 4285, "background-color:", 4286, 18, true);
#nullable restore
#line 81 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 4303, ViewData["SiteColor"], 4303, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4325, ";", 4325, 1, true);
                WriteAttributeValue(" ", 4326, "border-color:", 4327, 14, true);
#nullable restore
#line 81 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 4340, ViewData["SiteColor"], 4340, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4362, ";", 4362, 1, true);
                WriteAttributeValue(" ", 4363, "color:", 4364, 7, true);
                WriteAttributeValue(" ", 4370, "#fff", 4371, 5, true);
                WriteAttributeValue(" ", 4375, "!important;", 4376, 12, true);
                WriteAttributeValue(" ", 4387, "text-decoration:", 4388, 17, true);
                WriteAttributeValue(" ", 4404, "none;", 4405, 6, true);
                EndWriteAttribute();
                WriteLiteral(@" onclick=""var today = new Date(); document.getElementById('imgCaptcha').src = '/argeya-captcha?r=' + today; return false;"">
                        <i class=""fa fa-refresh"" aria-hidden=""true"" style=""font-size: 30px;""></i>
                    </a>
                    <input type=""text"" name=""captcha"" id=""captcha"" required />
                </div>
            </div>
            <div class=""container text-center"">
                <button type=""submit"" class=""btn btn-primary btn-lg active w-75""");
                BeginWriteAttribute("style", " style=\"", 4907, "\"", 4992, 6);
                WriteAttributeValue("", 4915, "background-color:", 4915, 17, true);
#nullable restore
#line 88 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 4932, ViewData["SiteColor"], 4932, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4954, ";", 4954, 1, true);
                WriteAttributeValue(" ", 4955, "border-color:", 4956, 14, true);
#nullable restore
#line 88 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
WriteAttributeValue("", 4969, ViewData["SiteColor"], 4969, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4991, ";", 4991, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Index.cshtml"
                                                                                                                                                                  Write(Localizer.Get("job_onlycv_submit"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
