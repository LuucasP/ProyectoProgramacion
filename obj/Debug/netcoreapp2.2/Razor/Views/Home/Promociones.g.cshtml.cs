#pragma checksum "C:\Users\equipo\Desktop\CommitsLucas\ProyectoProgramacion\Views\Home\Promociones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b6d1f498bb5bdd17c7531fdd8b8611650fcc7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Promociones), @"mvc.1.0.view", @"/Views/Home/Promociones.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Promociones.cshtml", typeof(AspNetCore.Views_Home_Promociones))]
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
#line 1 "C:\Users\equipo\Desktop\CommitsLucas\ProyectoProgramacion\Views\_ViewImports.cshtml"
using ProyProg;

#line default
#line hidden
#line 2 "C:\Users\equipo\Desktop\CommitsLucas\ProyectoProgramacion\Views\_ViewImports.cshtml"
using ProyProg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b6d1f498bb5bdd17c7531fdd8b8611650fcc7b", @"/Views/Home/Promociones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643ecdd6b1e737d8ab4023cf1ea7b8c8ed695b03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Promociones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3b6d1f498bb5bdd17c7531fdd8b8611650fcc7b3402", async() => {
                BeginContext(41, 497, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Inicio</title>
    <link rel=""stylesheet"" href=""css/Promociones.css"">
    <title>Promociones</title>
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
            BeginContext(545, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(547, 8238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3b6d1f498bb5bdd17c7531fdd8b8611650fcc7b5101", async() => {
                BeginContext(553, 8225, true);
                WriteLiteral(@"
        <!--Inicio-->
        <nav class=""navbar navbar-expand navbar-light"" style=""background-color: #ffffff;"">
          <a class=""navbar-nav"" href=""#"">
              <img src=""img/Perú_sobre_Ruedas1.png"" alt="""" width=""145"" height=""75"" class=""d-inline-block align-top"" alt="""">
          </a>
          <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
              <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
              <div class=""navbar-nav ml-auto"">
                <a class=""nav-item nav-link active"" href=""Inicio.html"">Inicio<span class=""sr-only"">(current)</span></a>
                <a class=""nav-item nav-link"" href=""Promociones.html"">Promociones</a>
                <a class=""nav-item nav-link"" href=""Register.html"">Registrarse</a>
                <a class=""n");
                WriteLiteral(@"av-item nav-link"" href=""Login2.html""  aria-disabled=""true"">Iniciar Sesión
              <!--    <img src=""img/usuario3.png"" width=""38"" height=""43"" class=""d-inline-block align-top"">-->
              </a>
            </div>
          </div>
        </nav>

      
      <div class=""nav2"">
              <center>¡No te pierdas la oportunidad de vivir una experiencia comletamnete diferente!</center>
      </div>
    <!--Inicio del contenedor-->
    <!--Inicio del contenedor-->
    <div class=""conte"">
        <div class=""container carta"">
          <h3>Destinos:</h3>
          <!--Inicio de Cards-->
          <div class=""card-group"">
            <div class=""card"">
              <img src=""img/lima-costa-verde.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""card-body"">
                <h5 class=""card-title"">Ruta Costa Verde</h5>
                <p class=""card-text"">Siendo que el litoral sur limeño desde la Provincia Constitucional del Callao hasta el distrito de Chorrillos se carac");
                WriteLiteral(@"teriza por contar con un elevado acantilado, la Costa Verde se caracteriza por ser la única vía que se encuentra debajo del barranco y adyacente a la orilla del Océano Pacífico.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
            <div class=""card"">
              <img src=""img/Pachacamac-Lima.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""card-body"">
                <h5 class=""card-title"">Ruta Pachacamac</h5>
                <p class=""card-text"">Pachacamac es el complejo arqueológico más grande e importante de Lima. Ocupa un área de 465.32 hectáreas, con un perímetro de 12 925.41 metros lineales, y es administrado por el Ministerio de Cultura. Cuenta con un museo y gabinetes para el análisis, registro y almacenaje del material.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
            <");
                WriteLiteral(@"div class=""card"">
              <img src=""img/plaza_san_martin1.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""card-body"">
                <h5 class=""card-title"">Ruta Plaza de San Martín</h5>
                <p class=""card-text"">La Plaza San Martín es una plaza ubicada en la cuadra 9 de la avenida Colmena dentro del centro histórico de Lima en la ciudad de Lima. En 1988 fue declarada Patrimonio de la Humanidad por la UNESCO ya que está considerada como uno de los espacios públicos más representativos de la ciudad de Lima, Perú.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
          </div>
  
          <br>
          <h3>Destinos por Provincia:</h3>
  
          <!--2da fila-->
          <div class=""segf"">
          <div class=""card-group"">
            <div class=""card"">
              <img src=""img/reserva_de_paracas7.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""");
                WriteLiteral(@"card-body"">
                <h5 class=""card-title"">Reserva Nacional de Paracas (Paracas)</h5>
                <p class=""card-text"">Paracas se ubica en el departamento de Ica y la provincia de Pisco en Perú. Por su cercanía al mar, Paracas es un balneario en forma de bahía. ... Paracas, abarca una superficie de 335,000 hectáreas, de las cuales 117,406 son de tierra firme y 217,594 de aguas marinas.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
            <div class=""card"">
              <img src=""img/plaza_de_arequipa7.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""card-body"">
                <h5 class=""card-title"">Plaza de Arequipa (Arequipa)</h5>
                <p class=""card-text"">Arequipa, la Ciudad Blanca. Arequipa está situado a una altura de 2325 m en las montañas del desierto de los Andes. Esta ciudad hermosa esta construido casi totalmente en sillar, una clase de piedra volcánic");
                WriteLiteral(@"a blanca. ... Con su un millón habitantes, Arequipa es la segunda ciudad más grande del Perú.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
            <div class=""card"">
              <img src=""img/plaza_de_chiclayo.jpg"" class=""card-img-top"" alt=""..."">
              <div class=""card-body"">
                <h5 class=""card-title""> Plaza de Chiclayo (Chiclayo)</h5>
                <p class=""card-text"">Chiclayo es una ciudad del noroeste peruano, capital de la provincia homónima y del departamento de Lambayeque. ... La ciudad fue fundada cerca de un importante sitio arqueológico antiguo, las ruinas del norte de Wari, que constituyen los restos de una ciudad desde el 7 al 12 de siglo Imperio Wari.</p>
                <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
              </div>
            </div>
          </div>
        </div>
        <br>
      </div>
       ");
                WriteLiteral(@"         <!--Fin 2da fila-->
          
              <!--Fin de Cards-->
            
              <div class=""container"">
                 
                <div class=""row"">
                  
                  <div class=""col carta2"">
                      <h3>Encuentranos</h3>
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3901.5768431457545!2d-76.94442838518715!3d-12.07260939145012!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x9105c6e79c730057%3A0x244c0d1a7cddcfbd!2sUSMP!5e0!3m2!1ses-419!2spe!4v1556946396615!5m2!1ses-419!2spe"" width=""100%"" height=""600"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
                  </div>
                </div>
              </div>
            </div>
    
            <!--Footer-->
    <footer>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6 "">
                        <img src=""img/logo.png"" width=""120"" height=""120"" alt="""">
        ");
                WriteLiteral(@"            </div>
    
                    <div class=""col-6"">
                        <h3>Contáctanos</h3>
                        
                            <li>+51 000 111 222</li>
                            <li>(01) 1112223</li>
                            <li>perusobreruedas@gmail.com</li>
                    </div>
                </div>
            </div>
        </footer>
        <!--Fin del Footer-->
    
    
        <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossori");
                WriteLiteral("gin=\"anonymous\"></script>\r\n    \r\n");
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
            BeginContext(8785, 9, true);
            WriteLiteral("\r\n</html>");
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