#pragma checksum "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b79924accb44f2591f8033c25f89878f8b537ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ManageRoom), @"mvc.1.0.view", @"/Views/Manage/ManageRoom.cshtml")]
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
#line 1 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\_ViewImports.cshtml"
using ChatApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\_ViewImports.cshtml"
using ChatApp.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b79924accb44f2591f8033c25f89878f8b537ad", @"/Views/Manage/ManageRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cab75cfe10a27103e259ffc2630fd7ed5fb803", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ManageRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/manageroom-script.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"div-main\">\r\n    <h1>Управление комнатой ");
#nullable restore
#line 4 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr />\r\n    <div id=\"usersinroom\">\r\n    <h2>Пользователи в комнате</h2>\r\n    <hr />\r\n");
#nullable restore
#line 9 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
     foreach (var v in Model.RoomUsers)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b79924accb44f2591f8033c25f89878f8b537ad4641", async() => {
                WriteLiteral("\r\n        <h3 >Пользователь ");
#nullable restore
#line 12 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
                     Write(v.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
        <input type=""button"" name=""Kick"" class=""btn btn-outline-danger"" value=""Кикнуть из комнаты"" /><br>
        <label style=""display:inline-block;"" for=""days"">Забанить на</label>
        <input style=""display:inline-block;""type=""number"" min=""1"" max=""365"" name=""days"" value=""1""/>
        <label for=""days"">дней</label>
        <input type=""text"" name=""reason"" placeholder=""Причина"" /><br>
        <input type=""button"" name=""Ban"" class=""btn btn-outline-danger"" value=""Забанить"" /><br>
");
#nullable restore
#line 19 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
         if (!v.IsAdmin)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"button\" style=\"display:inline-block;\" name=\"Op\" class=\"btn btn-outline-success\" value=\"Выдать права администратора\" />\r\n");
#nullable restore
#line 22 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"button\" style=\"display:inline-block;\" name=\"Deop\" class=\"btn btn-outline-danger\" value=\"Забрать права администратора\" />\r\n");
#nullable restore
#line 26 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br>\r\n        <p");
                BeginWriteAttribute("id", " id=\"", 1193, "\"", 1217, 2);
                WriteAttributeValue("", 1198, "summary-", 1198, 8, true);
#nullable restore
#line 28 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
WriteAttributeValue("", 1206, v.UserName, 1206, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
AddHtmlAttributeValue("", 242, v.UserName, 242, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr />\r\n");
#nullable restore
#line 31 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div id=\"bannedusers\">\r\n    <h2>Забаненные пользователи</h2>\r\n");
#nullable restore
#line 35 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
     foreach (var v in Model.BannedUsers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b79924accb44f2591f8033c25f89878f8b537ad9121", async() => {
                WriteLiteral("\r\n            <h3 style=\"display:inline-block;\">Пользователь ");
#nullable restore
#line 38 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
                                                      Write(v.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3><br>\r\n            <input type=\"button\" name=\"Unban\" class=\"btn btn-outline-success\" value=\"Разбанить\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
AddHtmlAttributeValue("", 1413, v.UserName, 1413, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr />\r\n");
#nullable restore
#line 42 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b79924accb44f2591f8033c25f89878f8b537ad11503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Manage\ManageRoom.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
