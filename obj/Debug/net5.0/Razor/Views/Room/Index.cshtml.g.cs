#pragma checksum "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e666cebca9ccb27d1a34e5a1f94b45c37c8af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e666cebca9ccb27d1a34e5a1f94b45c37c8af0", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cab75cfe10a27103e259ffc2630fd7ed5fb803", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
Write(Model.Message=="" ? $"Комната \"{Model.RoomName}\"" : Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<input type=\"text\" id=\"msg\" />\r\n<button id=\"btnsendmsg\">Отправить</button>\r\n<div id=\"messages\"></div>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e666cebca9ccb27d1a34e5a1f94b45c37c8af04039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var connection = new signalR.HubConnectionBuilder().withUrl(\"/roomhub\").build();\r\n    document.addEventListener(\"load\", ()=>{\r\n        connection.invoke(\"MemberJoined\", \"");
#nullable restore
#line 16 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                      Write(Html.Raw(Model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 16 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                                                   Write(Html.Raw(Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
    });
    connection.start();

    connection.on(""NewMessage"", (time, sender, msg)=>{

        let p = document.createElement(""p"");
        p.innerText = `${time} ${sender}: ${msg}`;
        let firstElem = document.getElementById(""messages"").firstChild;
        document.getElementById(""messages"").insertBefore(p, firstElem);

    });

    connection.on(""MemberJoined"", memberName=>{
        let p = document.createElement(""p"");
        p.style.backgroundColor=""lightgreen"";
        p.innerText = `Пользователь ${memberName} подключился к комнате`;
        let firstElem = document.getElementById(""messages"").firstChild;
        document.getElementById(""messasges"").insertBefore(p, firstElem);
    });

        connection.on(""MemberLeft"", memberName=>{
        let p = document.createElement(""p"");
        p.style.backgroundColor=""red"";
        p.innerText = `Пользователь ${memberName} покинул комнату`;
        let firstElem = document.getElementById(""messages"").firstChild;
        docume");
            WriteLiteral(@"nt.getElementById(""messasges"").insertBefore(p, firstElem);
    });

    document.getElementById(""btnsendmsg"").addEventListener(""click"", e=>{
        let msg = document.getElementById(""msg"").value;
        if(msg!=null&&msg!=""""&&msg!="" ""){
        connection.invoke(""NewMessage"", """);
#nullable restore
#line 48 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                    Write(Html.Raw(Model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 48 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                                                 Write(Html.Raw(Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", msg);
        document.getElementById(""msg"").value="""";
        } else{
            alert(""Сообщение не может быть пустым"");
            return;
        }

    });

    window.addEventListener(""unload"", leave);
    window.addEventListener(""beforeunload"", leave);
    window.addEventListener(""close"", leave);
    function leave(e){
        connection.invoke(""MemberLeft"", """);
#nullable restore
#line 61 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                    Write(Html.Raw(Model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 61 "C:\Users\timur\source\repos\ChatApp\ChatApp\Views\Room\Index.cshtml"
                                                                 Write(Html.Raw(Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
