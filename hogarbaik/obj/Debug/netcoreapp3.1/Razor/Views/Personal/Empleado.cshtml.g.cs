#pragma checksum "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Personal\Empleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1dd6af3f962fd28a20b3dc368e133429bb4392b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Empleado), @"mvc.1.0.view", @"/Views/Personal/Empleado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1dd6af3f962fd28a20b3dc368e133429bb4392b", @"/Views/Personal/Empleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Empleado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Personal\Empleado.cshtml"
  
    ViewData["Title"] = "Empleado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start Page Content here -->
<!-- ============================================================== -->

<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">




            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card-box"">

                        <div class=""row"">
                            <div class=""col-sm-10"">
                                <h4>Personal Hogar Baik</h4>
                            </div>

                            <div class=""col-sm-2"">

                                <input id=""Submit1"" type=""submit"" value=""Agregar"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" onclick=""location.href='/Personal/FormularioEmpleado'"" />                              
                            </div>

                        </div>
                        <br />
                        <table id=""datatable-buttons"" class=""table table");
            WriteLiteral(@"-striped table-bordered dt-responsive nowrap"">
                            <thead>
                                <tr>
                                    <th style=""text-align:center"">C??dula</th>
                                    <th style=""text-align:center"">Nombre</th>
                                    <th style=""text-align:center"">Primer Apellido</th>
                                    <th style=""text-align:center"">Segundo Apellido</th>
                                    <th style=""text-align:center"">Tel??fono</th>
                                    <th style=""text-align:center"">Cargo</th>
                                    <th style=""text-align:center"">Salario</th>
                                    <th style=""text-align:center""></th>

                                </tr>
                            </thead>


                            <tbody>
                                <tr>
                                    <td style=""text-align:center"">303330333</td>
              ");
            WriteLiteral(@"                      <td style=""text-align:center"">Marta</td>
                                    <td style=""text-align:center"">Mena</td>
                                    <td style=""text-align:center"">Fernandez</td>
                                    <td style=""text-align:center"">2222-2222</td>
                                    <td style=""text-align:center"">Directora</td>
                                    <td style=""text-align:center"">350000</td>
                                    <td style=""text-align:center"">
                                        <input id=""btnVerInventario"" type=""submit"" value=""Ver Empleado"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href='/Personal/ModificarEmpleado'"" />
                                    </td>

                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!-- end row -->


");
            WriteLiteral(@"

        </div> <!-- container-fluid -->

    </div> <!-- content -->


</div>

<!-- ============================================================== -->
<!-- End Page content -->
<!-- ============================================================== -->
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
