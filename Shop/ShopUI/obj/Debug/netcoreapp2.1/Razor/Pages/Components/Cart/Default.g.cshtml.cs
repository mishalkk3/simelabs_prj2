#pragma checksum "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "609b033ac7ec3251d4c61e545d1f462430cfdf9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShopUI.Pages.Components.Cart.Pages_Components_Cart_Default), @"mvc.1.0.view", @"/Pages/Components/Cart/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Components/Cart/Default.cshtml", typeof(ShopUI.Pages.Components.Cart.Pages_Components_Cart_Default))]
namespace ShopUI.Pages.Components.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\_ViewImports.cshtml"
using ShopUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"609b033ac7ec3251d4c61e545d1f462430cfdf9a", @"/Pages/Components/Cart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e127126d6f8aef4a77c903404155da71f799a762", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Cart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application.Cart.GetCart.Response>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 42, true);
            WriteLiteral("\r\n<div>\r\n    <h2>Big Cart Component</h2>\r\n");
            EndContext();
#line 9 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(152, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(164, 12, false);
#line 11 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(176, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(194, 13, false);
#line 12 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
      Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(207, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(225, 11, false);
#line 13 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
      Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(236, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(254, 15, false);
#line 14 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
      Write(product.StockId);

#line default
#line hidden
            EndContext();
            BeginContext(269, 22, true);
            WriteLiteral("</p>\r\n        <hr />\r\n");
            EndContext();
#line 16 "D:\project\Simlabs_miniProjrct2\project5\test4\Shop\ShopUI\Pages\Components\Cart\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(298, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application.Cart.GetCart.Response>> Html { get; private set; }
    }
}
#pragma warning restore 1591