#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "727e1c325d394ef5b16a2592f3db0bf3eecff488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
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
#line 1 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using TraversalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727e1c325d394ef5b16a2592f3db0bf3eecff488", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02afc0eb13c08320087b79bd5a738f20daaee5de", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2><b>Yorumlar( ");
#nullable restore
#line 4 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
            Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</b></h2>\r\n<br />\r\n");
#nullable restore
#line 6 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
 if (Model.Count() < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4><b>Bu Rotaya henüz yorum yapılmadı..</b></h4>\r\n");
#nullable restore
#line 9 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"author-card mt-5\">\r\n            <div class=\"row align-items-center\">\r\n                <div class=\"col-sm-3 col-6\">\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "727e1c325d394ef5b16a2592f3db0bf3eecff4885417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 411, "~/ProfileImage/", 411, 15, true);
#nullable restore
#line 18 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
AddHtmlAttributeValue("", 426, item.AppUser.ImageUrl, 426, 22, false);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n                    <h3 class=\"mb-3 title\">");
#nullable restore
#line 22 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
                                      Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
                                                         Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 23 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
                  Write(item.CommentDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>\r\n                        ");
#nullable restore
#line 25 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
                   Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <ul class=""author-icons mt-4"">
                        <li>
                            <a class=""facebook"" href=""#url"">
                                <span class=""fa fa-facebook""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                        <li>
                            <a class=""twitter"" href=""#url"">
                                <span class=""fa fa-twitter""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                        <li>
                            <a class=""google"" href=""#url"">
                                <span class=""fa fa-google-plus""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                        <li>
                            <a class=""linkedin"" href=""#url"">");
            WriteLiteral(@"
                                <span class=""fa fa-linkedin""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                        <li>
                            <a class=""github"" href=""#url"">
                                <span class=""fa fa-github""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                        <li>
                            <a class=""dribbble"" href=""#url"">
                                <span class=""fa fa-dribbble""
                                      aria-hidden=""true""></span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
");
#nullable restore
#line 68 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Shared\Components\_CommentList\Default.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
