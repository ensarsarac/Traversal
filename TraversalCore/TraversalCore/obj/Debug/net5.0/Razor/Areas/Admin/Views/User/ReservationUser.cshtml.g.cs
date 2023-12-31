#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10061b40233c302c76daf1b0e2f7d6a2243824e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ReservationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10061b40233c302c76daf1b0e2f7d6a2243824e2", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_ReservationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
  
    ViewData["Title"] = "ReservationUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kullanıcının Tüm Rezervasyonları</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kullanıcı</th>\r\n        <th>Şehir</th>\r\n        <th>Tarih</th>\r\n        <th>Durum</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 26 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
              
                sayac = sayac + 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 29 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
                              Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.ReservationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\User\ReservationUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n<a href=\"/Admin/User/Index/\" class=\"btn btn-outline-primary\">Kullanıcı Listesine Geri Dön</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
