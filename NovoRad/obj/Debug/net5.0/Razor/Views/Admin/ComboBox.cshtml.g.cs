#pragma checksum "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b195c7cd08198d04c56904e984523f4d8816de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ComboBox), @"mvc.1.0.view", @"/Views/Admin/ComboBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b195c7cd08198d04c56904e984523f4d8816de", @"/Views/Admin/ComboBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d626a5daccbd8ca12869e6c2930e8a11b8a69d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ComboBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComboBoxViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Digite o nome..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Digite o prazo..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateClassificacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
  
    ViewData["Title"] = "ComboBox";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ComboBox</h1>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card\" style=\"width: 30rem;\">\r\n            <h2 class=\"card-img-top\">Classificação</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b195c7cd08198d04c56904e984523f4d8816de6333", async() => {
                WriteLiteral("\r\n                <h5 class=\"card-title\">Adicionar nova classificação</h5>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51b195c7cd08198d04c56904e984523f4d8816de6685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 14 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Class.ClassificacaoId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51b195c7cd08198d04c56904e984523f4d8816de8606", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 15 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Class.ClassificacaoId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Adicionar\" />\r\n                <a href=\"#\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\">Visualizar Itens</a>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""card-body"">
");
#nullable restore
#line 33 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                         foreach (var item in Model.Classificacao)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card p-3 m-1\">\r\n                                <div class=\"d-flex mb-2\">\r\n                                    <h6 class=\"card-title\">");
#nullable restore
#line 37 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <h6 class=\"card-subtitle mb-2 text-muted\">Prazo: ");
#nullable restore
#line 39 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Prazo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"card-subtitle mb-2 text-muted\">Inativo? ");
#nullable restore
#line 40 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.Inativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n");
#nullable restore
#line 42 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>







    <div class=""col"">
        <div class=""card"" style=""width: 30rem;"">
            <h2 class=""card-img-top"">Área Demandante</h2>
            <div class=""card-body"">
                <h5 class=""card-title"">Adicionar nova área demandante</h5>
                <input placeholder=""Digite o nome da área demandante..."" class=""mb-1"" style=""width: 24rem;"" />
                <a href=""#"" class=""btn btn-primary"">Adicionar</a>
                <a href=""#"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalArea"">Visualizar Itens</a>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""exampleMod");
            WriteLiteral(@"alArea"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""card-body"">
");
#nullable restore
#line 84 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                     foreach (var item in Model.AreaDemandante)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card p-3 m-1\">\r\n                            <div class=\"d-flex mb-2\">\r\n                                <h6 class=\"card-title\">");
#nullable restore
#line 88 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <h6 class=\"card-subtitle mb-2 text-muted\">Inativo? ");
#nullable restore
#line 90 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Inativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n");
#nullable restore
#line 92 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>








<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 30rem;"">
            <h2 class=""card-img-top"">Ambiente</h2>
            <div class=""card-body"">
                <h5 class=""card-title"">Adicionar novo ambiente</h5>
                <input placeholder=""Digite o nome do ambiente ..."" class=""mb-1"" style=""width: 24rem;"" />
                <a href=""#"" class=""btn btn-primary"">Adicionar</a>
                <a href=""#"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalAmbiente"">Visualizar Itens</a>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""exampleModalAmbiente"" tabindex=""-1"" role=""dia");
            WriteLiteral(@"log"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""card-body"">
");
#nullable restore
#line 135 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                         foreach (var item in Model.Ambiente)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card p-3 m-1\">\r\n                                <div class=\"d-flex mb-2\">\r\n                                    <h6 class=\"card-title\">");
#nullable restore
#line 139 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <h6 class=\"card-subtitle mb-2 text-muted\">Inativo? ");
#nullable restore
#line 141 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.Inativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n");
#nullable restore
#line 143 "C:\Users\40414403\Documents\MovieFront\NovoRad (2)\NovoRad\NovoRad\Views\Admin\ComboBox.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>









");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComboBoxViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591