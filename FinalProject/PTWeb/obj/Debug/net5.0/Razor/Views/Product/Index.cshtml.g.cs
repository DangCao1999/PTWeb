#pragma checksum "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84bdae6297cd2079c4ea7e1456e0cadc962a6880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84bdae6297cd2079c4ea7e1456e0cadc962a6880", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f52aa8fe25f395afd3d0eb2c5201af9c110b97", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Index.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div style=\"display: flex;\">\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 143, "\"", 164, 1);
#nullable restore
#line 11 "C:\Users\admin\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Index.cshtml"
WriteAttributeValue("", 149, Model.ImageUrl, 149, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product 2\" />\r\n    </div>\r\n    <div>\r\n        <p class=\"price\">Price: $350</p>\r\n        <p class=\"price\">Price: $350</p>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
