#pragma checksum "C:\Users\diego\Desktop\ProyectoProgra1\Views\Home\Iniciar Sesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1487e865687e37644f35185ae6c53f6e3d6c3efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Iniciar_Sesion), @"mvc.1.0.view", @"/Views/Home/Iniciar Sesion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Iniciar Sesion.cshtml", typeof(AspNetCore.Views_Home_Iniciar_Sesion))]
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
#line 1 "C:\Users\diego\Desktop\ProyectoProgra1\Views\_ViewImports.cshtml"
using ProyectoProgra1;

#line default
#line hidden
#line 2 "C:\Users\diego\Desktop\ProyectoProgra1\Views\_ViewImports.cshtml"
using ProyectoProgra1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1487e865687e37644f35185ae6c53f6e3d6c3efd", @"/Views/Home/Iniciar Sesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db325c9121ba02ce3da9e90cff0d90d5cb89adcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Iniciar_Sesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 1374, true);
            WriteLiteral(@"

<div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 col-md-offset-4"">
                        <div class=""login-panel panel panel-default"">
                            <div class=""panel-heading"">
                                <h3 class=""panel-title"">Ingrese sus datos</h3>
                            </div>
                            <div class=""panel-body"">
                                <fieldset>
                                    <div class=""form-group"">
                                        <input class=""form-control"" placeholder=""Usuario"" name=""usuario"" type=""text"" autofocus id=""txtUsuario"">
                                    </div>
                                    <div class=""form-group"">
                                        <input class=""form-control"" placeholder=""Password"" name=""password"" type=""password"" id=""txtPassword"">
                                    </div>
                                    <!-- Change this to a b");
            WriteLiteral(@"utton or input when using this as a form -->
                                    <button id=""btnIngresar"" class=""btn btn-lg btn-success btn-block"">Ingresar</button>
                                </fieldset>
                            </div>
                        </div>
                    </div>
                </div>
            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591