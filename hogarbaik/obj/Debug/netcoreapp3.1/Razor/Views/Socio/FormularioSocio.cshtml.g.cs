#pragma checksum "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Socio\FormularioSocio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc081e09bfcdd411d029202afd209179c049112d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Socio_FormularioSocio), @"mvc.1.0.view", @"/Views/Socio/FormularioSocio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc081e09bfcdd411d029202afd209179c049112d", @"/Views/Socio/FormularioSocio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404da633aabfb1517c8e12570837b5a3127d76ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Socio_FormularioSocio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/vendor.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/twitter-bootstrap-wizard/jquery.bootstrap.wizard.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/form-wizard.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Jenifer\Desktop\Git Hub Analisis\HogarBaik\hogarbaik\hogarbaik\Views\Socio\FormularioSocio.cshtml"
  
    ViewData["Title"] = "FormularioSocios";
    Layout = "~/Views/Shared/_LayoutFront.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<br />
<br />
<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <h4 class=""header-title mb-3"">Formulario solicitud de socio</h4>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc081e09bfcdd411d029202afd209179c049112d5757", async() => {
                WriteLiteral(@"
                                <div id=""progressbarwizard"">

                                    <ul class=""nav nav-pills bg-light nav-justified form-wizard-header mb-1"">
                                        <li class=""nav-item"">
                                            <a href=""#account-2"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                                <i class=""mdi mdi-account-circle mr-1""></i>
                                                <span class=""d-none d-sm-inline"">Información personal</span>
                                            </a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#profile-tab-2"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                                <i class=""mdi mdi-face-profile mr-1""></i>
                                                <span class=""d-none d-sm-inline"">L");
                WriteLiteral(@"ugar donde vives</span>
                                            </a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a href=""#finish-2"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                                <i class=""mdi mdi-checkbox-marked-circle-outline mr-1""></i>
                                                <span class=""d-none d-sm-inline"">Donativo</span>
                                            </a>
                                        </li>
                                    </ul>

                                    <div class=""tab-content border-0 mb-0"">

                                        <div id=""bar"" class=""progress mb-3 mt-0"" style=""height: 7px;"">
                                            <div class=""bar progress-bar progress-bar-striped progress-bar-animated bg-success""></div>
                                        </div>

");
                WriteLiteral(@"                                        <div class=""tab-pane"" id=""account-2"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""userName1"">Número de cedula</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" class=""form-control"" id=""userName1"" name=""userName1"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""password1""> Nombre</label>
                                   ");
                WriteLiteral(@"                     <div class=""col-md-6"">
                                                            <input type=""text"" id=""password1"" name=""password1"" class=""form-control"">
                                                        </div>
                                                    </div>

                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""confirm1"">Primer apellido</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""confirm1"" name=""confirm1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-");
                WriteLiteral(@"md-3 col-form-label"" for=""confirm1"">Segundo apellido</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""confirm1"" name=""confirm1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""confirm1"">Teléfono</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""confirm1"" name=""confirm1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group ");
                WriteLiteral(@"row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""confirm1"">Correo eléctronico</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""confirm1"" name=""confirm1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                </div> <!-- end col -->
                                            </div> <!-- end row -->
                                        </div>

                                        <div class=""tab-pane"" id=""profile-tab-2"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""form-group row mb-3"">
                                           ");
                WriteLiteral(@"             <label class=""col-md-3 col-form-label"" for=""name1""> Provincia</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""name1"" name=""name1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""surname1""> Cantón</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""surname1"" name=""surname1"" class=""form-control"">
                                                        </div>
                                                    </div>

                                                    <div c");
                WriteLiteral(@"lass=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""email1"">Distrito</label>
                                                        <div class=""col-md-6"">
                                                            <input type=""text"" id=""email1"" name=""email1"" class=""form-control"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""email1"">Dirección</label>
                                                        <div class=""col-md-6"">
                                                            <textarea class=""form-control"" rows=""3"" id=""example-textarea""></textarea>
                                                        </div>
                                            ");
                WriteLiteral(@"        </div>
                                                </div> <!-- end col -->
                                            </div> <!-- end row -->
                                        </div>

                                        <div class=""tab-pane"" id=""finish-2"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""text-center"">
                                                        <h2 class=""mt-0""><i class=""mdi mdi-check-all""></i></h2>
                                                        <h3 class=""mt-0"">Muchas gracias !</h3>

                                                        <p class=""w-75 mb-2 mx-auto"">
                                                            Para nuestro centro es de vital importancia la participación de los socios, así que desde ya te agradecemos el querer ser parte de está familia.
                      ");
                WriteLiteral(@"                                  </p>

                                                        <div class=""mb-3"">
                                                            <div class=""form-group row mb-3"">
                                                                <label class=""col-lg-4 col-form-label"" for=""email1"">Monto a donar</label>
                                                                <div class=""col-md-4"">
                                                                    <input type=""text"" id=""email1"" name=""email1"" class=""form-control"">
                                                                </div>
                                                            </div>
                                                            <button type=""button"" class=""btn btn-success float-center"">Postular</button>
                                                        </div>

                                                    </div>
                                            ");
                WriteLiteral(@"    </div> <!-- end col -->
                                            </div> <!-- end row -->
                                        </div>

                                        <ul class=""list-inline mb-0 wizard"">
                                            <li class=""previous list-inline-item"">
                                                <a href=""javascript: void(0);"" class=""btn btn-primary"">Anterior</a>
                                            </li>
                                            <li class=""next list-inline-item float-right"">
                                                <a href=""javascript: void(0);"" class=""btn btn-primary"">Siguiente</a>
                                            </li>
                                        </ul>

                                    </div> <!-- tab-content -->
                                </div> <!-- end #progressbarwizard-->
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div> <!-- end card-body -->
                    </div> <!-- end card-->
                </div> <!-- end col -->
                <!--<div class=""col-xl-6"">
                    <div class=""card"">
                        <div class=""card-body"">

                            <h4 class=""header-title mb-3""> Wizard With Form Validation</h4>

                            <div id=""rootwizard"">
                                <ul class=""nav nav-pills bg-light nav-justified form-wizard-header mb-3"">
                                    <li class=""nav-item"" data-target-form=""#accountForm"">
                                        <a href=""#first"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                            <i class=""mdi mdi-account-circle mr-1""></i>
                                            <span class=""d-none d-sm-inline"">Account</span>
                                        </a>
                                    </li>
               ");
            WriteLiteral(@"                     <li class=""nav-item"" data-target-form=""#profileForm"">
                                        <a href=""#second"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                            <i class=""mdi mdi-face-profile mr-1""></i>
                                            <span class=""d-none d-sm-inline"">Profile</span>
                                        </a>
                                    </li>
                                    <li class=""nav-item"" data-target-form=""#otherForm"">
                                        <a href=""#third"" data-toggle=""tab"" class=""nav-link rounded-0 pt-2 pb-2"">
                                            <i class=""mdi mdi-checkbox-marked-circle-outline mr-1""></i>
                                            <span class=""d-none d-sm-inline"">Finish</span>
                                        </a>
                                    </li>
                                </ul>

                                <d");
            WriteLiteral(@"iv class=""tab-content mb-0 border-0"">

                                    <div class=""tab-pane"" id=""first"">
                                        <form id=""accountForm"" method=""post"" action=""#"" class=""form-horizontal"">
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""userName3"">User name</label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" class=""form-control"" id=""userName3"" name=""userName3"" required>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row mb-3"">
              ");
            WriteLiteral(@"                                          <label class=""col-md-3 col-form-label"" for=""password3""> Password</label>
                                                        <div class=""col-md-9"">
                                                            <input type=""password"" id=""password3"" name=""password3"" class=""form-control"" required>
                                                        </div>
                                                    </div>

                                                    <div class=""form-group row mb-3"">
                                                        <label class=""col-md-3 col-form-label"" for=""confirm3"">Re Password</label>
                                                        <div class=""col-md-9"">
                                                            <input type=""password"" id=""confirm3"" name=""confirm3"" class=""form-control"" required>
                                                        </div>
                                                ");
            WriteLiteral(@"    </div>
                                                </div>-->
                <!-- end col -->
                <!--</div>--> <!-- end row -->
                <!--</form>
                </div>

                <div class=""tab-pane fade"" id=""second"">
                    <form id=""profileForm"" method=""post"" action=""#"" class=""form-horizontal"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""form-group row mb-3"">
                                    <label class=""col-md-3 col-form-label"" for=""name3""> First name</label>
                                    <div class=""col-md-9"">
                                        <input type=""text"" id=""name3"" name=""name3"" class=""form-control"" required>
                                    </div>
                                </div>
                                <div class=""form-group row mb-3"">
                                    <label class=""col-md-3 col-form-lab");
            WriteLiteral(@"el"" for=""surname3""> Last name</label>
                                    <div class=""col-md-9"">
                                        <input type=""text"" id=""surname3"" name=""surname3"" class=""form-control"" required>
                                    </div>
                                </div>

                                <div class=""form-group row mb-3"">
                                    <label class=""col-md-3 col-form-label"" for=""email3"">Email</label>
                                    <div class=""col-md-9"">
                                        <input type=""email"" id=""email3"" name=""email3"" class=""form-control"" required>
                                    </div>
                                </div>
                            </div>-->
                <!-- end col -->
                <!--</div>-->
                <!-- end row -->
                <!--</form>
                </div>

                <div class=""tab-pane fade"" id=""third"">
                    <form id=""otherFo");
            WriteLiteral(@"rm"" method=""post"" action=""#"" class=""form-horizontal"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""text-center"">
                                    <h2 class=""mt-0"">
                                        <i class=""mdi mdi-check-all""></i>
                                    </h2>
                                    <h3 class=""mt-0"">Thank you !</h3>

                                    <p class=""w-75 mb-2 mx-auto"">
                                        Quisque nec turpis at urna dictum luctus. Suspendisse convallis dignissim eros at volutpat. In egestas mattis
                                        dui. Aliquam mattis dictum aliquet.
                                    </p>

                                    <div class=""mb-3"">
                                        <div class=""custom-control custom-checkbox"">
                                            <input type=""checkbox"" class=""custom-control-i");
            WriteLiteral(@"nput"" id=""customCheck4"" required>
                                            <label class=""custom-control-label"" for=""customCheck4"">I agree with the Terms and Conditions</label>
                                        </div>
                                    </div>
                                </div>
                            </div>-->
                <!-- end col -->
                <!--</div>-->
                <!-- end row -->
                <!--</form>
                    </div>

                    <ul class=""list-inline wizard mb-0"">
                        <li class=""previous list-inline-item"">
                            <a href=""javascript: void(0);"" class=""btn btn-secondary"">Previous</a>
                        </li>
                        <li class=""next list-inline-item float-right""><a href=""javascript: void(0);"" class=""btn btn-secondary"">Next</a></li>
                    </ul>

                </div>-->
                <!-- tab-content -->
                <!--</div>");
            WriteLiteral("--> <!-- end #rootwizard-->\r\n                <!--</div>--> <!-- end card-body -->\r\n                <!--</div>--> <!-- end card-->\r\n                <!--</div>--> <!-- end col -->\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc081e09bfcdd411d029202afd209179c049112d27760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Plugins js-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc081e09bfcdd411d029202afd209179c049112d28826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Init js-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc081e09bfcdd411d029202afd209179c049112d29889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- App js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc081e09bfcdd411d029202afd209179c049112d30952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
