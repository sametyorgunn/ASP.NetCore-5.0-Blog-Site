#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc43335b0c8ca538bd7de65928eaca4db452a07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_HakkimizdaListele), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/HakkimizdaListele.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc43335b0c8ca538bd7de65928eaca4db452a07d", @"/Areas/Admin/Views/AdminBlog/HakkimizdaListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb82a4fd9744727ae16f72e008300db2081dbe2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminBlog_HakkimizdaListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
  
    ViewData["Title"] = "HakkimizdaListele";
    Layout = "~/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
  <thead>
    <tr>
      <th hidden scope=""col"">#</th>
      <th scope=""col"">Başlık</th>
      <th scope=""col""> içerik</th>
      <th scope=""col"">Resim</th>
      <th scope=""col"">düzenle</th>
      <th scope=""col"">Sil</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 20 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
     foreach(var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th hidden scope=\"row\">");
#nullable restore
#line 23 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
                        Write(i.AboutID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 24 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
     Write(i.Hakkimizda_baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
     Write(i.Hakkimizda_icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc43335b0c8ca538bd7de65928eaca4db452a07d5667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 631, "~/HakkimizdaResim/", 631, 18, true);
#nullable restore
#line 26 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
AddHtmlAttributeValue("", 649, i.Hakkimizda_resim_yol, 649, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n      <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 788, 2);
            WriteAttributeValue("", 743, "/Admin/AdminBlog/HakkimizdaDuzenle/", 743, 35, true);
#nullable restore
#line 27 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
WriteAttributeValue("", 778, i.AboutID, 778, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a></td>\r\n      <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 843, "\"", 891, 2);
            WriteAttributeValue("", 850, "/Admin/AdminBlog/HakkimizdaSil/", 850, 31, true);
#nullable restore
#line 28 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"
WriteAttributeValue("", 881, i.AboutID, 881, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\AdminBlog\HakkimizdaListele.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591