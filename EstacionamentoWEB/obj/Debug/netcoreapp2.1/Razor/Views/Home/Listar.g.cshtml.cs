#pragma checksum "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc929710fe5dcbf03424d7a45f848e2be28e5e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar), @"mvc.1.0.view", @"/Views/Home/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Listar.cshtml", typeof(AspNetCore.Views_Home_Listar))]
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
#line 1 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\_ViewImports.cshtml"
using EstacionamentoWEB;

#line default
#line hidden
#line 1 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
using EstacionamentoWEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc929710fe5dcbf03424d7a45f848e2be28e5e34", @"/Views/Home/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c903ab7a4d39a2dd466885274210f834e94c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
  
    Layout = "Masterpage";
    ViewBag.Title = "Lista de Cadastros";

#line default
#line hidden
            BeginContext(113, 377, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nome Usuário</th>
            <th scope=""col"">Modelo do Carro</th>
            <th scope=""col"">Marca do Carro</th>
            <th scope=""col"">Placa do Carro</th>
            <th scope=""col"">Momento da entrada</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
     foreach (var item in ViewData["entrada"] as List<Entrada>) {

#line default
#line hidden
            BeginContext(557, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(588, 7, false);
#line 21 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(595, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(619, 12, false);
#line 22 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.Usuario);

#line default
#line hidden
            EndContext();
            BeginContext(631, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(655, 10, false);
#line 23 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(665, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(689, 11, false);
#line 24 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.Modelo);

#line default
#line hidden
            EndContext();
            BeginContext(700, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(724, 10, false);
#line 25 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.Placa);

#line default
#line hidden
            EndContext();
            BeginContext(734, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(758, 16, false);
#line 26 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
           Write(item.DataEntrada);

#line default
#line hidden
            EndContext();
            BeginContext(774, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\43127523890\Documents\WEBmvc\EstacionamentoWEB\Views\Home\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(803, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
