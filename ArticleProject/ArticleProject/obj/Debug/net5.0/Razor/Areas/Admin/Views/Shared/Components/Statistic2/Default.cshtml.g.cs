#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f4670e08d87d7c037c70f595c38e397f274b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f4670e08d87d7c037c70f595c38e397f274b3c", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb82a4fd9744727ae16f72e008300db2081dbe2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  
<div class=""row"">
            <div class=""col-lg-6"">
                <div class=""widget navy-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">Dashboard</h1>

                        <h3 class=""font-bold no-margins"">
                            kali linux
                        </h3>
                        <small>Bu kısım admin hakkında kısmıdır admin hakkında bilgiler gelecektr</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart1""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""widget lazur-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">Son Blog</h1>

                        <h3 class=""font-bold no-margins"">
                            ");
#nullable restore
#line 24 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
                       Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <small>Tüm Bloglar</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart2""></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3"">
                <div class=""widget yellw-bg no-padding"">
                    <div class=""p-m"">
                        <h1 class=""m-xs"">$ 50,992</h1>

                        <h3 class=""font-bold no-margins"">
                            Half-year revenue margin
                        </h3>
                        <small>Sales marketing.</small>
                    </div>
                    <div class=""flot-chart"">
                        <div class=""flot-chart-content"" id=""flot-chart3""></div>
                    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
