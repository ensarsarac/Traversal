#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08633729cb72fa85f80ec82287a94f4f60ec654a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guides_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guides/Index.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.Areas.Admin.CQRS2.Results.Destinations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using TraversalCore.Areas.Admin.CQRS2.Commands.Destinations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using DTOLayer.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08633729cb72fa85f80ec82287a94f4f60ec654a", @"/Areas/Admin/Views/Guides/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Guides_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Rehberler</h1>

<table class=""table table-bordered"">

    <tr>
        <th>#</th>
        <th>Resim</th>
        <th>Ad Soyad</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Durum Değiştir</th>
        <th>Sil</th>
        <th>Güncelle</th>

");
            WriteLiteral("\r\n    </tr>\r\n\r\n");
#nullable restore
#line 31 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 35 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
      
        sayac = sayac + 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>");
#nullable restore
#line 38 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
   Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08633729cb72fa85f80ec82287a94f4f60ec654a7032", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 699, "~/GuideImage/", 699, 13, true);
#nullable restore
#line 39 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
AddHtmlAttributeValue("", 712, item.Image, 712, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 40 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 41 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
      
        if (item.Status)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"text-success\">Aktif</td>\r\n");
#nullable restore
#line 48 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"text-danger\">Aktif</td>\r\n");
#nullable restore
#line 52 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"

        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
      
        if (item.Status)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1172, 2);
            WriteAttributeValue("", 1133, "/Admin/Guides/DoNotActive/", 1133, 26, true);
#nullable restore
#line 58 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
WriteAttributeValue("", 1159, item.GuideId, 1159, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 59 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 1279, "\"", 1322, 2);
            WriteAttributeValue("", 1286, "/Admin/Guides/DoActive/", 1286, 23, true);
#nullable restore
#line 62 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
WriteAttributeValue("", 1309, item.GuideId, 1309, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Aktif Yap</a></td>\r\n");
#nullable restore
#line 63 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td><a");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1451, 2);
            WriteAttributeValue("", 1411, "/Admin/Guides/DeleteGuides/", 1411, 27, true);
#nullable restore
#line 65 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
WriteAttributeValue("", 1438, item.GuideId, 1438, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Rehber Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1507, "\"", 1554, 2);
            WriteAttributeValue("", 1514, "/Admin/Guides/UpdateGuides/", 1514, 27, true);
#nullable restore
#line 66 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
WriteAttributeValue("", 1541, item.GuideId, 1541, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Rehber Güncelle</a></td>\r\n\r\n\r\n");
            WriteLiteral("\r\n</tr>\r\n");
#nullable restore
#line 75 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Guides\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n<a href=\"/Admin/Guides/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591