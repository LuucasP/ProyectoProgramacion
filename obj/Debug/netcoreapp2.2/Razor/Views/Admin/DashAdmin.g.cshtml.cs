#pragma checksum "C:\Users\equipo\Desktop\CommitsJorge\ProyectoProgramacion\Views\Admin\DashAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6782f7b2808f44b5489d6ce994f93d0127c21d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DashAdmin), @"mvc.1.0.view", @"/Views/Admin/DashAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DashAdmin.cshtml", typeof(AspNetCore.Views_Admin_DashAdmin))]
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
#line 1 "C:\Users\equipo\Desktop\CommitsJorge\ProyectoProgramacion\Views\_ViewImports.cshtml"
using ProyProg;

#line default
#line hidden
#line 2 "C:\Users\equipo\Desktop\CommitsJorge\ProyectoProgramacion\Views\_ViewImports.cshtml"
using ProyProg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6782f7b2808f44b5489d6ce994f93d0127c21d07", @"/Views/Admin/DashAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643ecdd6b1e737d8ab4023cf1ea7b8c8ed695b03", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DashAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(29, 1031, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6782f7b2808f44b5489d6ce994f93d0127c21d073392", async() => {
                BeginContext(35, 1018, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Admin</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css"" integrity=""sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""../css/dashboard1.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css"">
    <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/solid.js"" integrity=""sha384-tzzSw1/Vo+0N5UhStP3bvwWPq+uvzCMfrN1fEFe+xBmv1C/AtVX5K0uZtmcHitFZ"" crossorigin=""anonymous""></script>
    <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/fontawesome.js"" integrity=""sha384-6OIrr52G08NpOFSZdxxz1xdNSndlD4vdcf/q2myIUVO0VsqaGHJsB0RaBE01VTOY"" crossorigin=""anonymous""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1060, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1064, 5598, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6782f7b2808f44b5489d6ce994f93d0127c21d075635", async() => {
                BeginContext(1070, 5585, true);
                WriteLiteral(@"

    <div class=""wrapper"">
        <!-- Sidebar  -->
        <nav id=""sidebar"">
            <div class=""sidebar-header"">
                <h3>Perú Sobre Ruedas</h3>
            </div>

            <ul class=""list-unstyled components"">
                <div class=""imgr"">
                <img src=""../img/user.jpg"">
            </div>  
                <p>Bienvenido </p>
                <li class=""active"" >
                    <a href=""#"">Home</a>
                    
                </li>
                   <li>
                    <a href=""#Destinos"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"">Destinos</a>
                    <ul class=""collapse list-unstyled"" id=""Destinos"">
                        <li>
                            <a href=""#"">Registrar Destino</a>
                        </li>
                        <li>
                            <a href=""#"">Actualizar Destino</a>
                        </li>
                        <li>
                 ");
                WriteLiteral(@"           <a href=""#"">Lista de Destino</a>
                        </li>
                    </ul>
                </li> 

                <li>
                    <a href=""#Clientes"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"">Clientes</a>
                    <ul class=""collapse list-unstyled"" id=""Clientes"">
                        <li>
                            <a href=""#"">Registrar Clientes</a>
                        </li>
                        <li>
                            <a href=""#"">Actualizar Clientes</a>
                        </li>
                        <li>
                            <a href=""#"">Lista de Clientes</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""#Tours"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"">Tours</a>
                    <ul class=""collapse list-unstyled"" id=""Tours"">
                        <li>
                 ");
                WriteLiteral(@"           <a href=""#"">Registrar Tour</a>
                        </li>
                        <li>
                            <a href=""#"">Actualizar Tours</a>
                        </li>
                        <li>
                            <a href=""#"">Lista de Tours</a>
                        </li>
                    </ul>
                </li>    


                <li>
                    <a href=""#Promociones"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle"">Promociones</a>
                    <ul class=""collapse list-unstyled"" id=""Promociones"">
                        <li>
                            <a href=""#"">Registrar Promoción</a>
                        </li>
                        <li>
                            <a href=""#"">Actualizar Promoción</a>
                        </li>
                        <li>
                            <a href=""#"">Lista de Promociones</a>
                        </li>
                    </ul>
                ");
                WriteLiteral(@"</li>  

                
            </ul>
        </nav>

        <!-- Page Content  -->
        <div id=""content"">

            <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                <div class=""container-fluid"">

                    <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info"">
                        <i class=""fas fa-align-left""></i>
                       
                    </button>
                    <button class=""btn btn-dark d-inline-block d-lg-none ml-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <i class=""fas fa-align-justify""></i>
                    </button>

                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""nav navbar-nav ml-auto"">
                          
                           
                     ");
                WriteLiteral(@"       <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Inicio</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Salir</a>
                            </li>
                        </ul>
                    </div>


                    

                </div>
            </nav>

            
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js"" integrity=""sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.concat.min.js""></script>

    <script ");
                WriteLiteral(@"type=""text/javascript"">
        $(document).ready(function () {
            $(""#sidebar"").mCustomScrollbar({
                theme: ""minimal""
            });

            $('#sidebarCollapse').on('click', function () {
                $('#sidebar, #content').toggleClass('active');
                $('.collapse.in').toggleClass('in');
                $('a[aria-expanded=true]').attr('aria-expanded', 'false');
            });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6662, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
