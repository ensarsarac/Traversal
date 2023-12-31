#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9bf67f797e95dc0354ce601fb74fa675ccc084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9bf67f797e95dc0354ce601fb74fa675ccc084", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tur Rotaları</h1>
<table class=""table table-bordered"">

    <tr>
        <th>#</th>
        <th>Resim</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>

");
#nullable restore
#line 23 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 552, "\"", 569, 1);
#nullable restore
#line 27 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 558, item.Image, 558, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" style=\"width:130px; height:100px;\" /></td>\r\n            <td>");
#nullable restore
#line 28 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 759, "\"", 818, 3);
            WriteAttributeValue("", 766, "/Destination/DestinationDetails/", 766, 32, true);
#nullable restore
#line 31 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 798, item.DestinationId, 798, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 817, "/", 817, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 888, "\"", 952, 3);
            WriteAttributeValue("", 895, "/Admin/Destination/DeleteDestination/", 895, 37, true);
#nullable restore
#line 32 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 932, item.DestinationId, 932, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 951, "/", 951, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1017, "\"", 1081, 3);
            WriteAttributeValue("", 1024, "/Admin/Destination/UpdateDestination/", 1024, 37, true);
#nullable restore
#line 33 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1061, item.DestinationId, 1061, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1080, "/", 1080, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/Destination/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
