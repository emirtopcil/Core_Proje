#pragma checksum "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7c77bbebc8e32c6b104317d4890ae1e80b2e58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_EditExperience), @"mvc.1.0.view", @"/Views/Experience/EditExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7c77bbebc8e32c6b104317d4890ae1e80b2e58", @"/Views/Experience/EditExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_EditExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
  
    ViewData["Title"] = "EditExperience";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
 using (Html.BeginForm("EditExperience", "Experience", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.HiddenFor(x=>x.ExperienceID));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"">Deneyim Düzenleme Sayfası</h4>
                <div class=""forms-sample"">
                    <div class=""form-group"">
                        <label for=""exampleInputName1"">Şirket Adı</label>
                        ");
#nullable restore
#line 17 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
                   Write(Html.TextBoxFor(x=>x.Name , new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Tarih Aralığı</label>\r\n                        ");
#nullable restore
#line 21 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
                   Write(Html.TextBoxFor(x=>x.Date , new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Fotoğraf Yolu</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
                   Write(Html.TextBoxFor(x=>x.ImageUrl , new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Açıklama</label>\r\n                        ");
#nullable restore
#line 29 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
                   Write(Html.TextBoxFor(x=>x.Description , new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <button type=""submit"" class=""btn btn-primary mr-2"">Gönder</button>
                    <a href=""/Experience/Index"" class=""btn btn-dark"">İptal</a>

                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 38 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591