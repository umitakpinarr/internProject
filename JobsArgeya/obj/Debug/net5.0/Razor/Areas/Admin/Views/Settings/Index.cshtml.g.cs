#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518a0cffac457cba5d2fb016e3a0397df5cac755"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518a0cffac457cba5d2fb016e3a0397df5cac755", @"/Areas/Admin/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29c4efeca20d05fa780116077cc9b21592b6f26", @"/Areas/Admin/Views/_ViewImports.cshtml")]
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
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["CmsTitle"] = "Site Ayarları";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-colorpicker/3.4.0/css/bootstrap-colorpicker.css"" integrity=""sha512-HcfKB3Y0Dvf+k1XOwAD6d0LXRFpCnwsapllBQIvvLtO2KMTa0nI5MtuTv3DuawpsiA0ztTeu690DnMux/SuXJQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
            }
            );
            WriteLiteral("<div class=\"col-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "518a0cffac457cba5d2fb016e3a0397df5cac7555649", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\" style=\"margin-bottom:10px;\">\r\n                    <label for=\"title\">Site Başlığı</label>\r\n                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 825, "\"", 848, 1);
#nullable restore
#line 15 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 833, Model[0].Title, 833, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Title"" id=""Title"" placeholder=""Site Başlığı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""keywords"">Site Anahtar Kelimeleri</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1131, "\"", 1157, 1);
#nullable restore
#line 19 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1139, Model[0].Keywords, 1139, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Keywords"" id=""Keywords"" placeholder=""Site Anahtar Kelime"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""description"">Site Açıklama</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1446, "\"", 1475, 1);
#nullable restore
#line 23 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1454, Model[0].Description, 1454, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Description"" id=""Description"" placeholder=""Site Açıklama"">
                </div>
                <hr />
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""siteColor"">Site Renk</label>
                    <input id=""siteColor"" name=""SiteColor"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1814, "\"", 1841, 1);
#nullable restore
#line 28 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 1822, Model[0].SiteColor, 1822, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <hr />\r\n                <div class=\"form-group\" style=\"margin-bottom:10px;\">\r\n                    <label for=\"phone\">Email</label>\r\n                    <input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2078, "\"", 2101, 1);
#nullable restore
#line 33 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2086, Model[0].Email, 2086, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Email"" id=""Email"" placeholder=""Email"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""jobDescription"">Telefon</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2367, "\"", 2390, 1);
#nullable restore
#line 37 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2375, Model[0].Phone, 2375, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Phone"" id=""Phone"" placeholder=""Telefon"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""adress"">Adres</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2648, "\"", 2672, 1);
#nullable restore
#line 41 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2656, Model[0].Adress, 2656, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Adress"" id=""Adress"" placeholder=""Adres"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""facebook"">Facebook Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2942, "\"", 2968, 1);
#nullable restore
#line 45 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 2950, Model[0].Facebook, 2950, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Facebook"" id=""Facebook"" placeholder=""Facebook Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""instagram"">Instagram Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3254, "\"", 3281, 1);
#nullable restore
#line 49 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3262, Model[0].Instagram, 3262, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Instagram"" id=""Instagram"" placeholder=""Instagram Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""twitter"">Twitter Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3566, "\"", 3591, 1);
#nullable restore
#line 53 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3574, Model[0].Twitter, 3574, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Twitter"" id=""Twitter"" placeholder=""Twitter Adresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""linkedin"">Linkedin Adresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 3872, "\"", 3898, 1);
#nullable restore
#line 57 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 3880, Model[0].Linkedin, 3880, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Linkedin"" id=""Linkedin"" placeholder=""Linkedin Adresi"">
                </div>
                <hr />
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpServer"">SMTP Sunucusu</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4206, "\"", 4234, 1);
#nullable restore
#line 62 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 4214, Model[0].SmtpServer, 4214, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""SmtpServer"" id=""SmtpServer"" placeholder=""SMTP Sunucusu"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpUsername"">SMTP Kullanıcı Adı</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4527, "\"", 4557, 1);
#nullable restore
#line 66 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 4535, Model[0].SmtpUsername, 4535, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""SmtpUsername"" id=""SmtpUsername"" placeholder=""SMTP Kullanıcı Adı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpPassword"">SMTP Şifresi</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4853, "\"", 4883, 1);
#nullable restore
#line 70 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 4861, Model[0].SmtpPassword, 4861, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""SmtpPassword"" id=""SmtpPassword"" placeholder=""SMTP Şifresi"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""smtpPort"">SMTP Port</label>
                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 5166, "\"", 5192, 1);
#nullable restore
#line 74 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
WriteAttributeValue("", 5174, Model[0].SmtpPort, 5174, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"SmtpPort\" id=\"SmtpPort\" placeholder=\"SMTP Port\">\r\n                </div>\r\n                <div class=\"form-check\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\" name=\"UseSSL\" id=\"UseSSL\" ");
#nullable restore
#line 77 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\Settings\Index.cshtml"
                                                                                          Write(Model[0].UseSSL == "true" ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                    <label class=""form-check-label"" for=""useSSL"">
                        SSL
                    </label>
                </div>
                <hr />
                <div class=""form-group"">
                    <label for=""logo"">Site Logo</label>
                    <input type=""file"" class=""form-control-file"" id=""Logo"" name=""Logo"">
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
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-colorpicker/3.4.0/js/bootstrap-colorpicker.min.js"" integrity=""sha512-94dgCw8xWrVcgkmOc2fwKjO4dqy/X3q7IjFru6MHJKeaAzCvhkVtOS6S+co+RbcZvvPBngLzuVMApmxkuWZGwQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script>
        $(function () {
            $('#siteColor').colorpicker();
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SettingsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
