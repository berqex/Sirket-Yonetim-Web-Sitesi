#pragma checksum "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c66ff3d737cd599413580b1cdba32cee5a89e294011d78f5bb173cdd7483cace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_PageDepartman), @"mvc.1.0.view", @"/Views/Depart/PageDepartman.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depart/PageDepartman.cshtml", typeof(AspNetCore.Views_Depart_PageDepartman))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c66ff3d737cd599413580b1cdba32cee5a89e294011d78f5bb173cdd7483cace", @"/Views/Depart/PageDepartman.cshtml")]
    public class Views_Depart_PageDepartman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
  
    ViewData["Title"] = "PageDepartman";
    Layout = "~/Views/Depart/Index.cshtml";

#line default
#line hidden

            BeginContext(217, 487, true);
            WriteLiteral(@"
<h2>Departman Listesi</h2>

<div class=""col-lg-12"" style=""text-align:right"">
    <a href=""/Depart/YeniDepartman"" class=""btn btn-success"">Yeni Departman Ekle</a>
</div>

<hr />

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Departman Adı</th>
            <th>Departman Detay</th>
            <th style=""width:100px"">Güncelle</th>
            <th style=""width:100px"">Sil</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden

            BeginContext(753, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(792, 7, false);
            Write(
#line 31 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
                     item.ID

#line default
#line hidden
            );
            EndContext();
            BeginContext(799, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(827, 16, false);
            Write(
#line 32 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
                     item.DepartmanAd

#line default
#line hidden
            );
            EndContext();
            BeginContext(843, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(871, 10, false);
            Write(
#line 33 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
                     item.Detay

#line default
#line hidden
            );
            EndContext();
            BeginContext(881, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 910, "\"", 955, 2);
            WriteAttributeValue("", 917, "/Depart/GuncelleDepartman/?ID=", 917, 30, true);
            WriteAttributeValue("", 947, 
#line 34 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
                                                            item.ID

#line default
#line hidden
            , 947, 8, false);
            EndWriteAttribute();
            BeginContext(956, 68, true);
            WriteLiteral(" class=\"btn btn-primary\"> Güncelle</a> </td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1064, 2);
            WriteAttributeValue("", 1031, "/Depart/SilDepartman/?ID=", 1031, 25, true);
            WriteAttributeValue("", 1056, 
#line 35 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
                                                       item.ID

#line default
#line hidden
            , 1056, 8, false);
            EndWriteAttribute();
            BeginContext(1065, 59, true);
            WriteLiteral(" class=\"btn btn-danger\"> Sil</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Berke\source\repos\proje\proje\Views\Depart\PageDepartman.cshtml"
        }

#line default
#line hidden

            BeginContext(1135, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
