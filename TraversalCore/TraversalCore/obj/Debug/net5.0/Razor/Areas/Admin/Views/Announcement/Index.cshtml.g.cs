#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3a92fe265008778c4ea167b3493aa886f679a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
using TraversalCore.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3a92fe265008778c4ea167b3493aa886f679a5", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnnouncementListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Duyuru Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>İçerik</th>\r\n        <th>Detaylar</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 25 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.AnnouncementId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 743, 3);
            WriteAttributeValue("", 683, "/Admin/Announcement/DeleteAnnouncement/", 683, 39, true);
#nullable restore
#line 29 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 722, item.AnnouncementId, 722, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 742, "/", 742, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 808, "\"", 875, 3);
            WriteAttributeValue("", 815, "/Admin/Announcement/UpdateAnnouncement/", 815, 39, true);
#nullable restore
#line 30 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 854, item.AnnouncementId, 854, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 874, "/", 874, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Announcement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Admin/Announcement/AddAnnouncement/\" class=\"btn btn-primary\">Yeni Duyuru Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnnouncementListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591