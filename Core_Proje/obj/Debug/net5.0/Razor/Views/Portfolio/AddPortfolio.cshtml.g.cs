#pragma checksum "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f074bcabad68d67293b8726bd2417654528b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f074bcabad68d67293b8726bd2417654528b4e", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row mt-5"">
        <div class=""col"">
            <div class=""card bg-default shadow"">
                <div class=""card-header bg-transparent border-0 text-center"">
                    <h3 class=""text-white mb-0"">Deneyim Ekleme Sayfası</h3>
                </div>
                <div class=""table-responsive"">
                    <div class=""form-group text-white ml-3 mr-3"">
                        ");
#nullable restore
#line 18 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.Label("Proje Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.TextBoxFor(x=>x.Name , new { @class="form-control"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.ValidationMessageFor(x=>x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 22 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.Label("Proje Fotoğrafı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.TextBoxFor(x=>x.ImageUrl , new{ @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.ValidationMessageFor(x=>x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 26 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.Label("Proje Küçük Fotoğrafı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.TextBoxFor(x=>x.ImageUrl2 , new{ @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.ValidationMessageFor(x=>x.ImageUrl2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 30 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.Label("Proje Sitesi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.TextBoxFor(x=>x.ProjectUrl , new{ @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.ValidationMessageFor(x=>x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 34 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.Label("Proje Ücreti"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 35 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.TextBoxFor(x=>x.Price , new{ @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 36 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
                   Write(Html.ValidationMessageFor(x=>x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Deneyim Ekle</button>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
