#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658f3c05ed1aa355bf9c6a64ff149c5af977432a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658f3c05ed1aa355bf9c6a64ff149c5af977432a", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0045e3d9d379dd8f1a734686ddf9746f71ec8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Bildirimler</th>\n        <th>Tarih</th>\n\n    </tr>\n");
#nullable restore
#line 15 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 18 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 22 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Views\Notification\AllNotification.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591