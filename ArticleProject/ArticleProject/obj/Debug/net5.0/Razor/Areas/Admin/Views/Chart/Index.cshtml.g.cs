#pragma checksum "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e2adf4fbeefcf627c8c2cef35a2432f9ae3608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e2adf4fbeefcf627c8c2cef35a2432f9ae3608", @"/Areas/Admin/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb82a4fd9744727ae16f72e008300db2081dbe2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\asame\source\repos\ArticleProject\ArticleProject\Areas\Admin\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width:800px; height:600px"">
            <h1>burası chart alanıdır</h1>
        </div>
    </div>
</div>

<script type = ""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""> </script>

<script type=""text/javascript"">
    google.charts.load('current',{'packages':['corechart']});
    google.chart.SetOnLoadCallback(DrawonLoad);

    function DrawonLoad()
    {
        $function(){
            $.ajax({
                type:'GET',
                url:'/Admin/Chart/CategoryChart/',
                success:function(chartsdata){
                    var Data = chartsdata.jsonlist;
                    var data = new google.visualization.DataTable();

                    data.addColumn('string','categoryname');
                    data.addColumn('number','categorycount');

                    for(var i=0; i<Data.length;i++)
                    {
                        data.AddRow([Data[i].categoryname,Data[i].categorycount]);
 ");
            WriteLiteral(@"                   }
                    var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));

                    chart.draw(data,{
                        title:"" Google chart core projesi"",
                        position: ""top"",
                        fontsize: ""16px""
                    });
                }


            })
        }
    }
    


</script>
");
            DefineSection("scripts", async() => {
            }
            );
            WriteLiteral("\n");
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