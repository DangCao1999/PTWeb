#pragma checksum "C:\Users\PC\Desktop\PTWebHoc\FinalProject\PTWeb\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6d168e2e83b999b6a98a7b096a957dbc531dd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\PTWebHoc\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\PTWebHoc\FinalProject\PTWeb\Views\_ViewImports.cshtml"
using PTWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6d168e2e83b999b6a98a7b096a957dbc531dd2", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f52aa8fe25f395afd3d0eb2c5201af9c110b97", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"content_section\">\r\n\r\n    <h2>Your Products</h2>\r\n    <table id=\"customers\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n");
            WriteLiteral(@"                <th scope=""col"">Name</th>
                <th scope=""col"">Image</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Promation Price</th>
                <th scope=""col"">Quantity</th>
                <th scope=""col"">Sub Total</th>
                <th scope=""col""></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody id=""tbody"">
        </tbody>
    </table>

    <div style=""display: flex; justify-content: flex-end;"">
        <a");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 756, 1);
#nullable restore
#line 25 "C:\Users\PC\Desktop\PTWebHoc\FinalProject\PTWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 726, Url.Action("CheckOut","Cart"), 726, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Check out</a>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>


        // jQuery
        //------------Get------------------
        function getCart() {
            jQuery.ajax({
                url: ""/Cart/GetCart"",
                method: ""GET"",
                success: function (rs) {
                    //console.log(rs);
                    //console.log(rs);

                    let obj = jQuery.parseJSON(rs);
                    let tbody = document.getElementById(""tbody"");
                    tbody.innerHTML = """";
                    obj.forEach(e => {
                        let product = e[""Product""];
                        console.log(product);
                        let tr = document.createElement(""tr"");
                        tr.innerHTML = `<td>${product.Name}</td>
                                                    <td><img src=""${product.ImageUrl}"" width=""60"" /> </td>
                                                    <td>${product.Price}.00</td>
                                                    <td>${product");
                WriteLiteral(@".PromotionPrice}.00</td>
                                                    <td>

                                                        <input id=""input-${product.Id}"" type=""number"" value=""${e.Quantity}"" min=""1"" max=""${product.Quantity}"">
                                                    </td>
                                                    <td>${product.Price}.00</td>
                                                    <td><button class=""button-remove"" onclick=""remove(${product.Id})"" data-id=""${product.Id}"">Remove</button></td>
                                                    <td><button class=""button-update"" onclick=""update(${product.Id})"" data-id=""${product.Id}"">Update</button></td>`;
                        tbody.appendChild(tr);
                    })
                }
            })
        }

        //-------------Remove--------------
        function remove(id) {
            Swal.fire({
                title: 'Are you sure?',
                text: ""You want remove it!"",");
                WriteLiteral(@"
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {
                    jQuery.ajax({
                        url: ""/Cart/RemoveCartItem/"" + id,
                        method: ""DELETE"",
                        success: function () {
                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
                                'success'
                            ).then((rs) => {
                                getCart();
                            });
                        },
                        error: function () {
                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
");
                WriteLiteral(@"                                'success'
                            )
                        }
                    })

                }
            })
        }
        //--------------Update-------------
        function update(id) {
            let quantity = jQuery(""#input-"" + id).val();
            jQuery.ajax({
                url: ""/Cart/UpdateCartItem"",
                method: ""PUT"",
                data: {
                    id: id,
                    quantity: quantity,
                },
                success: function () {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Update item success',
                        showConfirmButton: false,
                        timer: 1500
                    })
                    getCart();
                },
                error: function () {
                    Swal.fire({
                        position: 'top-end',
");
                WriteLiteral(@"                        icon: 'error',
                        title: 'Update failed',
                        showConfirmButton: false,
                        timer: 1500
                    })
                }
            })

        }

        //-------------Checkout------------
        //function checkOut() {
        //    jQuery.ajax({
        //        url: ""/Cart/CheckOut"",
        //        method: ""POST"",
        //        success: function (rs) {
        //            console.log(rs);
        //        }
        //    })
        //}

        jQuery(document).ready(function () {
            getCart();
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
