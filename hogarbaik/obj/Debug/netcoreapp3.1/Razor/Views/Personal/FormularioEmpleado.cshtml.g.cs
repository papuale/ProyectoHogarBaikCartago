#pragma checksum "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc5ce430b6b3799137149c5293a469737052249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_FormularioEmpleado), @"mvc.1.0.view", @"/Views/Personal/FormularioEmpleado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc5ce430b6b3799137149c5293a469737052249", @"/Views/Personal/FormularioEmpleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_FormularioEmpleado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
  
    ViewData["Title"] = "Formulario Empleado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Start Page Content here -->\r\n<!-- ============================================================== -->\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
 using (Html.BeginForm("AgregarEmpleado", "Personal", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content-page\">\r\n        <div class=\"content\">\r\n\r\n            <!-- Start Content-->\r\n            <div class=\"container-fluid\">\r\n");
#nullable restore
#line 18 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
                 if (@ViewBag.MensajeAgregar != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"alert alert-success\">");
#nullable restore
#line 20 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
                                               Write(ViewBag.MensajeAgregar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card-box"">
                            <h4>Formulario de personal</h4>

                            <br />

                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""p-2"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc5ce430b6b3799137149c5293a4697370522496433", async() => {
                WriteLiteral(@"

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Cédula</label>
                                                <div class=""col-md-10"">
                                                    <input type=""number"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese la cédula"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Nombre</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el nombre"" required>
                                                </div>
  ");
                WriteLiteral(@"                                          </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Primer apellido</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el primer apellido"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Segundo apellido</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el seg");
                WriteLiteral(@"undo apellido"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Provincia</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese la provincia"" required>
                                                </div>
                                            </div>


                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Dirección</label>
                                                <div class=""col-md-10"">
                                                    <textarea class=""");
                WriteLiteral(@"form-control"" rows=""5"" id=""example-textarea"" placeholder=""Ingrese la dirección"" required></textarea>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Teléfono</label>
                                                <div class=""col-md-10"">
                                                    <input type=""number"" id=""simpleinput"" class=""form-control"" placeholder=""Digite el número de teléfono"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Correo Electrónico</label>
                                                <d");
                WriteLiteral(@"iv class=""col-md-10"">
                                                    <input type=""email"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el correo electrónico"" required>
                                                </div>
                                            </div>


                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Cargo</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el cargo"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-date"">Fecha de in");
                WriteLiteral(@"greso</label>
                                                <div class=""col-md-10"">
                                                    <input class=""form-control"" id=""example-date"" type=""date"" name=""date"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-date"">Salario</label>
                                                <div class=""col-md-10"">
                                                    <input class=""form-control"" type=""number"" name=""number"" placeholder=""Ingrese el salario"" required>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" ");
                WriteLiteral("for=\"example-date\">Rol</label>\r\n\r\n                                                <div class=\"col-md-10\">\r\n                                                    <select class=\"form-control\" required>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc5ce430b6b3799137149c5293a46973705224913496", async() => {
                    WriteLiteral("Rol 1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc5ce430b6b3799137149c5293a46973705224914566", async() => {
                    WriteLiteral("Rol 2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                       
                                                    </select>
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Nombre de usuario</label>
                                                <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese el nombre de usuario"">
                                                </div>
                                            </div>

                                            <div class=""form-group row"">
                                                <label class=""col-md-2 col-form-label"" for=""example-textarea"">Contraseña</label>
                                        ");
                WriteLiteral(@"        <div class=""col-md-10"">
                                                    <input type=""text"" id=""simpleinput"" class=""form-control"" placeholder=""Ingrese la contraseña"">
                                                </div>
                                            </div>



                                            <br />
                                            <div class=""form-group row"">
                                                <div class=""col-md-2"">

                                                </div>
                                                <div class=""col-md-10"">

                                                    <input id=""sa-success"" type=""submit"" value=""Agregar"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" />
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
#line 174 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Personal\FormularioEmpleado.cshtml"
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