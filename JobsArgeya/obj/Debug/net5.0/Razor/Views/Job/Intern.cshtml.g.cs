#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Intern), @"mvc.1.0.view", @"/Views/Job/Intern.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb071", @"/Views/Job/Intern.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Intern : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Belirtilmemi??", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Erkek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Kad??n", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Job/Intern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
  
    ViewData["Title"] = "Stajyerlik Ba??vurusu";
    ViewData["BreadcrumbTitle"] = "Stajyerlik Ba??vurusu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
 if (TempData["successMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 10 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
   Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 12 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
 if (TempData["dangerMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 16 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
   Write(TempData["dangerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 18 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"" integrity=""sha512-aOG0c6nPNzGk+5zjwyJaoRUgCdOrfSDhmMID2u4+OIslr0GjpLKo7Xm0Ao3xmpM4T8AmIouRkqwj1nrdVsLKEQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
            }
            );
            WriteLiteral("\n<section class=\"tools\">\n    <div class=\"container\">\n        <div class=\"t-row\">\n            <div class=\"d-table-cell\">\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("style", " style=\"", 866, "\"", 988, 8);
            WriteAttributeValue("", 874, "margin-top:25px;", 874, 16, true);
            WriteAttributeValue(" ", 890, "margin-bottom:25px;", 891, 20, true);
            WriteAttributeValue(" ", 910, "background-color:", 911, 18, true);
#nullable restore
#line 27 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 928, ViewData["SiteColor"], 928, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 950, ";", 950, 1, true);
            WriteAttributeValue(" ", 951, "border-color:", 952, 14, true);
#nullable restore
#line 27 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 965, ViewData["SiteColor"], 965, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 987, ";", 987, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" href=""/"" title=""Geri"">
                    <span style=""line-height: 12px; font-size: 20px;"">&#x2190;</span> Geri Git
                </a>
            </div>
        </div>
    </div>
</section>
<div class=""container shadow-sm mb--5 p-3 rounded bg-body"">
    <div class=""title text-center"">
        <h1>Ba??vuru Formu</h1>
        <p>
            Hem geli??mek hem de ????renmek mi istiyorsun? Projeler geli??tirip kendini i?? hayat??na al????t??rmak m?? istiyorsun?
            <br />??n??nde m??kemmel duran bir f??rsat var.
        </p>
    </div>
    <div class=""job-apply-form"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb0719993", async() => {
                WriteLiteral(@"
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""FullName""><b>Ad??n??z ve Soyd??n??z: *</b></label>
                <input name=""FullName"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Phone""><b>Telefon Numaran??z: *</b></label>
                <input name=""Phone"" class=""form-control"" required placeholder=""05XXXXXXXXX"">
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Email""><b>E-Mail Adresiniz: *</b></label>
                <input type=""email"" name=""Email"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label><b>Cinsiyetiniz *</b></label>
                <select name=""Gender"" class=""form-control"" required>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb07111212", async() => {
                    WriteLiteral("L??tfen Bir Se??im Yap??n??z!");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb07112473", async() => {
                    WriteLiteral("Belirtmek ??stemiyorum");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb07113730", async() => {
                    WriteLiteral("Erkek");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95cf5fff6dbd46b4d1c1f975a5dfe955c7fbb07114971", async() => {
                    WriteLiteral("Kad??n");
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
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""University""><b>Okudu??unuz Okul: *</b></label>
                <input name=""University"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Faculty""><b>Okudu??unuz B??l??m ve S??n??f: *</b></label>
                <input name=""Faculty"" class=""form-control"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label for=""InternStartDate""><b>Staj Ba??lang???? Tarihi: *</b></label>
                <input class=""form-control"" id=""InternStartDate"" name=""InternStartDate"" autocomplete=""off"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label for=""InternEndDate""><b>Staj Biti?? Tarihi: *</b></label>
                <input class=""form-control"" id=""InternEndDate"" name=""InternEndDate");
                WriteLiteral(@""" autocomplete=""off"" required>
            </div>
            <div class=""form-group"" style=""margin-bottom:10px;"">
                <label name=""Resume""><b>??z Yaz??: *</b></label>
                <textarea name=""Resume"" class=""form-control"" required></textarea>
            </div>
            <div class=""d-flex flex-row"">
                <div class=""form-group mr-auto p-2"" style=""margin-bottom:10px;"">
                    <label for=""FormFile""><b>??zge??mi?? / CV Y??kle (Sadece PDF uzant??l?? dosyalar kabul edilmektedir) *</b></label>
                    <input type=""file"" class=""form-control-file"" name=""FormFile"" accept=""application/pdf"" required>
                </div>
                <div class=""form-group p-2"" style=""margin-bottom:10px;"">
                    <img style=""display: inline-block; width: 180px; height: 50px; "" id=""imgCaptcha""");
                BeginWriteAttribute("src", " src=\"", 4673, "\"", 4736, 2);
                WriteAttributeValue("", 4679, "/argeya-captcha?", 4679, 16, true);
#nullable restore
#line 91 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4695, DateTime.Now.ToString("ddMMyyyyHHmmsss"), 4695, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <a class=\"btn btn-sm small gray\"");
                BeginWriteAttribute("style", " style=\"", 4793, "\"", 5000, 19);
                WriteAttributeValue("", 4801, "display:", 4801, 8, true);
                WriteAttributeValue(" ", 4809, "inline-block;", 4810, 14, true);
                WriteAttributeValue(" ", 4823, "padding:", 4824, 9, true);
                WriteAttributeValue(" ", 4832, "8px;", 4833, 5, true);
                WriteAttributeValue(" ", 4837, "cursor:", 4838, 8, true);
                WriteAttributeValue(" ", 4845, "pointer;", 4846, 9, true);
                WriteAttributeValue(" ", 4854, "vertical-align:", 4855, 16, true);
                WriteAttributeValue(" ", 4870, "top;", 4871, 5, true);
                WriteAttributeValue(" ", 4875, "background-color:", 4876, 18, true);
#nullable restore
#line 92 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4893, ViewData["SiteColor"], 4893, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4915, ";", 4915, 1, true);
                WriteAttributeValue(" ", 4916, "border-color:", 4917, 14, true);
#nullable restore
#line 92 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 4930, ViewData["SiteColor"], 4930, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4952, ";", 4952, 1, true);
                WriteAttributeValue(" ", 4953, "color:", 4954, 7, true);
                WriteAttributeValue(" ", 4960, "#fff", 4961, 5, true);
                WriteAttributeValue(" ", 4965, "!important;", 4966, 12, true);
                WriteAttributeValue(" ", 4977, "text-decoration:", 4978, 17, true);
                WriteAttributeValue(" ", 4994, "none;", 4995, 6, true);
                EndWriteAttribute();
                WriteLiteral(@" onclick=""var today = new Date(); document.getElementById('imgCaptcha').src = '/argeya-captcha?r=' + today; return false;"">
                        <i class=""fa fa-refresh"" aria-hidden=""true"" style=""font-size: 30px;""></i>
                    </a>
                    <input type=""text"" name=""captcha"" id=""captcha"" required />
                </div>
            </div>
            <div class=""container text-center"">
                <button type=""submit"" class=""btn btn-primary btn-lg active w-50""");
                BeginWriteAttribute("style", " style=\"", 5497, "\"", 5582, 6);
                WriteAttributeValue("", 5505, "background-color:", 5505, 17, true);
#nullable restore
#line 99 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 5522, ViewData["SiteColor"], 5522, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5544, ";", 5544, 1, true);
                WriteAttributeValue(" ", 5545, "border-color:", 5546, 14, true);
#nullable restore
#line 99 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Job\Intern.cshtml"
WriteAttributeValue("", 5559, ViewData["SiteColor"], 5559, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5581, ";", 5581, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Ba??vur</button>\n            </div>\n        ");
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
            WriteLiteral("\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"" integrity=""sha512-uto9mlQzrs59VwILcLiRYeLKPPbS/bT71da/OEBYEwcdNUk8jYIy+D176RYoop1Da+f9mvkYrmj5MCLZWEtQuA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script>
        $(document).ready(function () {

            $(function () {
                $(""#InternStartDate"").datepicker({
                    minDate: 0,
                    dateFormat: 'dd.mm.yy',
                    monthNames: [""Ocak"", ""??ubat"", ""Mart"", ""Nisan"", ""May??s"", ""Haziran"", ""Temmuz"", ""A??ustos"", ""Eyl??l"", ""Ekim"", ""Kas??m"", ""Aral??k""],
                    dayNamesMin: [""Pa"", ""Pt"", ""Sl"", ""??a"", ""Pe"", ""Cu"", ""Ct""]
                });
                $(""#InternEndDate"").datepicker({
                    minDate: 0,
                    dateFormat: 'dd.mm.yy',
                    monthNa");
                WriteLiteral(@"mes: [""Ocak"", ""??ubat"", ""Mart"", ""Nisan"", ""May??s"", ""Haziran"", ""Temmuz"", ""A??ustos"", ""Eyl??l"", ""Ekim"", ""Kas??m"", ""Aral??k""],
                    dayNamesMin: [""Pa"", ""Pt"", ""Sl"", ""??a"", ""Pe"", ""Cu"", ""Ct""]
                });

                $('#InternStartDate').change(function () {
                    startDate = $(this).datepicker('getDate');
                    $(""#internEndDate"").datepicker(""option"", ""minDate"", startDate);
                });
                $('#InternEndDate').change(function () {
                    endDate = $(this).datepicker('getDate');
                    $(""#internStartDate"").datepicker(""option"", ""maxDate"", endDate);
                });
            });
        })
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
