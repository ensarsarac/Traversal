#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "addeec01e2f07af6ddb77702586d7fadedbeffe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Messages_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Messages/Index.cshtml")]
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
#line 3 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"addeec01e2f07af6ddb77702586d7fadedbeffe6", @"/Areas/Admin/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriteUs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Mesajlar</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad</th>\r\n        <th>Mail</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n\r\n\r\n");
#nullable restore
#line 22 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 25 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
   Write(item.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 576, "\"", 615, 3);
            WriteAttributeValue("", 583, "/Admin/Messages/Delete/", 583, 23, true);
#nullable restore
#line 30 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
WriteAttributeValue("", 606, item.Id, 606, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 614, "/", 614, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 712, 3);
            WriteAttributeValue("", 679, "/Admin/Messages/Details/", 679, 24, true);
#nullable restore
#line 31 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
WriteAttributeValue("", 703, item.Id, 703, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 711, "/", 711, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesajı Aç</a></td>\r\n</tr>\r\n");
#nullable restore
#line 33 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Messages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriteUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591