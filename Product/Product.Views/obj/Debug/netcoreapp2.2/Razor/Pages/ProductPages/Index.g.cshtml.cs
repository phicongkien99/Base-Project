#pragma checksum "C:\Users\drago\Desktop\Base-Project\Product\Product.Views\Pages\ProductPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25e206c0c73e0a5ae1a32bbdaffbb99d5e0ae74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Product.Views.Pages.ProductPages.Pages_ProductPages_Index), @"mvc.1.0.view", @"/Pages/ProductPages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/ProductPages/Index.cshtml", typeof(Product.Views.Pages.ProductPages.Pages_ProductPages_Index))]
namespace Product.Views.Pages.ProductPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\drago\Desktop\Base-Project\Product\Product.Views\Pages\_ViewImports.cshtml"
using Product.Views;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25e206c0c73e0a5ae1a32bbdaffbb99d5e0ae74", @"/Pages/ProductPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e34a7055a56888a9419b6a9eac168d486721465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProductPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\drago\Desktop\Base-Project\Product\Product.Views\Pages\ProductPages\Index.cshtml"
  
    ViewData["Title"] = "Products page";

#line default
#line hidden
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(68, 5, true);
                WriteLiteral(" \r\n\r\n");
                EndContext();
            }
            );
            BeginContext(76, 360, true);
            WriteLiteral(@"
<div class=""row"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th>Name</th>
                <th>Type</th>
                <th>Price</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            <tr>

            </tr>
        </tbody>
    </table>
</div>");
            EndContext();
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
