#pragma checksum "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\ModificarProyecto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8add91ee3d3eeb4a8479b295fc6476af2d92e81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyectos_ModificarProyecto), @"mvc.1.0.view", @"/Views/Proyectos/ModificarProyecto.cshtml")]
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
#line 1 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8add91ee3d3eeb4a8479b295fc6476af2d92e81f", @"/Views/Proyectos/ModificarProyecto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyectos_ModificarProyecto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\ModificarProyecto.cshtml"
  
    ViewData["Title"] = "ModificarProyecto";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card-box"">
                        <h4>Formulario de proyecto</h4>

                        <br />

                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""p-2"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8add91ee3d3eeb4a8479b295fc6476af2d92e81f4847", async() => {
                WriteLiteral(@"

                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""simpleinput"">Código</label>
                                            <div class=""col-md-10"">
                                                <input type=""text"" id=""simpleinput"" value=""01"" class=""form-control"" placeholder=""Digite el código"" required>
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""example-textarea"">Nombre del proyecto</label>
                                            <div class=""col-md-10"">
                                                <input type=""text"" id=""simpleinput"" value=""Reparación Techo"" class=""form-control"" placeholder=""Ingrese el nombre"" required>
                                            </div>
     ");
                WriteLiteral(@"                                   </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""example-textarea"">Descripción</label>
                                            <div class=""col-md-10"">
                                                <textarea class=""form-control"" rows=""5"" id=""example-textarea"" placeholder=""Ingrese la descripción"" required>Fondo para sustitución del zin</textarea>
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""example-textarea"">Nombre del responsable</label>
                                            <div class=""col-md-10"">
                                                <input type=""text"" id=""simpleinput"" value=""Kattia"" class=""form-control"" placeholder=""In");
                WriteLiteral(@"grese el nombre"" required>
                                            </div>
                                        </div>

                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""example-textarea"">Monto</label>
                                            <div class=""col-md-10"">
                                                <input type=""number"" id=""simpleinput"" value=""100000"" class=""form-control"" placeholder=""Digite el monto"" required>
                                            </div>
                                        </div>


                                        <div class=""form-group row"">
                                            <label class=""col-md-2 col-form-label"" for=""example-date"">Fecha de inicio</label>
                                            <div class=""col-md-10"">
                                                <input class=""form-control"" value=""25/03/2021"" id=""ex");
                WriteLiteral(@"ample-date"" type=""date"" name=""date"" required>
                                            </div>
                                        </div>



                                        <br />
                                        <div class=""form-group row"">
                                            <div class=""col-md-2"">

                                            </div>
                                            <div class=""col-md-10"">
                                                <input id=""btnActualizarProyecto"" type=""submit"" value=""Actualizar proyecto"" class=""btn btn-bordered-primary waves-effect  width-md waves-light"" onclick=""location.href='/Proyectos/Proyectos'"" />
                                                <input id=""btnEliminarProyecto"" type=""submit"" value=""Eliminar proyecto"" class=""btn btn-bordered-danger waves-effect  width-md waves-light"" />
                                            </div>
                                        </div>


                        ");
                WriteLiteral("            ");
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
