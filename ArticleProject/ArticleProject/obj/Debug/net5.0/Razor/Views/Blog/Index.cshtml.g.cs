#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65938208e4f970f3d89f3022833e6555ad7eee71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\_ViewImports.cshtml"
using ArticleProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\_ViewImports.cshtml"
using ArticleProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65938208e4f970f3d89f3022833e6555ad7eee71", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0045e3d9d379dd8f1a734686ddf9746f71ec8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<section class=\"main-content-w3layouts-agileits\">\n\t\t<div class=\"container\">\n");
            WriteLiteral("\t\t\t<div class=\"inner-sec\">\n\t\t\t\t<!--left-->\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\n\t\t\t\t\t<div class=\"row\">\n");
#nullable restore
#line 17 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                         foreach(var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\n\t\t\t\t\t\t\t<a href=\"single.html\">\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65938208e4f970f3d89f3022833e6555ad7eee714918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 507, "~/BlogImg/", 507, 10, true);
#nullable restore
#line 21 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 517, item.BlogImgurl, 517, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t<div class=\"card-body\">\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\n\t\t\t\t\t\t\t\t\t<li>\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 27 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                                           Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t  <li class=\"mx-2\" id=\"begeni\">\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 902, "\"", 937, 2);
            WriteAttributeValue("", 909, "/Blog/BlogBegen/", 909, 16, true);
#nullable restore
#line 30 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 925, item.BlogID, 925, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <i class=\"far fa-thumbs-up\"></i> ");
#nullable restore
#line 31 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                                            Write(item.Begeni_Sayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Beğeni
                                            </a>
                                        </li>
									<li class=""mx-2"">
										<a href=""#"">
											<i class=""far fa-comment""></i> 21</a>
									</li>
									<li>
										<a href=""#"">
											<i class=""fas fa-eye""></i>");
#nullable restore
#line 40 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                                 Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t<li>\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1405, "\"", 1444, 2);
            WriteAttributeValue("", 1412, "/Blog/YazarDetay/", 1412, 17, true);
#nullable restore
#line 43 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1429, item.AppUserId, 1429, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i>");
#nullable restore
#line 44 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                                 Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t</li>\n\n\t\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1621, 2);
            WriteAttributeValue("", 1591, "/Blog/BlogReadAll/", 1591, 18, true);
#nullable restore
#line 49 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1609, item.BlogID, 1609, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t</h5>\n\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 51 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,20).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1786, "\"", 1823, 2);
            WriteAttributeValue("", 1793, "/Blog/BlogReadAll/", 1793, 18, true);
#nullable restore
#line 52 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1811, item.BlogID, 1811, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\t\n");
#nullable restore
#line 55 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Blog\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\n\t\t\t\t\t<!--//left-->\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
