#pragma checksum "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mernis_Index), @"mvc.1.0.view", @"/Views/Mernis/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e", @"/Views/Mernis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10869d0db515fc721322e772d3caed13eb4475b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Mernis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mernis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e4888", async() => {
                WriteLiteral(@"

    <!-- partial:partials/_navbar.html -->
    <!-- partial -->
    <!-- partial:partials/_sidebar.html -->


    <div class=""page-header"">
        <h3 class=""page-title"">
            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                <i class=""mdi mdi-home""></i>
            </span> Toplam Müşteri Sayısı
        </h3>
    </div>
    <div class=""row"">
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-danger card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e5757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">
                        Starbucks Müşteri Sayısı <i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">12</h2>
                    <h6 class=""card-text"">Starbucks Firması Müşteri Sayısı</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-info card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e7602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">
                        Portal Müşteri Sayısı<i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">8</h2>
                    <h6 class=""card-text"">Portal Firması Müşteri Sayısı</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-success card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4ec90c1146d43c323e3b95e9ff2af86b0e78d6e9448", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <h4 class=""font-weight-normal mb-3"">
                        Toplam Müşteri Sayısı <i class=""mdi mdi-diamond mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">20</h2>
                    <h6 class=""card-text"">Tüm Firmalar Toplam Müşteri Sayısı</h6>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Starbucks Firması Müşterileri</h4>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>Adı </th>
                                    <th> Soyadı </th>
                                    <th> TC Kimlik No</th>
                                    <th> Doğum Tarihi </th>
");
                WriteLiteral("                                    <th> İşlemler </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 79 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                 foreach (var item in Model)
                                {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td> ");
#nullable restore
#line 84 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                        Write(item.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 85 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                        Write(item.Soyad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                        <td> ");
#nullable restore
#line 86 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                        Write(item.TcKimlikNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td> ");
#nullable restore
#line 87 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                         Write(((DateTime)item.DogumTarihi).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td>
                                            <div class=""progress"">
                                                <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 94 "C:\Users\user\source\repos\FirmaYönetimPanelii\FirmaYönetimPanelii\Views\Mernis\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <a href=\"/Mernis/MernisAdd\" class=\"btn btn-info\">Yeni Müşteri</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mernis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
