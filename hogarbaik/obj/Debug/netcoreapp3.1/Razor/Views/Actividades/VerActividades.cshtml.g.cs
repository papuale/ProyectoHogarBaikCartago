#pragma checksum "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Actividades\VerActividades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "468271b311c54e9e93190453b518c18385e6f2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividades_VerActividades), @"mvc.1.0.view", @"/Views/Actividades/VerActividades.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468271b311c54e9e93190453b518c18385e6f2b0", @"/Views/Actividades/VerActividades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Actividades_VerActividades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Actividades\VerActividades.cshtml"
  
    ViewData["Title"] = "VerActividades";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>VerActividades</h2>

<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">




            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card-box"">

                        <div class=""row"">
                            <div class=""col-sm-10"">
                                <h4>Actividades disponibles</h4>
                            </div>

                            <div class=""col-sm-2"">

                                <input id=""Submit1"" type=""submit"" value=""Agregar actividad"" class=""btn btn-bordered-success waves-effect  width-md waves-light"" onclick=""location.href='/Actividades/Actividades'"" />

                            </div>

                        </div>
                        <br />
                        <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"">
                            <thead>
               ");
            WriteLiteral(@"                 <tr>
                                    <th style=""text-align:center"">Nombre del evento</th>
                                    <th style=""text-align:center"">Lugar</th>
                                    <th style=""text-align:center"">Descripcion</th>
                                    <th style=""text-align:center"">Gestionar actividad</th>
                                    <th style=""text-align:center"">Hora del evento</th>
                                    <th style=""text-align:center"">Teléfono</th>
                                    <th style=""text-align:center"">Fecha del evento</th>

                                </tr>
                            </thead>


                            <tbody>
                                <tr>
                                    <td style=""text-align:center"">Carrera</td>
                                    <td style=""text-align:center"">Plaza de deportes Guadalupe</td>
                                    <td style=""text-align:cen");
            WriteLiteral(@"ter"">Primer carrera del hogar Baik para recaudar fondos para los regalos de navidad de los niños, no te lo pierdas</td>
                                    <td style=""text-align:center"">
                                        <input id=""btnGestionarActividad"" type=""submit"" value=""Gestionar actividad"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href= '/Actividades/EditarActividades'"" />
                                    </td>

                                    <td style=""text-align:center"">8:00 am</td>
                                    <td style=""text-align:center"">2525-8213</td>
                                    <td style=""text-align:center"">25/11/2021</td>



                                </tr>
                                <tr>
                                    <td style=""text-align:center"">Bingo</td>
                                    <td style=""text-align:center"">Hogar Baik</td>
                                    <td style=""text-align:");
            WriteLiteral(@"center"">Primer bingo del hogar Baik para recaudar fondos para el nuevo dormitorio de los niños, te esperamos!</td>
                                    <td style=""text-align:center"">
                                        <input id=""btnGestionarActividad"" type=""submit"" value=""Gestionar actividad"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href= '/Actividades/EditarActividades'"" />
                                    </td>

                                    <td style=""text-align:center"">6:00 pm</td>
                                    <td style=""text-align:center"">2525-8213</td>
                                    <td style=""text-align:center"">25/8/2021</td>

                                </tr>
                                <tr>
                                    <td style=""text-align:center"">Ventas dia de la madre</td>
                                    <td style=""text-align:center"">Hogar Baik</td>
                                    <td style=""text");
            WriteLiteral(@"-align:center"">
                                        Disfrute de ricos platillos preparados por los vecinos de la comunidad de Guadalupe de Cartago, se realizarán rifas
                                        para recaudar fondos al Centro.
                                        ¡Te esperamos!
                                    </td>
                                    <td style=""text-align:center"">
                                        <input id=""btnGestionarActividad"" type=""submit"" value=""Gestionar actividad"" class=""btn btn-bordered-info waves-effect  width-md waves-light"" onclick=""location.href= '/Actividades/EditarActividades'"" />
                                    </td>

                                    <td style=""text-align:center"">11:00 am</td>
                                    <td style=""text-align:center"">2525-8213</td>
                                    <td style=""text-align:center"">15/8/2021</td>

                                </tr>
                            </tbody>");
            WriteLiteral("\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- end row -->\r\n\r\n\r\n\r\n\r\n        </div> <!-- container-fluid -->\r\n\r\n    </div> <!-- content -->\r\n\r\n\r\n</div>");
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
