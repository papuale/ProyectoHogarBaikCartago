#pragma checksum "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\VerControlProyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586808b0f9b11744f335e0bc5d1e0068fc52296f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyectos_VerControlProyectos), @"mvc.1.0.view", @"/Views/Proyectos/VerControlProyectos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"586808b0f9b11744f335e0bc5d1e0068fc52296f", @"/Views/Proyectos/VerControlProyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyectos_VerControlProyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mauro\Desktop\ProyectoHogarBaikCartago\hogarbaik\Views\Proyectos\VerControlProyectos.cshtml"
  
    ViewData["Title"] = "VerControlProyectos";
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
                        <div class=""form-group row"">
                            <label class=""col-md-2 col-form-label"" for=""cedulaNino"">Ingrese el nombre del proyecto</label>
                            <div class=""col-md-4"">
                                <input type=""text"" id=""cedulaNino"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-10"">
                                <h4>Control proyecto: </h4>
                            </div>

                            <div class=""col-sm-2"">

                                <input id=""Submit1"" type=""submit"" value=""Agregar control"" class=""btn btn-bordered-success wav");
            WriteLiteral(@"es-effect  width-md waves-light"" onclick=""location.href='/Proyectos/ControlProyectos'"" />
                            </div>

                        </div>
                        <br />
                        <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"">
                            <thead>
                                <tr>
                                    <th style=""text-align:center"">Nombre del proyecto</th>
                                    <th style=""text-align:center"">Materiales</th>
                                    <th style=""text-align:center"">Servicios externos</th>
                                    <th style=""text-align:center"">Duracion del proyecto</th>
                                    <th style=""text-align:center"">Fecha de inicio</th>
                                    <th style=""text-align:center"">Fecha de finalizaci??n</th>


                                </tr>
                            </thead>


         ");
            WriteLiteral(@"                   <tbody>
                                <tr>
                                    <td style=""text-align:center"">Reparaci??n Techo</td>
                                    <td style=""text-align:center"">
                                        1. Cemento
                                        2. Laminas
                                    </td>
                                    <td style=""text-align:center"">Cemaco</td>
                                    <td style=""text-align:center"">1 a??o y 3 meses</td>
                                    <td style=""text-align:center"">25/03/2021</td>
                                    <td style=""text-align:center"">25/06/2022</td>


                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!-- end row -->




        </div> <!-- container-fluid -->

    </div> <!-- content -->


</div>");
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
