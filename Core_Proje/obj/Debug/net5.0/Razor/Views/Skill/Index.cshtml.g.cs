#pragma checksum "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc485d8d9ed7b3c2edf153ab127035b3f5e02a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc485d8d9ed7b3c2edf153ab127035b3f5e02a9", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title text-center"">Deneyimler </h4>
            <p class=""card-description"">
                <code></code>
            </p>
            <div class=""table-responsive"">
                <table class=""table table-dark"">
                    <thead>
                        <tr>
                            <th class=""text-light""> # </th>
                            <th class=""text-light""> Başlık </th>
                            <th class=""text-light""> Oran </th>
                            <th class=""text-light"">  Sil </th>
                            <th class=""text-light""> Güncelleme </th>
                        </tr>
                    </thead>
                    <tbody");
            BeginWriteAttribute("class", " class=\"", 973, "\"", 981, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 26 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                               Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1343, 2);
            WriteAttributeValue("", 1311, "/Skill/DeleteSkill/", 1311, 19, true);
#nullable restore
#line 32 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1330, item.SkillID, 1330, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1428, "\"", 1465, 2);
            WriteAttributeValue("", 1435, "/Skill/EditSkill/", 1435, 17, true);
#nullable restore
#line 33 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1452, item.SkillID, 1452, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\topci\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <a href=\"/Skill/AddSkill/\" class=\"btn btn-outline-info mt-3\">Deneyim Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
