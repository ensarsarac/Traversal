#pragma checksum "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f4f340211c91367ee717c345f67a49febf7277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f4f340211c91367ee717c345f67a49febf7277", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02afc0eb13c08320087b79bd5a738f20daaee5de", @"/Views/_ViewImports.cshtml")]
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Destination>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/css/style-liberty.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e7f4f340211c91367ee717c345f67a49febf72775236", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f4f340211c91367ee717c345f67a49febf72776359", async() => {
                WriteLiteral(@"

    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Tur Detayları</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index/"">Anasayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rehberin Yorumları </li>
                </ul>
            </div>
        </div>
    </section>

    <div class=""py-5 w3l-homeblock1 text-center"">
        <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Alanında en yetkin rehberlerimizle en güncel seyahat hikayelerimizi okumalısınız!
            </h3>
            <div class=""blog-post-align"">
                <div class=""blog-post-img"">
                    <a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7f4f340211c91367ee717c345f67a49febf72777584", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1166, "~/GuideImage/", 1166, 13, true);
#nullable restore
#line 31 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
AddHtmlAttributeValue("", 1179, Model.Guide.Image, 1179, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"blog-post-info\">\r\n                    <div class=\"author align-items-center mb-1\">\r\n                        <a href=\"#\">");
#nullable restore
#line 35 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> in <a href=\"#url\">Traversal</a>\r\n                    </div>\r\n                    <ul class=\"blog-meta\">\r\n                        <li class=\"meta-item blog-lesson\">\r\n                            <span class=\"meta-value\"> ");
#nullable restore
#line 39 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                                                 Write(Model.Guide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                        </li>
                        
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <section class=""blog-post-main w3l-homeblock1"">
        <!--/blog-post-->
        <div class=""blog-content-inf pb-5"">
            <div class=""container pb-lg-4"">
                <div class=""single-post-image"">
                    <div class=""post-content"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 2145, "\"", 2168, 1);
#nullable restore
#line 53 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 2151, Model.CoverImage, 2151, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:600px;\" class=\"w-100 radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 2233, "\"", 2239, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"single-post-content\">\r\n                    <p class=\"alphabet mb-4\">\r\n                        <span class=\"big-letter\">A</span>");
#nullable restore
#line 58 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                                                    Write(Model.Details1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>

                    <blockquote class=""blockquote my-5"">
                        <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                        Gezi Tur Seyahat Rotalar Dünya
                        <footer class=""blockquote-footer mt-3"">
                            Smith lara
                        </footer>
                    </blockquote>

                    <div class=""sing-post-thumb mb-5 row pt-3"">
                        <div class=""col-sm-6"">
                            <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 3061, "\"", 3079, 1);
#nullable restore
#line 71 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3067, Model.Image, 3067, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px; height:480px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3146, "\"", 3152, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                        <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                            <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 3300, "\"", 3319, 1);
#nullable restore
#line 74 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3306, Model.Image2, 3306, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px; height:480px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3386, "\"", 3392, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        </div>\r\n                    </div>\r\n                    <p class=\"mb-4\">\r\n                        ");
#nullable restore
#line 78 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                   Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>

                    <div class=""d-grid left-right mt-5 pb-md-5"">
                        <div class=""buttons-singles tags"">
                            <h4>Etiketler :</h4>
                            <a href=""#blog-tag"">Seyahat</a>
                            <a href=""#blog-tag"">Gezi</a>
                            <a href=""#blog-tag"">Hotel</a>
                            <a href=""#blog-tag"">Yemek</a>
                            <a href=""#blog-tag"">Tur</a>
                        </div>
                        <div class=""buttons-singles"">
                            <h4>Share :</h4>
                            <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span ");
                WriteLiteral(@"class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
                        </div>
                    </div>

                    <h3>Bu Tur'un Rehberi</h3>
                    <hr />
                    <div class=""author-card my-3"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-3 col-6"">
                                <div>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e7f4f340211c91367ee717c345f67a49febf727715859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5014, "~/GuideImage/", 5014, 13, true);
#nullable restore
#line 105 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
AddHtmlAttributeValue("", 5027, Model.Guide.Image, 5027, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n                                <h3 class=\"mb-3 title\">");
#nullable restore
#line 109 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                                                  Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 111 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </p>\r\n                                <ul class=\"author-icons mt-4\">\r\n                                    <li>\r\n                                        <a class=\"facebook\"");
                BeginWriteAttribute("href", " href=\"", 5611, "\"", 5643, 1);
#nullable restore
#line 115 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 5618, Model.Guide.InstagramUrl, 5618, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""twitter""");
                BeginWriteAttribute("href", " href=\"", 5988, "\"", 6018, 1);
#nullable restore
#line 121 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 5995, Model.Guide.TwitterUrl, 5995, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""google""");
                BeginWriteAttribute("href", " href=\"", 6361, "\"", 6393, 1);
#nullable restore
#line 127 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 6368, Model.Guide.InstagramUrl, 6368, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-google-plus""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""linkedin""");
                BeginWriteAttribute("href", " href=\"", 6742, "\"", 6774, 1);
#nullable restore
#line 133 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 6749, Model.Guide.InstagramUrl, 6749, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-linkedin""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""github""");
                BeginWriteAttribute("href", " href=\"", 7118, "\"", 7150, 1);
#nullable restore
#line 139 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 7125, Model.Guide.InstagramUrl, 7125, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""dribbble""");
                BeginWriteAttribute("href", " href=\"", 7494, "\"", 7526, 1);
#nullable restore
#line 145 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 7501, Model.Guide.InstagramUrl, 7501, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""fa fa-dribbble""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <!--//author-card-->
                    ");
#nullable restore
#line 156 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("_CommentList", Model.DestinationId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!--//author-card-->\r\n");
                WriteLiteral("                    ");
#nullable restore
#line 159 "D:\Belgeler\source\repos\TraversalCore\TraversalCore\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml", Model.DestinationId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--//blog-post-->\r\n    </section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591
