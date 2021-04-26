#pragma checksum "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3df220be306a8b46a23759b9f4c5190ac5aafd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3df220be306a8b46a23759b9f4c5190ac5aafd", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVendas.Entidades.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h2>Categorias</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:#f6f6f6"">
            <th>Código</th>
            <th>Nome</th>
            <th>CNPJ/CPF</th>
            <th>Email</th>
            <th>Celular</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 498, "\"", 528, 3);
            WriteAttributeValue("", 508, "Editar(", 508, 7, true);
#nullable restore
#line 24 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 515, item.Codigo, 515, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 527, ")", 527, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\">\r\n                    <td>");
#nullable restore
#line 25 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.CNPJ_CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "E:\Projetos\SistemaVenda\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<br />
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Cadastrar Cliente</button>

<script>

    function Editar(Codigo) {
        window.location = window.origin + ""\\Cliente\\Cadastro\\"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""\\Cliente\\Cadastro"";
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVendas.Entidades.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
