#pragma checksum "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2ec5416823ac84f4fdd3430219d5b59175fa50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Editar), @"mvc.1.0.view", @"/Views/Usuario/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Editar.cshtml", typeof(AspNetCore.Views_Usuario_Editar))]
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
#line 1 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
using EX2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2ec5416823ac84f4fdd3430219d5b59175fa50", @"/Views/Usuario/Editar.cshtml")]
    public class Views_Usuario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
  
    Layout = "Masterpage";
    ViewBag.Title = "Editar de Usuarios";
    UsuarioModel usuario = ViewBag.usuario;
    string dataDeNascimento = usuario.DataNascimento.ToString("yyyy-MM-dd");

#line default
#line hidden
            BeginContext(221, 73, true);
            WriteLiteral("\r\n<form action=\"/Usuario/Editar\" method=\"POST\">\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 294, "\"", 313, 1);
#line 10 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 302, usuario.Id, 302, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(314, 66, true);
            WriteLiteral(" name=\"id\">\r\n    <label>\r\n        Nome\r\n        <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value = \"", 380, "\"", 403, 1);
#line 13 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 390, usuario.Nome, 390, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 83, true);
            WriteLiteral(" name=\"nome\">\r\n    </label>\r\n    <label>\r\n        Email\r\n        <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value = \"", 487, "\"", 511, 1);
#line 17 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 497, usuario.Email, 497, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(512, 88, true);
            WriteLiteral(" name=\"email\">\r\n    </label>\r\n    <label>\r\n        Senha\r\n        <input type=\"password\"");
            EndContext();
            BeginWriteAttribute("value", " value = \"", 600, "\"", 624, 1);
#line 21 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 610, usuario.Senha, 610, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(625, 97, true);
            WriteLiteral(" name=\"senha\">\r\n    </label>\r\n    <label>\r\n        Data de Nascimento\r\n        <input type=\"date\"");
            EndContext();
            BeginWriteAttribute("value", " value = \"", 722, "\"", 749, 1);
#line 25 "C:\Users\43127523890\Documents\WEBmvc\EX2\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 732, dataDeNascimento, 732, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(750, 90, true);
            WriteLiteral(" name=\"dataDeNascimento\">\r\n    </label>\r\n    <input type=\"submit\" value=\"Editar\">\r\n</form>");
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
