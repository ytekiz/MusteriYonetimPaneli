#pragma checksum "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3da64a947b3ca11ba6f47340cdd61ab4c4b9ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortalUser_PortalUserAdd), @"mvc.1.0.view", @"/Views/PortalUser/PortalUserAdd.cshtml")]
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
#line 1 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\_ViewImports.cshtml"
using FirmaYönetimPanelii;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\_ViewImports.cshtml"
using FirmaYönetimPanelii.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c3da64a947b3ca11ba6f47340cdd61ab4c4b9ce", @"/Views/PortalUser/PortalUserAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10869d0db515fc721322e772d3caed13eb4475b3", @"/Views/_ViewImports.cshtml")]
    public class Views_PortalUser_PortalUserAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.PortalUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
  
    ViewData["Title"] = "PortalUserAdd";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Portal Müşteri Ekleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
 using (Html.BeginForm("PortalUserAdd", "PortalUser", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.Label("Müşteri Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.TextBoxFor(x => x.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br /> <br />\r\n        ");
#nullable restore
#line 16 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.Label("Müşteri Soyadı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.TextAreaFor(x => x.Soyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n        <br /> <br />\r\n        ");
#nullable restore
#line 20 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.Label("Doğum Tarihi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.TextAreaFor(x => x.DogumTarihi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
   Write(Html.ValidationMessageFor(x => x.DogumTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br /> <br />\r\n        <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3da64a947b3ca11ba6f47340cdd61ab4c4b9ce7008", async() => {
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
            WriteLiteral("\r\n        <button class=\"btn btn-info\" id=\"btn1\">Kaydet</button>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\PortalUser\PortalUserAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(\'#btn1\').click(function(){\r\n        swal(\"Tebrikler !\", \"Başarılı bir şekilde eklendi!\", \"success\");\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.PortalUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
