#pragma checksum "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2bd787d730d23286f6ab8163d57fe923e6c95b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cause_Index), @"mvc.1.0.view", @"/Views/Cause/Index.cshtml")]
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
#line 1 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\_ViewImports.cshtml"
using Nasarna;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\_ViewImports.cshtml"
using Nasarna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\_ViewImports.cshtml"
using Nasarna.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2bd787d730d23286f6ab8163d57fe923e6c95b", @"/Views/Cause/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9efff88c1ddb38ff49097064eb02f3c77e4c8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cause_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cause>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/blog/admin.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-form position-relative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/recent-posts/img-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- Start of Breadcrumb -->
    <section class=""breadcrumb section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap"">
                        <h2>Our Causes</h2>
                        <ul class=""breadcrumb-list"">
                            <li class=""breadcrumb-list-item"">
                                <a href=""index.html"">Home</a>
                            </li>
                            <li class=""breadcrumb-list-item"">
                                <a href=""cause.html"">Causes</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <!-- End of Breadcrumb -->
    <!-- Start of Causes -->
    <section id=""causes"" class=""section-padding bg-white"">
        <div class=""container"">
            <div class=""row"">
                <div class=""sec");
            WriteLiteral(@"tion-title text-center"">
                    <span>Our Causes</span>
                    <h2>Popular Causes What You Should Know</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""row justify-content-center"">

");
#nullable restore
#line 42 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                         foreach (var cause in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-6 mb-5\">\r\n                                <div class=\"cause-card post shadow-sm p-0\">\r\n                                    <div class=\"owl-carousel owl-theme owl-post\">\r\n");
#nullable restore
#line 47 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                                         foreach(var causeImg in cause.CauseImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"item\">\r\n                                                <div class=\"post-img\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f2bd787d730d23286f6ab8163d57fe923e6c95b8066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2026, "~/uploads/causes/", 2026, 17, true);
#nullable restore
#line 51 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
AddHtmlAttributeValue("", 2043, causeImg.Name, 2043, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 54 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"cause-content post-info w-100\">\r\n                                        <div class=\"post-content\">\r\n                                            <h3 class=\"fs-4\">");
#nullable restore
#line 63 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                                                        Write(cause.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                        </div>
                                        <div class=""d-flex"">
                                            <div class=""post-info-user d-flex"">
                                                <div class=""user-img"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f2bd787d730d23286f6ab8163d57fe923e6c95b10870", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                                <div class=\"user-name ms-2\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3377, "\"", 3384, 0);
            EndWriteAttribute();
            WriteLiteral(@">By Admin</a>
                                                </div>
                                            </div>
                                            <div class=""post-date ms-3 d-flex align-items-center justify-content-between"">
                                                <span><i class=""fa-solid fa-calendar-days me-1""></i> ");
#nullable restore
#line 75 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                                                                                                Write(cause.CreatedAt.ToString("d,MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </div>
                                        </div>
                                        <div class=""progress mt-5 mb-4"">
                                            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 25%;""
                                             aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                25%
                                            </div>
                                        </div>
                                        <div class=""raise-goal d-flex justify-content-between"">
                                            <div class=""raise"">
                                                <span>Raised:</span>
                                                $7,000.00
                                            </div>
                                            <div class=""goal"">
                                                <span>Go");
            WriteLiteral("al:</span>\r\n                                                $");
#nullable restore
#line 91 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                                            Write(cause.NeedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""cause-btns d-flex"">
                                        <a href=""#"" class=""btn"">Learn More</a>
                                        <a href=""#"" class=""btn"">Donate Now</a>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 101 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Cause\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"pagination-wrapper mb-3\">\r\n                            <ul class=\"pg-pagination\">\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5589, "\"", 5596, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-angle-left\"></i></a>\r\n                                </li>\r\n                                <li class=\"active\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5772, "\"", 5779, 0);
            EndWriteAttribute();
            WriteLiteral(">1</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5903, "\"", 5910, 0);
            EndWriteAttribute();
            WriteLiteral(">2</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6034, "\"", 6041, 0);
            EndWriteAttribute();
            WriteLiteral(">3</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6165, "\"", 6172, 0);
            EndWriteAttribute();
            WriteLiteral(">4</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6296, "\"", 6303, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-angle-right""></i></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""site-sidebar"">
                        <div class=""sidebar-item sidebar-search"">
                            <h3>Search Here</h3>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2bd787d730d23286f6ab8163d57fe923e6c95b17345", async() => {
                WriteLiteral(@"
                                <input type=""text"" class=""form-control"" placeholder=""Search Post.."">
                                <button type=""submit"">
                                    <i class=""fa-solid fa-magnifying-glass""></i>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""sidebar-item sidebar-categories"">
                            <h3>Categories</h3>
                            <ul class=""sidebar-category-list"">
                                <li class=""sidebar-category-list-item"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 7445, "\"", 7452, 0);
            EndWriteAttribute();
            WriteLiteral(">Helping Poor</a>\r\n                                </li>\r\n                                <li class=\"sidebar-category-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7622, "\"", 7629, 0);
            EndWriteAttribute();
            WriteLiteral(">Water Problem</a>\r\n                                </li>\r\n                                <li class=\"sidebar-category-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7800, "\"", 7807, 0);
            EndWriteAttribute();
            WriteLiteral(">Charity</a>\r\n                                </li>\r\n                                <li class=\"sidebar-category-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7972, "\"", 7979, 0);
            EndWriteAttribute();
            WriteLiteral(">Medical Compain</a>\r\n                                </li>\r\n                                <li class=\"sidebar-category-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 8152, "\"", 8159, 0);
            EndWriteAttribute();
            WriteLiteral(@">Free Food</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""sidebar-item sidebar-recents"">
                            <h3>Recent Posts</h3>
                            <div class=""recent-posts"">
                                <div class=""recent-post"">
                                    <div class=""recent-post-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f2bd787d730d23286f6ab8163d57fe923e6c95b21274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"recent-post-detail\">\r\n                                        <h4>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 8888, "\"", 8895, 0);
            EndWriteAttribute();
            WriteLiteral(@">Many Children are suffering a lot for food.</a>
                                        </h4>
                                        <span class=""date"">
                                            22 Sep 2020
                                        </span>
                                    </div>
                                </div>
                                <div class=""recent-post mt-3"">
                                    <div class=""recent-post-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f2bd787d730d23286f6ab8163d57fe923e6c95b23269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"recent-post-detail\">\r\n                                        <h4>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 9680, "\"", 9687, 0);
            EndWriteAttribute();
            WriteLiteral(@">Many Children are suffering a lot for food.</a>
                                        </h4>
                                        <span class=""date"">
                                            22 Sep 2020
                                        </span>
                                    </div>
                                </div>
                                <div class=""recent-post mt-3"">
                                    <div class=""recent-post-img"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f2bd787d730d23286f6ab8163d57fe923e6c95b25264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"recent-post-detail\">\r\n                                        <h4>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 10472, "\"", 10479, 0);
            EndWriteAttribute();
            WriteLiteral(@">Many Children are suffering a lot for food.</a>
                                        </h4>
                                        <span class=""date"">
                                            22 Sep 2020
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""sidebar-item sidebar-tags"">
                            <h3>Tags</h3>
                            <ul class=""sidebar-tag-list"">
                                <li class=""sidebar-tag-list-item"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 11169, "\"", 11176, 0);
            EndWriteAttribute();
            WriteLiteral(">Donations</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 11338, "\"", 11345, 0);
            EndWriteAttribute();
            WriteLiteral(">Charity</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 11505, "\"", 11512, 0);
            EndWriteAttribute();
            WriteLiteral(">Help</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 11669, "\"", 11676, 0);
            EndWriteAttribute();
            WriteLiteral(">Non Profit</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 11839, "\"", 11846, 0);
            EndWriteAttribute();
            WriteLiteral(">Poor People</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 12010, "\"", 12017, 0);
            EndWriteAttribute();
            WriteLiteral(">Helping Hand</a>\r\n                                </li>\r\n                                <li class=\"sidebar-tag-list-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 12182, "\"", 12189, 0);
            EndWriteAttribute();
            WriteLiteral(@">Video</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- End of Causes -->





</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cause>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
