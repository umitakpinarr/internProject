#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0143e5942afbdbb90cd73acb38daa5b0223fc502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Applicant), @"mvc.1.0.view", @"/Views/Job/Applicant.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0143e5942afbdbb90cd73acb38daa5b0223fc502", @"/Views/Job/Applicant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41a94d43e0c4d0eeb2a532b096286ad61bf5bb0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Applicant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belirtilmemiş", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Erkek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Kadın", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Job/Applicant"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
  
    ViewData["Title"] = Localizer.Get("job_breadcrumb_title");
    ViewData["BreadcrumbTitle"] = Localizer.Get("job_breadcrumb_title");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
 if (TempData["successMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 11 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
   Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 13 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
 if (TempData["dangerMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 17 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
   Write(TempData["dangerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 19 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"tools\">\n    <div class=\"container\">\n        <div class=\"t-row\">\n            <div class=\"d-table-cell\">\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 615, "\"", 737, 8);
            WriteAttributeValue("", 623, "margin-top:25px;", 623, 16, true);
            WriteAttributeValue(" ", 639, "margin-bottom:25px;", 640, 20, true);
            WriteAttributeValue(" ", 659, "background-color:", 660, 18, true);
#nullable restore
#line 25 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 677, ViewData["SiteColor"], 677, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 699, ";", 699, 1, true);
            WriteAttributeValue(" ", 700, "border-color:", 701, 14, true);
#nullable restore
#line 25 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 714, ViewData["SiteColor"], 714, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 736, ";", 736, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 738, "\"", 785, 2);
            WriteAttributeValue("", 745, "/", 745, 1, true);
#nullable restore
#line 25 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 746, Context.Request.RouteValues["culture"], 746, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 786, "\"", 830, 1);
#nullable restore
#line 25 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 794, Localizer.Get("job_applicant_back"), 794, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <span style=\"line-height: 12px; font-size: 20px;\">&#x2190;</span> ");
#nullable restore
#line 26 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                                                                 Write(Localizer.Get("job_applicant_back"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </a>\n            </div>\n        </div>\n    </div>\n</section>\n<div class=\"container shadow-sm p-3 mb--20 bg-body rounded\">\n    <div class=\"title text-center\">\n        <h1>");
#nullable restore
#line 34 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
       Write(Localizer.Get("job_applicant_title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p>\n            ");
#nullable restore
#line 36 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
       Write(Localizer.Get("job_applicant_desc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n    <div class=\"job-apply-form\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0143e5942afbdbb90cd73acb38daa5b0223fc50211357", async() => {
                WriteLiteral("\n            <input type=\"text\" name=\"jobId\" id=\"jobId\"");
                BeginWriteAttribute("value", " value=\"", 1440, "\"", 1460, 1);
#nullable restore
#line 41 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 1448, Model[0].Id, 1448, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Title\"><b>");
#nullable restore
#line 43 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                 Write(Localizer.Get("job_form_apply"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input type=\"text\" name=\"Title\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1688, "\"", 1714, 1);
#nullable restore
#line 44 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 1696, Model[0].JobTitle, 1696, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"FullName\"><b>");
#nullable restore
#line 47 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                     Write(Localizer.Get("job_form_fullname"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"FullName\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"Phone\"><b>");
#nullable restore
#line 51 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                  Write(Localizer.Get("job_form_phone"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"Phone\" class=\"form-control\" placeholder=\"05XXXXXXXXX\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"Email\"><b>");
#nullable restore
#line 55 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                  Write(Localizer.Get("job_form_email"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input type=\"email\" name=\"Email\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label for=\"Gender\"><b>");
#nullable restore
#line 59 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                  Write(Localizer.Get("job_form_gender"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <select name=\"Gender\" class=\"form-control\" required>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0143e5942afbdbb90cd73acb38daa5b0223fc50215047", async() => {
#nullable restore
#line 61 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0143e5942afbdbb90cd73acb38daa5b0223fc50216495", async() => {
#nullable restore
#line 62 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0143e5942afbdbb90cd73acb38daa5b0223fc50217955", async() => {
#nullable restore
#line 63 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0143e5942afbdbb90cd73acb38daa5b0223fc50219401", async() => {
#nullable restore
#line 64 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
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
                WriteLiteral("\n                </select>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"University\"><b>");
#nullable restore
#line 68 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                       Write(Localizer.Get("job_form_university"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"University\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"Faculty\"><b>");
#nullable restore
#line 72 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                    Write(Localizer.Get("job_form_faculty"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label>\n                <input name=\"Faculty\" class=\"form-control\" required>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <label name=\"Resume\"><b>");
#nullable restore
#line 76 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                   Write(Localizer.Get("job_form_resume"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></label>
                <textarea name=""Resume"" class=""form-control"" required></textarea>
            </div>
            <div class=""d-flex flex-lg-row"">
                <div class=""form-group mr-auto p-2"" style=""margin-bottom:10px;"">
                    <label for=""FormFile""><b>");
#nullable restore
#line 81 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
                                        Write(Localizer.Get("job_form_upload"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></label>
                    <input type=""file"" class=""form-control-file"" name=""FormFile"" accept=""application/pdf"" required>
                </div>
                <div class=""form-group p-2"" style=""margin-bottom:10px;"">
                    <img style=""display: inline-block; width: 180px; height: 50px; "" id=""imgCaptcha""");
                BeginWriteAttribute("src", " src=\"", 4376, "\"", 4439, 2);
                WriteAttributeValue("", 4382, "/argeya-captcha?", 4382, 16, true);
#nullable restore
#line 85 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 4398, DateTime.Now.ToString("ddMMyyyyHHmmsss"), 4398, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <a class=\"btn btn-sm small gray\"");
                BeginWriteAttribute("style", " style=\"", 4496, "\"", 4703, 19);
                WriteAttributeValue("", 4504, "display:", 4504, 8, true);
                WriteAttributeValue(" ", 4512, "inline-block;", 4513, 14, true);
                WriteAttributeValue(" ", 4526, "padding:", 4527, 9, true);
                WriteAttributeValue(" ", 4535, "8px;", 4536, 5, true);
                WriteAttributeValue(" ", 4540, "cursor:", 4541, 8, true);
                WriteAttributeValue(" ", 4548, "pointer;", 4549, 9, true);
                WriteAttributeValue(" ", 4557, "vertical-align:", 4558, 16, true);
                WriteAttributeValue(" ", 4573, "top;", 4574, 5, true);
                WriteAttributeValue(" ", 4578, "background-color:", 4579, 18, true);
#nullable restore
#line 86 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 4596, ViewData["SiteColor"], 4596, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4618, ";", 4618, 1, true);
                WriteAttributeValue(" ", 4619, "border-color:", 4620, 14, true);
#nullable restore
#line 86 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 4633, ViewData["SiteColor"], 4633, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4655, ";", 4655, 1, true);
                WriteAttributeValue(" ", 4656, "color:", 4657, 7, true);
                WriteAttributeValue(" ", 4663, "#fff", 4664, 5, true);
                WriteAttributeValue(" ", 4668, "!important;", 4669, 12, true);
                WriteAttributeValue(" ", 4680, "text-decoration:", 4681, 17, true);
                WriteAttributeValue(" ", 4697, "none;", 4698, 6, true);
                EndWriteAttribute();
                WriteLiteral(@" onclick=""var today = new Date(); document.getElementById('imgCaptcha').src = '/argeya-captcha?r=' + today; return false;"">
                        <i class=""fa fa-refresh"" aria-hidden=""true"" style=""font-size: 30px;""></i>
                    </a>
                    <input type=""text"" name=""captcha"" id=""captcha"" required />
                </div>
            </div>
            <div class=""container text-center"">
                <button type=""submit"" class=""btn btn-primary btn-lg active w-50""");
                BeginWriteAttribute("style", " style=\"", 5200, "\"", 5285, 6);
                WriteAttributeValue("", 5208, "background-color:", 5208, 17, true);
#nullable restore
#line 93 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 5225, ViewData["SiteColor"], 5225, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5247, ";", 5247, 1, true);
                WriteAttributeValue(" ", 5248, "border-color:", 5249, 14, true);
#nullable restore
#line 93 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Applicant.cshtml"
WriteAttributeValue("", 5262, ViewData["SiteColor"], 5262, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5284, ";", 5284, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Başvur</button>\n            </div>\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
