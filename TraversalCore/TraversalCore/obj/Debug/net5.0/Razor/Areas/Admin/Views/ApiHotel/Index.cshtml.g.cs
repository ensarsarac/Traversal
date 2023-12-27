#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4747da4dfc6d35dc5ec7383ac2441dec278cc57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiHotel_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiHotel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4747da4dfc6d35dc5ec7383ac2441dec278cc57", @"/Areas/Admin/Views/ApiHotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ApiHotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiHotelViewModel.Result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Otel Listesi</h1>
<hr />

<hr />
<h3>Arama Yapılan Şehir: Paris/Fransa</h3>

    <table class=""table table-striped"">

        <tr>
            <th>#</th>
            <th>Otel Adı</th>
            <th>Otel Puanı</th>
            <th>Otel Değerlendirmesi</th>
            <th>Otel Detaylar</th>
        </tr>
");
#nullable restore
#line 23 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
               Write(item.reviewScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                 if (item.reviewScoreWord.Equals("Very good"))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Çok İyi</td>\r\n");
#nullable restore
#line 33 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                }
                else if (item.reviewScoreWord.Equals("Good"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>İyi</td>\r\n");
#nullable restore
#line 37 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                }
                else if (item.reviewScoreWord.Equals("Superb"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Mükemmel</td>\r\n");
#nullable restore
#line 41 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                }
                else if (item.reviewScoreWord.Equals("Fabulous"))
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Efsane</td>\r\n");
#nullable restore
#line 47 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 50 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                   Write(item.reviewScoreWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a href=\"#\" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\ApiHotel\Index.cshtml"
            count++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiHotelViewModel.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
