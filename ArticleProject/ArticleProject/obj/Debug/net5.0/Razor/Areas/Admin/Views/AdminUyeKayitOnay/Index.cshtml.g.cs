#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89744e5fe4caec5bdbbd229f4f3d51decd2eaed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUyeKayitOnay_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUyeKayitOnay/Index.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\_ViewImports.cshtml"
using ArticleProject.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\_ViewImports.cshtml"
using ArticleProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89744e5fe4caec5bdbbd229f4f3d51decd2eaed4", @"/Areas/Admin/Views/AdminUyeKayitOnay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb82a4fd9744727ae16f72e008300db2081dbe2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminUyeKayitOnay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Ad soyad</th>
      <th scope=""col"">kullan??c?? Ad??</th>
      <th scope=""col"">Mail</th>
      <th scope=""col"">Aktif Yap</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 19 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
     foreach(var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
                 Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 23 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
     Write(i.namesurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 24 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
     Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
     Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 581, "\"", 627, 2);
            WriteAttributeValue("", 588, "/Admin/AdminUyeKayitOnay/AktifYap/", 588, 34, true);
#nullable restore
#line 26 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
WriteAttributeValue("", 622, i.Id, 622, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">aktif yap</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminUyeKayitOnay\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
