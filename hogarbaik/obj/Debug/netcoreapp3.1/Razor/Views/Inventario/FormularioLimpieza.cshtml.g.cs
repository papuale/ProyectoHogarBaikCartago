#pragma checksum "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89cb515057d072ee0552b6682ffe465d50f3270e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_FormularioLimpieza), @"mvc.1.0.view", @"/Views/Inventario/FormularioLimpieza.cshtml")]
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
#line 1 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cb515057d072ee0552b6682ffe465d50f3270e", @"/Views/Inventario/FormularioLimpieza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_FormularioLimpieza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
  
    ViewData["Title"] = "Formulario Inventario";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Start Page Content here -->\r\n<!-- ============================================================== -->\r\n<br />\r\n");
#nullable restore
#line 12 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
 using (Html.BeginForm("AgregarLimpieza", "Inventario", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content-page\">\r\n        <div class=\"content\">\r\n\r\n            <!-- Start Content-->\r\n            <div class=\"container-fluid\">\r\n");
#nullable restore
#line 19 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
                 if (@ViewBag.MensajeAgregar != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"alert alert-success\">");
#nullable restore
#line 21 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
                                               Write(ViewBag.MensajeAgregar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card-box"">
                            <h4>Formulario Inventario Limpieza</h4>

                            <br />

                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""p-2"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cb515057d072ee0552b6682ffe465d50f3270e6339", async() => {
                WriteLiteral(@"

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""simpleinput"">Código</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Digite el código"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Descripción</label>
                                                <div class=""col-md-10"">
                                                    <textarea class=""form-control"" rows=""5"" id=""example-textarea"" placeholder=""Ingrese la descripción"" required></textarea>
                                        ");
                WriteLiteral(@"        </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Cantidad</label>
                                                <div class=""col-md-10"">
                                                    <input type=""number"" id=""simpleinput"" class=""form-control"" placeholder=""Digite la cantidad"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-date"">Fecha de Ingreso</label>
                                                <div class=""col-md-10"">
                                                    <input class=""form-control"" id=""example-date"" type=""date"" name=""date"" required>
  ");
                WriteLiteral(@"                                              </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""simpleinput"">Nombre de persona que entrega</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el nombre"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""simpleinput"">Nombre de persona que recibe</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id");
                WriteLiteral(@"=""simpleinput"" class=""form-control"" placeholder=""Ingrese el nombre"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""simpleinput"">Adquisición</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese la adquisición"" required>
                                                </div>
                                            </div>


                                            <br />
                                            <div class=""form-group row"">
                                                <div class=""col-md-2"">

                                                </div>
                                     ");
                WriteLiteral(@"           <div class=""col-md-10"">
                                                    <input id=""Submit1"" type=""submit"" value=""Agregar"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" />
                                                </div>
                                            </div>


                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

                            </div>
                            <!-- end row -->

                        </div> <!-- end card-box -->
                    </div><!-- end col -->
                </div>
                <!-- end row -->
            </div> <!-- container-fluid -->

        </div> <!-- content -->


    </div>
");
            WriteLiteral("    <!-- ============================================================== -->\r\n    <!-- End Page content -->\r\n    <!-- ============================================================== -->\r\n");
#nullable restore
#line 117 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\FormularioLimpieza.cshtml"
}

#line default
#line hidden
#nullable disable
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
