#pragma checksum "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4889940933d7f8e92fea49a029c7b421689b2ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\_ViewImports.cshtml"
using NovoRad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\_ViewImports.cshtml"
using NovoRad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\_ViewImports.cshtml"
using NovoRad.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4889940933d7f8e92fea49a029c7b421689b2ed0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d626a5daccbd8ca12869e6c2930e8a11b8a69d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoRad.Models.Ocorrencia>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<li>nome : ");
#nullable restore
#line 8 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
      Write(_ctx.HttpContext.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
<main class=""container py-3"">
    <section>
        <div class=""row"">
            <div class=""col-12 mt-3 mb-1"">
                <h4>Bem vindo ao Novo RAD!</h4>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xl-6 col-md-12"">
                <div class=""card overflow-hidden bg-primary text-white"">
                    <div class=""card-content"">
                        <div class=""card-body cleartfix"">
                            <div class=""media align-items-stretch"">
                                <div class=""align-self-center"">
                                    <i class=""icon-layers primary font-large-2 mr-2""></i>
                                </div>
                                <div class=""media-body"">
                                    <h4>Ocorrências</h4>
                                    <span>Total de ocorrências cadastradas</span>
                                </div>
                                <div class=""primary align");
            WriteLiteral("-self-center\">\r\n                                    <h1>");
#nullable restore
#line 30 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
                                   Write(TempData["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-6 col-md-12"">
                <div class=""card overflow-hidden"">
                    <div class=""card-content"">
                        <div class=""card-body cleartfix"">
                            <div class=""media align-items-stretch"">
                                <div class=""align-self-center"">
                                    <i class=""icon-hourglass danger font-large-2 mr-2""></i>
                                </div>
                                <div class=""media-body"">
                                    <h4>Apuração</h4>
                                    <span>Total de ocorrências em apuração</span>
                                </div>
                                <div class=""danger align-self-center"">
                                    <h1 class=""text-dange");
            WriteLiteral("r\">");
#nullable restore
#line 50 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
                                                       Write(TempData["OcorrenciasApuracao"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mt-3"">
            <div class=""col-xl-6 col-md-12"">
                <div class=""card overflow-hidden"">
                    <div class=""card-content"">
                        <div class=""card-body cleartfix"">
                            <div class=""media align-items-stretch"">
                                <div class=""align-self-center"">
                                    <i class=""icon-layers primary font-large-2 mr-2""></i>
                                </div>
                                <div class=""media-body"">
                                    <h4>Fila</h4>
                                    <span>Total de ocorrências em fila</span>
                                </div>
                                <div class=""primary align-self-center"">

                ");
            WriteLiteral("                    <h1 class=\"text-warning\">");
#nullable restore
#line 73 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
                                                        Write(TempData["OcorrenciasFila"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-6 col-md-12"">
                <div class=""card overflow-hidden"">
                    <div class=""card-content"">
                        <div class=""card-body cleartfix"">
                            <div class=""media align-items-stretch"">
                                <div class=""align-self-center"">
                                    <i class=""icon-layers primary font-large-2 mr-2""></i>
                                </div>
                                <div class=""media-body"">
                                    <h4>Concluídos</h4>
                                    <span>Total de ocorrências concluídas</span>
                                </div>
                                <div class=""primary align-self-center"">
                                    <h1 class=""text-suc");
            WriteLiteral("cess\">");
#nullable restore
#line 94 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
                                                        Write(TempData["OcorrenciasConcluido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

<script src=""sweetalert2.all.min.js""></script>



");
#nullable restore
#line 109 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
 if (TempData["UserName"] == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    Swal.fire({\r\n        title: \'Atenção!\',\r\n        text: \'Deseja Continuar?\',\r\n        icon: \'warning\',\r\n        confirmButtonText: \'SIM\'\r\n    })\r\n</script>\r\n");
#nullable restore
#line 119 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor _ctx { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovoRad.Models.Ocorrencia> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
