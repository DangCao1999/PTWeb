#pragma checksum "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae61a8a71086adf280b68e6bb7a5987d1518a4e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae61a8a71086adf280b68e6bb7a5987d1518a4e6", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f52aa8fe25f395afd3d0eb2c5201af9c110b97", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Our Products</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
 if (@Model.Count > 0)
{


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
     foreach (var item in @Model.Select((value, i) => new { value, i }))
    {
        Product product = item.value;
        int index = item.i;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
         if (++index % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product_box\">\r\n                <h3 class=\"name\">");
#nullable restore
#line 16 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                <div class=\"image_wrapper\"> <a href=\"http://www.templatemo.com/page/3\" target=\"_parent\"><img");
            BeginWriteAttribute("src", " src=\"", 474, "\"", 497, 1);
#nullable restore
#line 18 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
WriteAttributeValue("", 480, product.ImageUrl, 480, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product 4\" /></a> </div>\r\n\r\n                <p class=\"price\">Price: ");
#nullable restore
#line 20 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                                   Write(String.Format("{0:n0}",product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 634, "\"", 667, 2);
            WriteAttributeValue("", 641, "/product/index/", 641, 15, true);
#nullable restore
#line 21 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
WriteAttributeValue("", 656, product.Id, 656, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a> | <a class=\"btn-buy\" data-id=\"");
#nullable restore
#line 21 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                                                                                         Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">Buy Now</a>\r\n            </div>\r\n            <div class=\"cleaner\"></div>\r\n");
#nullable restore
#line 24 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product_box margin_r35\">\r\n\r\n                <h3 class=\"name\">");
#nullable restore
#line 29 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                <div class=\"image_wrapper\"> <a href=\"http://www.templatemo.com/page/1\" target=\"_parent\"><img");
            BeginWriteAttribute("src", " src=\"", 1057, "\"", 1080, 1);
#nullable restore
#line 31 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
WriteAttributeValue("", 1063, product.ImageUrl, 1063, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product 2\" /></a> </div>\r\n\r\n                <p class=\"price\">Price: ");
#nullable restore
#line 33 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                                   Write(String.Format("{0:n0}",product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1217, "\"", 1250, 2);
            WriteAttributeValue("", 1224, "/product/index/", 1224, 15, true);
#nullable restore
#line 34 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
WriteAttributeValue("", 1239, product.Id, 1239, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detail</a> | <a class=\"btn-buy\" data-id=\"");
#nullable restore
#line 34 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
                                                                                         Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">Buy Now</a>\r\n\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Not Found</h2>\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\PTWeb\FinalProject\PTWeb\Views\Product\Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
