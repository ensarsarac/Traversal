#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Areas\Admin\Views\Shared\Components\_GuideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3afaa9fb036b29d4292753244843b6bb6921b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components__GuideList_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/_GuideList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3afaa9fb036b29d4292753244843b6bb6921b4", @"/Areas/Admin/Views/Shared/Components/_GuideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151b43c462bb7c483a21a612584ead6d4ef1faf", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components__GuideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/paypal.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/wallet.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/chart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/cc-success.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/icons/unicons/cc-warning.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-md-6 col-lg-4 order-2 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header d-flex align-items-center justify-content-between"">
            <h5 class=""card-title m-0 me-2"">Transactions</h5>
            <div class=""dropdown"">
                <button class=""btn p-0""
                        type=""button""
                        id=""transactionID""
                        data-bs-toggle=""dropdown""
                        aria-haspopup=""true""
                        aria-expanded=""false"">
                    <i class=""bx bx-dots-vertical-rounded""></i>
                </button>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""transactionID"">
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Last 28 Days</a>
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Last Month</a>
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Last Year</a>
                </div>
            </div");
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <ul class=\"p-0 m-0\">\r\n                <li class=\"d-flex mb-4 pb-1\">\r\n                    <div class=\"avatar flex-shrink-0 me-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b48979", async() => {
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Paypal</small>
                            <h6 class=""mb-0"">Send money</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">+82.6</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b410970", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Wallet</small>
                            <h6 class=""mb-0"">Mac'D</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">+270.69</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b412959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Transfer</small>
                            <h6 class=""mb-0"">Refund</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">+637.91</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b414951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Credit Card</small>
                            <h6 class=""mb-0"">Ordered Food</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">-838.71</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b416952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Wallet</small>
                            <h6 class=""mb-0"">Starbucks</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">+203.33</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
                <li class=""d-flex"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3afaa9fb036b29d4292753244843b6bb6921b418935", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <small class=""text-muted d-block mb-1"">Mastercard</small>
                            <h6 class=""mb-0"">Ordered Food</h6>
                        </div>
                        <div class=""user-progress d-flex align-items-center gap-1"">
                            <h6 class=""mb-0"">-92.45</h6>
                            <span class=""text-muted"">USD</span>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
