#pragma checksum "C:\Users\Jenifer\Desktop\Verificar\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\Proyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ba33b758813941e692e4cccefc13a078cdc99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyectos_Proyectos), @"mvc.1.0.view", @"/Views/Proyectos/Proyectos.cshtml")]
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
#line 1 "C:\Users\Jenifer\Desktop\Verificar\ProyectoHogarBaikCartago\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jenifer\Desktop\Verificar\ProyectoHogarBaikCartago\hogarbaik\Views\_ViewImports.cshtml"
using hogarbaik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ba33b758813941e692e4cccefc13a078cdc99e", @"/Views/Proyectos/Proyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyectos_Proyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jenifer\Desktop\Verificar\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\Proyectos.cshtml"
  
    ViewData["Title"] = "Proyectos";
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

                        <div class=""row"">
                            <div class=""col-sm-10"">
                                <h4>Proyectos Activos</h4>
                            </div>

                            <div class=""col-sm-2"">

                                <input id=""Submit1"" type=""submit"" value=""Agregar"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" onclick=""location.href='/Proyectos/FormularioProyecto'"" />
                            </div>

                        </div>
                        <br />
                        <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"">
                            <thead>
                                <tr>
                 ");
            WriteLiteral(@"                   <th style=""text-align:center"">Código</th>
                                    <th style=""text-align:center"">Nombre del proyecto</th>
                                    <th style=""text-align:center"">Descripción</th>
                                    <th style=""text-align:center"">Nombre del responsable</th>
                                    <th style=""text-align:center"">Monto</th>
                                    <th style=""text-align:center"">Gestionar Proyecto</th>
                                    <th style=""text-align:center"">Fecha de inicio</th>


                                </tr>
                            </thead>


                            <tbody>
                                <tr>
                                    <td style=""text-align:center"">01</td>
                                    <td style=""text-align:center"">Reparación Techo</td>
                                    <td style=""text-align:center"">Fondos para sustitución del zin</td>
      ");
            WriteLiteral(@"                              <td style=""text-align:center"">Kattia</td>
                                    <td style=""text-align:center"">100000</td>
                                    <td style=""text-align:center"">
                                        <input id=""btnGestionarProyecto"" type=""submit"" value=""Gestionar proyecto"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href= '/Proyectos/ModificarProyecto'"" />
                                    </td>
                                    <td style=""text-align:center"">25/03/2021</td>


                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
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
