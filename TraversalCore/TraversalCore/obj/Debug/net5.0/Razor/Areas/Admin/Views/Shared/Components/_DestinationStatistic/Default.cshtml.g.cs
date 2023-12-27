#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Shared\Components\_DestinationStatistic\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea4bfff3383b25757f6a8c2e886a4df48803ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components__DestinationStatistic_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/_DestinationStatistic/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea4bfff3383b25757f6a8c2e886a4df48803ec8", @"/Areas/Admin/Views/Shared/Components/_DestinationStatistic/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components__DestinationStatistic_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-6 col-lg-4 col-xl-4 order-0 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header d-flex align-items-center justify-content-between pb-0"">
            <div class=""card-title mb-0"">
                <h5 class=""m-0 me-2"">Order Statistics</h5>
                <small class=""text-muted"">42.82k Total Sales</small>
            </div>
            <div class=""dropdown"">
                <button class=""btn p-0""
                        type=""button""
                        id=""orederStatistics""
                        data-bs-toggle=""dropdown""
                        aria-haspopup=""true""
                        aria-expanded=""false"">
                    <i class=""bx bx-dots-vertical-rounded""></i>
                </button>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""orederStatistics"">
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Select All</a>
                    <a class=""dropdown-item"" href=""javascript:void(0);");
            WriteLiteral(@""">Refresh</a>
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Share</a>
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""d-flex justify-content-between align-items-center mb-3"">
                <div class=""d-flex flex-column align-items-center gap-1"">
                    <h2 class=""mb-2"">8,258</h2>
                    <span>Total Orders</span>
                </div>
                <div id=""orderStatisticsChart""></div>
            </div>
            <ul class=""p-0 m-0"">
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-primary"">
                            <i class=""bx bx-mobile-alt""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div ");
            WriteLiteral(@"class=""me-2"">
                            <h6 class=""mb-0"">Electronic</h6>
                            <small class=""text-muted"">Mobile, Earbuds, TV</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">82.5k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Fashion</h6>
                            <small class=""text-muted"">T-shirt, Jeans, Shoes</small>
                        </div>
                        <div class=""user-progres");
            WriteLiteral(@"s"">
                            <small class=""fw-semibold"">23.8k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-info""><i class=""bx bx-home-alt""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Decor</h6>
                            <small class=""text-muted"">Fine Art, Dining</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">849k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex"">
                    <div class=""avatar flex-shrink-0 m");
            WriteLiteral(@"e-3"">
                        <span class=""avatar-initial rounded bg-label-secondary"">
                            <i class=""bx bx-football""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Sports</h6>
                            <small class=""text-muted"">Football, Cricket Kit</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">99</small>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
