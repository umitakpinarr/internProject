#pragma checksum "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd175be36c490874c6829fe8535a3e32e4f31297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Settings_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Settings/Index.cshtml")]
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
#line 1 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\_ViewImports.cshtml"
using JobsArgeya.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd175be36c490874c6829fe8535a3e32e4f31297", @"/Areas/Admin/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864cd4fa63cb508dd8a94d2e9ea03189cdcd0b59", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SettingsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/settings/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd175be36c490874c6829fe8535a3e32e4f312974897", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\" style=\"margin-bottom:10px;\">\r\n                    <label for=\"title\">Site Başlığı</label>\r\n                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 485, 1);
#nullable restore
#line 11 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 470, Model[0].title, 470, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""title"" id=""title"" placeholder=""Site Başlığı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""keywords"">Site Anahtar Kelimeleri</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 768, "\"", 794, 1);
#nullable restore
#line 15 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 776, Model[0].keywords, 776, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"" id=""keywords"" placeholder=""Site Anahtar Kelime"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""description"">Site Açıklama</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1112, 1);
#nullable restore
#line 19 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1091, Model[0].description, 1091, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""description"" id=""description"" placeholder=""Site Açıklama"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""phone"">Telefon</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1389, "\"", 1412, 1);
#nullable restore
#line 23 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1397, Model[0].email, 1397, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""phone"" id=""phone"" placeholder=""Telefon"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""jobDescription"">E-Mail</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1679, "\"", 1702, 1);
#nullable restore
#line 27 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1687, Model[0].phone, 1687, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"email\" id=\"email\" placeholder=\"Email\">\r\n                </div>\r\n                <div class=\"form-group\" style=\"margin-bottom:10px;\">\r\n                    <label for=\"adress\">Adres</label>\r\n                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1958, "\"", 1982, 1);
#nullable restore
#line 31 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1966, Model[0].adress, 1966, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""adress"" id=""adress"" placeholder=""Adres"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""facebook"">Facebook Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2252, "\"", 2278, 1);
#nullable restore
#line 35 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2260, Model[0].facebook, 2260, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""facebook"" id=""facebook"" placeholder=""Facebook Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""instagram"">Instagram Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2564, "\"", 2591, 1);
#nullable restore
#line 39 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2572, Model[0].instagram, 2572, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""instagram"" id=""instagram"" placeholder=""Instagram Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""twitter"">Twitter Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2876, "\"", 2901, 1);
#nullable restore
#line 43 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2884, Model[0].twitter, 2884, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""twitter"" id=""twitter"" placeholder=""Twitter Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""linkedin"">Linkedin Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3182, "\"", 3208, 1);
#nullable restore
#line 47 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3190, Model[0].linkedin, 3190, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""linkedin"" id=""linkedin"" placeholder=""Linkedin Adresi"">
                </div>
                <hr />
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpServer"">SMTP Sunucusu</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3516, "\"", 3544, 1);
#nullable restore
#line 52 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3524, Model[0].smtpServer, 3524, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""smtpServer"" id=""smtpServer"" placeholder=""SMTP Sunucusu"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpUsername"">SMTP Kullanıcı Adı</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3837, "\"", 3867, 1);
#nullable restore
#line 56 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3845, Model[0].smtpUsername, 3845, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""smtpUsername"" id=""smtpUsername"" placeholder=""SMTP Kullanıcı Adı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpPassword"">SMTP Şifresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4163, "\"", 4193, 1);
#nullable restore
#line 60 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 4171, Model[0].smtpPassword, 4171, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""smtpPassword"" id=""smtpPassword"" placeholder=""SMTP Şifresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpPort"">SMTP Port</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4476, "\"", 4502, 1);
#nullable restore
#line 64 "C:\Users\Freeman\source\repos\JobsArgeya\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 4484, Model[0].smtpPort, 4484, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""smtpPort"" id=""smtpPort"" placeholder=""SMTP Port"">
                </div>
                <hr />
                <div class=""form-group"">
                    <label for=""logo"">Site Logo</label>
                    <input type=""file"" class=""form-control-file"" id=""logo"" name=""logo"">
                </div>
                <br />
                <button type=""submit"" class=""btn btn-danger w-100"">Ayarları Kaydet</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SettingsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
