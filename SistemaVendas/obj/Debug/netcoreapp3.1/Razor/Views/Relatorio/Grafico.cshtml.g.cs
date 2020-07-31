#pragma checksum "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\Relatorio\Grafico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31621716d606a057f1a1033b41432d72dbe0f2de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_Grafico), @"mvc.1.0.view", @"/Views/Relatorio/Grafico.cshtml")]
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
#line 1 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31621716d606a057f1a1033b41432d72dbe0f2de", @"/Views/Relatorio/Grafico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_Grafico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\Relatorio\Grafico.cshtml"
  
    ViewData["Title"] = "Gráfico";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.bundle.min.js""></script>

<h2>Total de Vendas por Produto</h2>
<br />

<canvas id=""myChart""></canvas>
<script>
    var ctx = document.getElementById('myChart').getContext('2d');
    var chart = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: [");
#nullable restore
#line 16 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\Relatorio\Grafico.cshtml"
                Write(Html.Raw(ViewBag.Labels));

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n            datasets: [{\r\n                backgroundColor: [");
#nullable restore
#line 18 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\Relatorio\Grafico.cshtml"
                             Write(Html.Raw(@ViewBag.Cores));

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                borderColor: \'#fff\',\r\n                data: [");
#nullable restore
#line 20 "C:\Users\miraduarte\Source\Repos\SistemaVendas\SistemaVendas\Views\Relatorio\Grafico.cshtml"
                  Write(Html.Raw(@ViewBag.Valores));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\r\n            }]\r\n        },\r\n        options: {}\r\n    });\r\n</script>");
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
