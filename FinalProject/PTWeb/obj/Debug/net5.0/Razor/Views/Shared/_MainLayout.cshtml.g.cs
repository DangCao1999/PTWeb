#pragma checksum "C:\Users\PC\source\repos\PTWeb\PTWeb\Views\Shared\_MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f30d9e389c5da6ddf635986aa0d9f5b33e6130e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainLayout), @"mvc.1.0.view", @"/Views/Shared/_MainLayout.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\PTWeb\PTWeb\Views\_ViewImports.cshtml"
using PTWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\PTWeb\PTWeb\Views\_ViewImports.cshtml"
using PTWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f30d9e389c5da6ddf635986aa0d9f5b33e6130e", @"/Views/Shared/_MainLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f52aa8fe25f395afd3d0eb2c5201af9c110b97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MainLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f30d9e389c5da6ddf635986aa0d9f5b33e6130e4131", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <title>Pink Shop Template</title>
    <meta name=""keywords"" content=""pink shop, store template, ecommerce, online shopping, CSS, HTML"" />
    <meta name=""description"" content=""Pink Shop is a free ecommerce template provided by templatemo.com"" />
    <link href=""/css/templatemo_style.css"" rel=""stylesheet"" type=""text/css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""/css/styles.css"" />

    <script language=""javascript"" type=""text/javascript"">
        function clearText(field) {
            if (field.defaultValue == field.value) field.value = '';
            else if (field.value == '') field.value = field.defaultValue;
        }
    </script>
    <script language=""javascript"" type=""text/javascript"" src=""/js/mootools-1.2.1-core.js""></script>
    <script language=""javascript"" type=""text/javascript"" src=""/js/mootools-1.2-more.js""></script>
    <script language=""javascript"" type=""text/javascript"" src=""/js/slideitmo");
                WriteLiteral(@"o-1.1.js""></script>
    <script language=""javascript"" type=""text/javascript"">
        window.addEvents({
            'domready': function () {
                /* thumbnails example , div containers */
                new SlideItMoo({
                    overallContainer: 'SlideItMoo_outer',
                    elementScrolled: 'SlideItMoo_inner',
                    thumbsContainer: 'SlideItMoo_items',
                    itemsVisible: 5,
                    elemsSlide: 3,
                    duration: 200,
                    itemsSelector: '.SlideItMoo_element',
                    itemWidth: 140,
                    showControls: 1
                });
            },

        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f30d9e389c5da6ddf635986aa0d9f5b33e6130e6929", async() => {
                WriteLiteral(@"
    <div id=""templatemo_wrapper"">
        <div id=""templatemo_menu"">
            <ul>
                <li><a href=""#"" class=""current""><span>.01</span>Home</a></li>
                <li><a href=""http://www.templatemo.com/page/1"" target=""_parent""><span>.02</span>Templates</a></li>
                <li><a href=""http://www.flashmo.com/page/1"" target=""_parent""><span>.03</span>Flash</a></li>
                <li><a href=""http://www.koflash.com"" target=""_parent""><span>.04</span>Gallery</a></li>
                <li><a href=""#""><span>.05</span>Company</a></li>
                <li><a href=""#""><span>.06</span>Contact</a></li>
            </ul>
        </div> <!-- end of templatemo_menu -->

        <div id=""templatemo_header_bar"">

            <div id=""header"">
                <div class=""right""></div>

                <h1>
                    <a href=""#"">
                        <img src=""/images/templatemo_logo.png"" alt=""Site Title"" />
                        <span>Online Store Template</span>
    ");
                WriteLiteral("                </a>\r\n                </h1>\r\n            </div>\r\n\r\n            <div id=\"search_box\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f30d9e389c5da6ddf635986aa0d9f5b33e6130e8409", async() => {
                    WriteLiteral("\r\n                    <input type=\"text\" value=\"Enter keyword here...\" name=\"q\" size=\"10\" id=\"searchfield\" title=\"searchfield\" onfocus=\"clearText(this)\" onblur=\"clearText(this)\" />\r\n                    <input type=\"submit\" name=\"Search\"");
                    BeginWriteAttribute("value", " value=\"", 3203, "\"", 3211, 0);
                    EndWriteAttribute();
                    WriteLiteral(" alt=\"Search\" id=\"searchbutton\" title=\"Search\" />\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>

        </div> <!-- end of templatemo_header_bar -->

        <div class=""cleaner""></div>

        <div id=""sidebar"">
            <div class=""sidebar_top""></div><div class=""sidebar_bottom""></div>

            <div class=""sidebar_section"">

                <h2>Members</h2>

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f30d9e389c5da6ddf635986aa0d9f5b33e6130e10828", async() => {
                    WriteLiteral("\r\n                    <label>Username</label>\r\n                    <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 3726, "\"", 3734, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"username\" size=\"10\" class=\"input_field\" title=\"username\" />\r\n                    <label>Password</label>\r\n                    <input type=\"password\"");
                    BeginWriteAttribute("value", " value=\"", 3890, "\"", 3898, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"password\" class=\"input_field\" title=\"password\" />\r\n                    <a href=\"#\">Register</a>\r\n                    <input type=\"submit\" name=\"login\" value=\"Login\" alt=\"Login\" id=\"submit_btn\" title=\"Login\" />\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                <div class=\"cleaner\"></div>\r\n\r\n            </div>\r\n\r\n            <div class=\"sidebar_section\">\r\n\r\n                ");
#nullable restore
#line 99 "C:\Users\PC\source\repos\PTWeb\PTWeb\Views\Shared\_MainLayout.cshtml"
           Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 
            </div>

            <div class=""sidebar_section"">

                <h2>Discounts</h2>

                <div class=""image_wrapper""><a href=""http://www.templatemo.com/page/7"" target=""_parent""><img src=""/images/image_01.jpg"" alt=""product"" /></a></div>
                <div class=""discount""><span>25% off</span> | <a href=""#"">Read more</a></div>

            </div>

        </div> <!-- end of sidebar -->

        <div id=""templatmeo_content"">
            <div id=""latest_product_gallery"">

                <h2>Featured Products</h2>

                <div id=""SlideItMoo_outer"">
                    <div id=""SlideItMoo_inner"">
                        <div id=""SlideItMoo_items"">
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_01.png"" alt=""product 1"" />
                                </a>

                            </div>
                           ");
                WriteLiteral(@" <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_02.png"" alt=""product 2"" />
                                </a>

                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_03.png"" alt=""product 3"" />
                                </a>

                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_04.png"" alt=""product 4"" />
                                </a>

                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_05.png"" alt=""pr");
                WriteLiteral(@"oduct 5"" />
                                </a>

                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_06.png"" alt=""product 6"" />
                                </a>

                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_07.png"" alt=""product 7"" />
                                </a>
                            </div>
                            <div class=""SlideItMoo_element"">
                                <a href=""#"">
                                    <img src=""/images/templatemo_product_08.png"" alt=""product 8"" />
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
");
                WriteLiteral("\r\n            </div> <!-- end of latest_content_gallery -->\r\n            ");
#nullable restore
#line 172 "C:\Users\PC\source\repos\PTWeb\PTWeb\Views\Shared\_MainLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
            <!-- end of templatmeo_content -->


        </div> <!-- end of templatemo_wrapper -->

    <div id=""templatemo_footer_wrapper"">

        <div id=""templatemo_footer"">

            <ul class=""footer_menu"">
                <li><a href=""#"">Home</a></li>
                <li><a href=""http://www.templatemo.com/page/1"" target=""_parent"">CSS Templates</a></li>
                <li><a href=""http://www.flashmo.com/page/1"" target=""_parent"">Flash Resources</a></li>
                <li><a href=""#"">Gallery</a></li>
                <li><a href=""#"">Company</a></li>
                <li class=""last_menu""><a href=""#"">Contact</a></li>
            </ul>

            Copyright � 2012 <a href=""#"">Your Company Name</a> |
            Designed by <a href=""http://www.templatemo.com"" target=""_parent"">Free CSS Templates</a> |
            Validate <a href=""http://validator.w3.org/check?uri=referer"">XHTML</a> &amp; <a href=""http://jigsaw.w3.org/css-validator/check/referer"">CSS</a>

        ");
                WriteLiteral(@"</div>
        <div style=""text-align: center; font-size: 0.75em;""><a target='_blank' href='http://www.loudsahara.com/'>Voyage d�sert Maroc</a> | <a target='_blank' href='http://blueseodesign.com/'>seo tutoriels</a></div>
        <!-- end of footer -->

    </div> <!-- end of footer_wrapper -->
");
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
            WriteLiteral("\r\n</html>");
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