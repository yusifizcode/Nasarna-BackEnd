#pragma checksum "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30493fa56370d7caf308ac21de0afd7a6cb61e21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30493fa56370d7caf308ac21de0afd7a6cb61e21", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9efff88c1ddb38ff49097064eb02f3c77e4c8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px;height:75px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-form position-relative"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

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
                            <h2>");
#nullable restore
#line 13 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                           Write(Model.Blog?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <ul class=\"breadcrumb-list\">\r\n                                <li class=\"breadcrumb-list-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30493fa56370d7caf308ac21de0afd7a6cb61e217340", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"breadcrumb-list-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30493fa56370d7caf308ac21de0afd7a6cb61e218847", async() => {
                WriteLiteral("Blog");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

        </section>
        <!-- End of Breadcrumb -->

        <section class=""section-padding"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8"">
                        <div class=""post"">
                            <div class=""owl-carousel owl-theme owl-post"">

");
#nullable restore
#line 37 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                             foreach(var blogImg in Model.Blog.BlogImages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item\">\r\n                                    <div class=\"post-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30493fa56370d7caf308ac21de0afd7a6cb61e2111200", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1600, "~/uploads/blogs/", 1600, 16, true);
#nullable restore
#line 41 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 1616, blogImg?.Name, 1616, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 44 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>

                            <div class=""post-info d-flex w-100 justify-content-between"">
                                <div class=""d-flex"">
                                    <div class=""post-info-user d-flex"">
                                        <div class=""user-img"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30493fa56370d7caf308ac21de0afd7a6cb61e2113466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2125, "~/uploads/blogs/", 2125, 16, true);
#nullable restore
#line 51 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 2141, Model.Blog.AppUser?.ProfileImg, 2141, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"user-name ms-2\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2347, "\"", 2354, 0);
            EndWriteAttribute();
            WriteLiteral(@">By Admin</a>
                                        </div>
                                    </div>
                                    <div class=""post-date ms-3 d-flex align-items-center justify-content-between"">
                                        <span><i class=""fa-solid fa-calendar-days me-1""></i> ");
#nullable restore
#line 58 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                        Write(Model.Blog.CreatedAt.ToString("MMM dddd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"post-content\">\r\n                                <h3>");
#nullable restore
#line 63 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                               Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 64 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                              Write(Model.Blog.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                <div class=\"tag-share shadow p-4 mt-5\">\r\n                                    <div class=\"d-flex flex-wrap\">\r\n");
#nullable restore
#line 68 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                     foreach(var tag in Model.Blog.BlogTags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 3323, "\"", 3330, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                                            class=\"rounded-pill px-5 py-3 bg-light text-decoration-none text-dark me-3 mb-2\">");
#nullable restore
#line 71 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                                                        Write(tag.Tag?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 72 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                                </div>

                            </div>
                        </div>

                        <div id=""Comments"" class=""mt-5"">
                            <div class=""comments"">
");
#nullable restore
#line 82 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                 if (Model.Blog.BlogComments.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3 class=\"comments-title mt-3\">Comments</h3>\r\n                                            <ol class=\"comment-list\">\r\n");
#nullable restore
#line 86 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                             foreach(var comment in Model.Blog.BlogComments)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"comment d-flex mb-3\">\r\n                                                    <div class=\"comment-img\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30493fa56370d7caf308ac21de0afd7a6cb61e2119553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4463, "~/uploads/users/", 4463, 16, true);
#nullable restore
#line 90 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 4479, comment.AppUser?.ProfileImg, 4479, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                                                    <div class=""comment-wrap"">
                                                        <div class=""comment-header"">
                                                            <h4>");
#nullable restore
#line 95 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                           Write(comment.AppUser?.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                <span class=\"comment-date\">");
#nullable restore
#line 96 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                      Write(comment.CreatedAt.ToString("MMM d, yyyy - h:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                            </h4>
                                                        </div>
                                                        <div class=""comment-content"">
                                                            <p>");
#nullable restore
#line 100 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                          Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 104 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ol>\r\n");
#nullable restore
#line 106 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 108 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                               Write(await Html.PartialAsync("_BlogCommentFormPartialView",Model.BlogComment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>

                    </div>
                    <div class=""col-md-4"">
                        <div class=""site-sidebar"">
                            <div class=""sidebar-item sidebar-search"">
                                <h3>Search Here</h3>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30493fa56370d7caf308ac21de0afd7a6cb61e2124265", async() => {
                WriteLiteral(@"
                                    <input type=""text"" class=""form-control"" name=""title"" placeholder=""Search Post.."">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"sidebar-item sidebar-recents\">\r\n                                <h3>Recent Posts</h3>\r\n                                <div class=\"recent-posts\">\r\n");
#nullable restore
#line 139 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                 foreach(var post in Model.RecentlyBlogs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"recent-post mt-3\">\r\n                                        <div class=\"recent-post-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30493fa56370d7caf308ac21de0afd7a6cb61e2126780", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7692, "~/uploads/blogs/", 7692, 16, true);
#nullable restore
#line 143 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 7708, post.BlogImages[0]?.Name, 7708, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"recent-post-detail\">\r\n                                            <h4>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30493fa56370d7caf308ac21de0afd7a6cb61e2128601", async() => {
#nullable restore
#line 147 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                                                Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                               WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </h4>\r\n                                            <span class=\"date\">\r\n                                                ");
#nullable restore
#line 150 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                           Write(post.CreatedAt.ToString("dddd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n                                        </div>\r\n                                    </div>    \r\n");
#nullable restore
#line 154 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                                </div>
                            </div>
                            <div class=""sidebar-item sidebar-tags"">
                                <h3>Tags</h3>
                                <ul class=""sidebar-tag-list"">

");
#nullable restore
#line 162 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                 foreach(var tag in Model.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30493fa56370d7caf308ac21de0afd7a6cb61e2132765", async() => {
                WriteLiteral("\r\n                                    <li class=\"sidebar-tag-list-item\">\r\n                                        <button type=\"submit\" name=\"tagId\"");
                BeginWriteAttribute("value", " value=\"", 9022, "\"", 9037, 1);
#nullable restore
#line 166 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 9030, tag.Id, 9030, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\">");
#nullable restore
#line 166 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                                                                                  Write(tag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                    </li>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 169 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n\r\n\r\n\r\n\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
