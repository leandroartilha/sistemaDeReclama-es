#pragma checksum "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d1b7683e2819eae9cf124b61df33e3d22e28c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d1b7683e2819eae9cf124b61df33e3d22e28c8", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d626a5daccbd8ca12869e6c2930e8a11b8a69d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NovoRad.Models.Usuario>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Gestão de Usuários</h1>

<table class=""table"" id=""myTable"">
    <thead>
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Cpf</th>
            <th scope=""col"">Inativo</th>
            <th scope=""col"">Área</th>
            <th scope=""col"">Botao Editar</th>
            

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NomeUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Inativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Area.NomeArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2d1b7683e2819eae9cf124b61df33e3d22e28c86367", async() => {
                WriteLiteral(@"
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pen"" viewBox=""0 0 16 16"">
                        <path d=""m13.498.795.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001zm-.644.766a.5.5 0 0 0-.707 0L1.95 11.756l-.764 3.057 3.057-.764L14.44 3.854a.5.5 0 0 0 0-.708l-1.585-1.585z"" />
                    </svg>               
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
                                       WriteLiteral(item.UsuarioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Usuarios\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NovoRad.Models.Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591