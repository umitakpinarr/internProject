#pragma checksum "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ab20a5238a8ac5453391de3388c7efffe7ccc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ab20a5238a8ac5453391de3388c7efffe7ccc4", @"/Areas/Admin/Views/User/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29c4efeca20d05fa780116077cc9b21592b6f26", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RoleModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["CmsTitle"] = "Kullanıcı Oluştur";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ab20a5238a8ac5453391de3388c7efffe7ccc44949", async() => {
                WriteLiteral(@"
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""Email"">Kullanıcı Adı</label>
                    <input class=""form-control"" name=""Email"" id=""Email"" type=""text"" placeholder=""Kullanıcı Adı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""Name"">Adı</label>
                    <input class=""form-control"" name=""Name"" id=""Name"" type=""text"" placeholder=""Adı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""Surname"">Soyadı</label>
                    <input class=""form-control"" name=""Surname"" id=""Surname"" type=""text"" placeholder=""Soyadı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""Password"">Şifre</label>
                    <div class=""input-group input-group-merge"">
                        <input type=""password"" id=""");
                WriteLiteral(@"Password"" name=""Password"" class=""form-control"" placeholder=""Şifre giriniz.."">
                        <div class=""input-group-append"" data-password=""false"">
                            <div class=""input-group-text"">
                                <span class=""password-eye""></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""form-group"" style=""margin-bottom: 10px;"">
                    <label for=""RoleId"">Kullanıcı Rolü</label>
                    <select name=""RoleId"" id=""RoleId"" class=""form-control"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ab20a5238a8ac5453391de3388c7efffe7ccc46993", async() => {
                    WriteLiteral("Lütfen Seçim Yapınız !");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml"
                         foreach (RoleModel Roles in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ab20a5238a8ac5453391de3388c7efffe7ccc48678", async() => {
#nullable restore
#line 39 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml"
                                                 Write(Roles.RoleName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml"
                               WriteLiteral(Roles.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Freeman\Source\Repos\farukcakal\internProject\JobsArgeya\Areas\Admin\Views\User\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <hr />
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""OfficeName"">Ofis Adı</label>
                    <input class=""form-control"" name=""OfficeName"" id=""OfficeName"" type=""text"" placeholder=""Ofis Adı"">
                </div>
                <div class=""form-group"" style=""margin-bottom:10px;"">
                    <label for=""OfficeDomain"">Ofis Domain</label>
                    <input class=""form-control"" name=""OfficeDomain"" id=""OfficeDomain"" type=""text"" placeholder=""Ofis Domain"">
                </div>
                <br />
                <button type=""submit"" class=""btn btn-danger w-100"">Kullanıcı Oluştur</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RoleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
