#pragma checksum "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4c8312502c318c683d5c816d31fe656d648593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SlideList/Default.cshtml")]
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
#line 1 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4c8312502c318c683d5c816d31fe656d648593", @"/Views/Shared/Components/SlideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SlideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Portfolio Fotoğrafları</h4>\r\n        <div class=\"owl-carousel owl-theme full-width owl-carousel-dash portfolio-carousel\" id=\"owl-carousel-basic\">\r\n");
#nullable restore
#line 8 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 398, "\"", 418, 1);
#nullable restore
#line 11 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
WriteAttributeValue("", 404, item.ImageUrl, 404, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 419, "\"", 425, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:470px; height:300px;\">\r\n                </div>\r\n");
#nullable restore
#line 13 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""d-flex py-4"">
            <div class=""preview-list w-100"">
                <div class=""preview-item p-0"">
                    <div class=""preview-thumbnail"">
                        <img src=""/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face12.jpg"" class=""rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 853, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""preview-item-content d-flex flex-grow"">
                        <div class=""flex-grow"">
                            <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                <h6 class=""preview-subject"">Bas Ulan Bass</h6>
                            </div>
                            <p class=""text-muted"">Well, it seems to be working now.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""progress progress-md portfolio-progress"">
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
