#pragma checksum "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\InventarioInmuebles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101478d03d8eed25daf236a923d0c295817b1b51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_InventarioInmuebles), @"mvc.1.0.view", @"/Views/Inventario/InventarioInmuebles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101478d03d8eed25daf236a923d0c295817b1b51", @"/Views/Inventario/InventarioInmuebles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_InventarioInmuebles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Inventario\InventarioInmuebles.cshtml"
  
    ViewData["Title"] = "Inventario Inmuebles";
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
                                        <h4>Inventario de Inmuebles</h4>
                                    </div>

                                    <div class=""col-sm-2"">
                                        <input id=""Submit1"" type=""submit"" value=""Agregar"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" onclick=""location.href='/Inventario/FormularioInmuebles'"" />
                                       
                          ");
            WriteLiteral(@"          </div>

                                </div>
                                <br />
                                <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"">
                                    <thead>
                                        <tr>
                                            <th style=""text-align:center"">Código</th>
                                            <th style=""text-align:center"">Nombre</th>
                                            <th style=""text-align:center"">Descripción</th>
                                            <th style=""text-align:center"">Cantidad</th>
                                            <th style=""text-align:center"">Serie</th>
                                            <th style=""text-align:center"">Valor</th>
                                            <th style=""text-align:center"">Fecha de adquisición</th>
                                            <th style=""text-align:center"">Adq");
            WriteLiteral(@"uisición</th>
                                            <th style=""text-align:center""></th>

                                        </tr>
                                    </thead>


                                    <tbody>
                                        <tr>
                                            <td style=""text-align:center"">01</td>
                                            <td style=""text-align:center"">Mesa</td>
                                            <td style=""text-align:center"">Mesa para comer</td>
                                            <td style=""text-align:center"">3</td>
                                            <td style=""text-align:center"">N/A</td>
                                            <td style=""text-align:center"">30000</td>
                                            <td style=""text-align:center"">25/03/2021</td>
                                            <td style=""text-align:center"">Donación</td>
                                          ");
            WriteLiteral(@"  <td style=""text-align:center"">
                                                <input id=""btnVerInventario"" type=""submit"" value=""Ver Inventario"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href='/Inventario/ModificarInmuebles'"" />
                                               
                                            </td>

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