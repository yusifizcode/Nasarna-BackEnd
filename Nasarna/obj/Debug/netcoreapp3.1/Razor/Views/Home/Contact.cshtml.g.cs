#pragma checksum "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce48944640c07998a39d585858908550aa973f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce48944640c07998a39d585858908550aa973f73", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7308d2e2ef8b0960ba37fb62a05b1315d12209", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yusifizcode\Desktop\Nasarna-Backend\Nasarna\Nasarna\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

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
                            <h2>Contact Us</h2>
                            <ul class=""breadcrumb-list"">
                                <li class=""breadcrumb-list-item"">
                                    <a href=""index.html"">Home</a>
                                </li>
                                <li class=""breadcrumb-list-item"">
                                    <a href=""cause.html"">Contact</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

        </section>
        <!-- End of Breadcrumb -->

        <!-- Start of Contact Us -->
        <section id=""contact-us"" class=""section-padding""");
            WriteLiteral(@">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""contact-us-form shadow-sm"">
                            <h2>Get In Touch</h2>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce48944640c07998a39d585858908550aa973f735384", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-6 form-group"">
                                        <input type=""text"" class=""form-control border-0 border-bottom""
                                            placeholder=""First Name"">
                                    </div>
                                    <div class=""col-md-6 form-group"">
                                        <input type=""text"" class=""form-control border-0 border-bottom""
                                            placeholder=""Last Name"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <input type=""email"" class=""form-control border-0 border-bottom"" placeholder=""Email"">
                                </div>
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control");
                WriteLiteral(@" border-0 border-bottom""
                                        placeholder=""Subject"">
                                </div>
                                <div class=""form-group"">
                                    <textarea class=""form-control border-0 border-bottom"" rows=""6""
                                        placeholder=""Description""></textarea>
                                </div>
                                <div class=""form-btn"">
                                    <button type=""submit"">Send Message</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-md-6 col-sm-12"">
                        <div class=""contact-map contact-us-map"">
                            <iframe
                                src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d193595.9147703055!2d-74.11976314309273!3d40.69740344223377!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY%2C+USA!5e0!3m2!1sen!2sbd!4v1547528325671""");
            BeginWriteAttribute("allowfullscreen", "\r\n                                allowfullscreen=\"", 3538, "\"", 3589, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End of Contact Us -->

        <!-- Start of Contact Info -->
        <section id=""contact-info"" class=""pb-5"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                        <div class=""info-item shadow-sm"">
                            <h2>25 North Street,Dubai</h2>
                            <div class=""info-wrap d-flex align-items-center"">
                                <div class=""info-icon contact-address"">
                                    <i class=""fa-solid fa-globe""></i>
                                </div>
                                <div class=""info-text ps-3"">
                                    <span>Office Address</span>
                                </div>
                            </div>
                        </div>
   ");
            WriteLiteral(@"                 </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                        <div class=""info-item shadow-sm"">
                            <h2>info@nasarna.com</h2>
                            <div class=""info-wrap d-flex align-items-center"">
                                <div class=""info-icon contact-mail"">
                                    <i class=""fa-solid fa-envelope""></i>
                                </div>
                                <div class=""info-text ps-3"">
                                    <span>Official Mail</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 mb-3"">
                        <div class=""info-item shadow-sm"">
                            <h2>+91 256-987-239</h2>
                            <div class=""info-wrap d-flex align-items-center"">
                                ");
            WriteLiteral(@"<div class=""info-icon contact-phone"">
                                    <i class=""fa-solid fa-headphones-simple""></i>
                                </div>
                                <div class=""info-text ps-3"">
                                    <span>Official Phone</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End of Contact Info -->

    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
