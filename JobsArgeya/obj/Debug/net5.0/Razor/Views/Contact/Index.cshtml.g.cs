#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d998fc31ce690889d1c01602a35ce78f8784e9ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d998fc31ce690889d1c01602a35ce78f8784e9ab", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818629c6ef42b152e17f9394f18714f552c98264", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Bize Ula????n";
    ViewData["BreadcrumbTitle"] = "Bize Ula????n";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
 if (TempData["successMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 9 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
   Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 11 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
 if (TempData["dangerMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 15 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
   Write(TempData["dangerMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 17 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"text-center\">\n        <h3>Bizimle ??leti??ime Ge??in</h3>\n    </div>\n    <div class=\"form-box pl-2\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d998fc31ce690889d1c01602a35ce78f8784e9ab6260", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""Name"">Ad??n??z *</label>
                <input class=""form-control"" id=""Name"" name=""Name"" type=""text"" required>
            </div>
            <div class=""form-group"">
                <label for=""Email"">E-Posta Adresiniz *</label>
                <input class=""form-control"" id=""Email"" name=""Email"" type=""email"" required>
            </div>
            <div class=""form-group"">
                <label for=""Phone"">Telefon Numaran??z *</label>
                <input class=""form-control"" id=""Phone"" name=""Phone"" type=""text"" placeholder=""05XXXXXXXXX"" required>
            </div>
            <div class=""form-group"">
                <label for=""Subject"">Konu *</label>
                <input class=""form-control"" id=""Subject"" name=""Subject"" type=""text"" required>
            </div>
            <div class=""form-group"">
                <label for=""Message"">Mesaj??n??z *</label>
                <textarea class=""form-control"" id=""Message"" name=""Message"" required></t");
                WriteLiteral("extarea>\n            </div>\n            <div class=\"form-group\" style=\"margin-bottom:10px;\">\n                <img style=\"display: inline-block; width: 180px; height: 50px; \" id=\"imgCaptcha\"");
                BeginWriteAttribute("src", " src=\"", 1776, "\"", 1839, 2);
                WriteAttributeValue("", 1782, "/argeya-captcha?", 1782, 16, true);
#nullable restore
#line 47 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1798, DateTime.Now.ToString("ddMMyyyyHHmmsss"), 1798, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                <a class=\"btn btn-sm small gray\"");
                BeginWriteAttribute("style", " style=\"", 1892, "\"", 2099, 19);
                WriteAttributeValue("", 1900, "display:", 1900, 8, true);
                WriteAttributeValue(" ", 1908, "inline-block;", 1909, 14, true);
                WriteAttributeValue(" ", 1922, "padding:", 1923, 9, true);
                WriteAttributeValue(" ", 1931, "8px;", 1932, 5, true);
                WriteAttributeValue(" ", 1936, "cursor:", 1937, 8, true);
                WriteAttributeValue(" ", 1944, "pointer;", 1945, 9, true);
                WriteAttributeValue(" ", 1953, "vertical-align:", 1954, 16, true);
                WriteAttributeValue(" ", 1969, "top;", 1970, 5, true);
                WriteAttributeValue(" ", 1974, "background-color:", 1975, 18, true);
#nullable restore
#line 48 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1992, ViewData["SiteColor"], 1992, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2014, ";", 2014, 1, true);
                WriteAttributeValue(" ", 2015, "border-color:", 2016, 14, true);
#nullable restore
#line 48 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2029, ViewData["SiteColor"], 2029, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2051, ";", 2051, 1, true);
                WriteAttributeValue(" ", 2052, "color:", 2053, 7, true);
                WriteAttributeValue(" ", 2059, "#fff", 2060, 5, true);
                WriteAttributeValue(" ", 2064, "!important;", 2065, 12, true);
                WriteAttributeValue(" ", 2076, "text-decoration:", 2077, 17, true);
                WriteAttributeValue(" ", 2093, "none;", 2094, 6, true);
                EndWriteAttribute();
                WriteLiteral(@" onclick=""var today = new Date(); document.getElementById('imgCaptcha').src = '/argeya-captcha?r=' + today; return false;"">
                    <i class=""fa fa-refresh"" aria-hidden=""true"" style=""font-size: 30px;""></i>
                </a>
                <input type=""text"" name=""captcha"" id=""captcha"" required/>
            </div>
            <div class=""container align-items-center"">
                <input class=""btn btn-primary btn-block btn-lg active w-50""");
                BeginWriteAttribute("style", " style=\"", 2562, "\"", 2647, 6);
                WriteAttributeValue("", 2570, "background-color:", 2570, 17, true);
#nullable restore
#line 54 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2587, ViewData["SiteColor"], 2587, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2609, ";", 2609, 1, true);
                WriteAttributeValue(" ", 2610, "border-color:", 2611, 14, true);
#nullable restore
#line 54 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2624, ViewData["SiteColor"], 2624, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2646, ";", 2646, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" value=\"G??nder\" />\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
