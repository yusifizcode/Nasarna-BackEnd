#pragma checksum "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b395721976cbbd9ec5f4ca71b57fc269539a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b395721976cbbd9ec5f4ca71b57fc269539a0c", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9efff88c1ddb38ff49097064eb02f3c77e4c8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("clearInputField"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("alert(\'Fail\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
  
    ViewData["Title"] = "Chat";
    var userName = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section>
    <div class=""container py-5"">

        <div class=""row"">

            <div class=""col-md-6 col-lg-5 col-xl-4 mb-4 mb-md-0"">

                <h5 class=""font-weight-bold mb-3 text-center text-lg-start"">Member</h5>

                <div class=""card"">
                    <div class=""card-body"">

                        <ul class=""list-unstyled mb-0"">
                            <li class=""p-2 border-bottom"" style=""background-color: #eee;"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-8.webp"" alt=""avatar""
                                             class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" width=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">John Doe</p>
         ");
            WriteLiteral(@"                                   <p class=""small text-muted"">Hello, Are you there?</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">Just now</p>
                                        <span class=""badge bg-danger float-end"">1</span>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2 border-bottom"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-1.webp"" alt=""avatar""
                                             class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" width=""60"">
                             ");
            WriteLiteral(@"           <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Danny Smith</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">5 mins ago</p>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2 border-bottom"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-2.webp"" alt=""avatar""
                                             class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" widt");
            WriteLiteral(@"h=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Alex Steward</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">Yesterday</p>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2 border-bottom"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-3.webp"" alt=""avatar""
                                             class=""rounded-circle d-flex align-");
            WriteLiteral(@"self-center me-3 shadow-1-strong"" width=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Ashley Olsen</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">Yesterday</p>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2 border-bottom"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-4.webp"" alt=""avatar""
                                          ");
            WriteLiteral(@"   class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" width=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Kate Moss</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">Yesterday</p>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2 border-bottom"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-5.webp"" alt=""avatar""
       ");
            WriteLiteral(@"                                      class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" width=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Lara Croft</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">Yesterday</p>
                                    </div>
                                </a>
                            </li>
                            <li class=""p-2"">
                                <a href=""#!"" class=""d-flex justify-content-between"">
                                    <div class=""d-flex flex-row"">
                                        <img src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-6.webp""");
            WriteLiteral(@" alt=""avatar""
                                             class=""rounded-circle d-flex align-self-center me-3 shadow-1-strong"" width=""60"">
                                        <div class=""pt-1"">
                                            <p class=""fw-bold mb-0"">Brad Pitt</p>
                                            <p class=""small text-muted"">Lorem ipsum dolor sit.</p>
                                        </div>
                                    </div>
                                    <div class=""pt-1"">
                                        <p class=""small text-muted mb-1"">5 mins ago</p>
                                        <span class=""text-muted float-end""><i class=""fas fa-check"" aria-hidden=""true""></i></span>
                                    </div>
                                </a>
                            </li>
                        </ul>

                    </div>
                </div>

            </div>

            <div class=""col-md-6 col-lg-7 col");
            WriteLiteral("-xl-8\" id=\"chat\">\r\n\r\n                <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 137 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                     if (Model != null)
                    {
                        foreach (var message in Model.OrderBy(x => x.CreatedAt))
                        {
                            string alignSelf = "";
                            if(userName == message.UserName)
                            {
                                alignSelf = "align-self-start";
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"d-flex justify-content-between mb-4\">\r\n                                <img src=\"https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-6.webp\" alt=\"avatar\"");
            BeginWriteAttribute("class", "\r\n                             class=\"", 8994, "\"", 9085, 5);
            WriteAttributeValue("", 9032, "rounded-circle", 9032, 14, true);
            WriteAttributeValue(" ", 9046, "d-flex", 9047, 7, true);
#nullable restore
#line 149 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
WriteAttributeValue(" ", 9053, alignSelf, 9054, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9064, "me-3", 9065, 5, true);
            WriteAttributeValue(" ", 9069, "shadow-1-strong", 9070, 16, true);
            EndWriteAttribute();
            WriteLiteral(" width=\"60\">\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-header d-flex justify-content-between p-3\">\r\n                                        <p class=\"fw-bold mb-0\">");
#nullable restore
#line 152 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                                                           Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted small mb-0\"><i class=\"far fa-clock\"></i> ");
#nullable restore
#line 153 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                                                                                                 Write(message.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"card-body\">\r\n                                        <p class=\"mb-0\">\r\n                                            ");
#nullable restore
#line 157 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                                       Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
#nullable restore
#line 162 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b395721976cbbd9ec5f4ca71b57fc269539a0c19117", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b395721976cbbd9ec5f4ca71b57fc269539a0c19400", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 165 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <li class=""bg-white mb-3"">
                        <div class=""form-outline"">
                            <textarea class=""form-control"" id=""messageText"" rows=""4""></textarea>
                            <label class=""form-label"" for=""textAreaExample2"">Message</label>
                        </div>
                    </li>
                    <input value=""Send"" id=""submitButton"" class=""btn btn-info btn-rounded float-end bg-warning border-0"" />Send
                    <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 10744, "\"", 10761, 1);
#nullable restore
#line 173 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
WriteAttributeValue("", 10752, userName, 10752, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"username\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </ul>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 183 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
 if(User.Identity.IsAuthenticated){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n    const userName = \"");
#nullable restore
#line 185 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
                 Write(ViewBag.CurrentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n</script>\r\n");
#nullable restore
#line 187 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Chat.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591