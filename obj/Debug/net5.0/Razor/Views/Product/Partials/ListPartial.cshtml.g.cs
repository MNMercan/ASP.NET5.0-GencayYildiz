#pragma checksum "C:\Users\yazilim.park10\source\repos\OrnekUygulama\OrnekUygulama\Views\Product\Partials\ListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ad5f84d98f26b35720c8a962565b6e4ea4a59b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Partials_ListPartial), @"mvc.1.0.view", @"/Views/Product/Partials/ListPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ad5f84d98f26b35720c8a962565b6e4ea4a59b", @"/Views/Product/Partials/ListPartial.cshtml")]
    public class Views_Product_Partials_ListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrnekUygulama.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Urun listesi</h3>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\yazilim.park10\source\repos\OrnekUygulama\OrnekUygulama\Views\Product\Partials\ListPartial.cshtml"
Write(ViewBag.Mesaj);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrnekUygulama.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
