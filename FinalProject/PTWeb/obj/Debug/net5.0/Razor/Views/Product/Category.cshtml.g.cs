#pragma checksum "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64446a5e6e927bcce4683c21a89494e960c9654a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
#line 1 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64446a5e6e927bcce4683c21a89494e960c9654a", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f52aa8fe25f395afd3d0eb2c5201af9c110b97", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Our Products</h2>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
 foreach (var item in @Model.Select((value, i) => new { value, i }))
{
    Product product = item.value;
    int index = item.i;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
     if (++index % 3 == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product_box\">\r\n            <h3 class=\"name\">");
#nullable restore
#line 13 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <div class=\"image_wrapper\"> <a href=\"http://www.templatemo.com/page/3\" target=\"_parent\"><img");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 432, 1);
#nullable restore
#line 15 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
WriteAttributeValue("", 415, product.ImageUrl, 415, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product 4\" /></a> </div>\r\n\r\n            <p class=\"price\">Price: ");
#nullable restore
#line 17 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                               Write(String.Format("{0:n0}",product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 561, "\"", 594, 2);
            WriteAttributeValue("", 568, "/product/index/", 568, 15, true);
#nullable restore
#line 18 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
WriteAttributeValue("", 583, product.Id, 583, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a> | <a class=\"btn-buy\" data-id=\"");
#nullable restore
#line 18 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                                                                                     Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">Buy Now</a>\r\n        </div>\r\n        <div class=\"cleaner\"></div>\r\n");
#nullable restore
#line 21 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product_box margin_r35\">\r\n\r\n            <h3 class=\"name\">");
#nullable restore
#line 26 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <div class=\"image_wrapper\"> <a href=\"http://www.templatemo.com/page/1\" target=\"_parent\"><img");
            BeginWriteAttribute("src", " src=\"", 952, "\"", 975, 1);
#nullable restore
#line 28 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
WriteAttributeValue("", 958, product.ImageUrl, 958, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product 2\" /></a> </div>\r\n\r\n            <p class=\"price\">Price: ");
#nullable restore
#line 30 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                               Write(String.Format("{0:n0}",product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1137, 2);
            WriteAttributeValue("", 1111, "/product/index/", 1111, 15, true);
#nullable restore
#line 31 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
WriteAttributeValue("", 1126, product.Id, 1126, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a> | <a class=\"btn-buy\" data-id=\"");
#nullable restore
#line 31 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
                                                                                     Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">Buy Now</a>\r\n\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Category.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>


    jQuery(document).ready(function () {
                    jQuery("".btn-buy"").click(function () {
                        //console.log(jQuery(this).data(""id""));
                        jQuery.ajax({
                            method: ""POST"",
                            url: ""/Cart/AddToCart"",
                            data: {
                                id: jQuery(this).data(""id""),
                            },
                            success: function (data) {
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'Add new item success',
                                    showConfirmButton: false,
                                    timer: 1500
                                });
                                updateNumberCart();
                            },
                            error: function (data) {
    ");
                WriteLiteral(@"                            if(data.status == 401)
                                {
                                    Swal.fire({
                                    position: 'top-end',
                                    icon: 'warning',
                                    title: 'Add new item failed',
                                    text: ""You are not logged in!"",
                                    showConfirmButton: false,
                                    timer: 2500
                                    })
                                }
                                else{
                                    Swal.fire({
                                        position: 'top-end',
                                        icon: 'error',
                                        title: 'Add new item failed',
                                        text: 'Something went wrong!',
                                        showConfirmButton: false,
                                     ");
                WriteLiteral("   timer: 1500\r\n                                    })\r\n                                }\r\n                            }\r\n                        })\r\n                    })\r\n                });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
