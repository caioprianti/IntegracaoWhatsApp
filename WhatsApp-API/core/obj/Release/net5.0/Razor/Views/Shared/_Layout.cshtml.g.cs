#pragma checksum "C:\Projetos\projetosxs6\WhatsApp\WhatsApp-API\core\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d738530d2c176063fe96b6170a35b8e3149fb2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d738530d2c176063fe96b6170a35b8e3149fb2f1", @"/Views/Shared/_Layout.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sidebar", new global::Microsoft.AspNetCore.Html.HtmlString("dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d738530d2c176063fe96b6170a35b8e3149fb2f13131", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Dashboard | Caixa Assistência</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta content=""Premium Multipurpose Admin & Dashboard Template""
          name=""description"" />
    <meta content=""Themesbrand"" name=""author"" />
    <!-- App favicon -->
    <link rel=""shortcut icon"" href=""../assets/images/favicon.png"" />

    <style>
        body[data-sidebar=dark] .navbar-brand-box, .simplebar-content-wrapper {
            background: #0074bc !important;
        }
    </style>

");
                WriteLiteral(@"

    <!-- Bootstrap Css -->
    <link href=""../assets/css/bootstrap.min.css"" rel=""stylesheet"" />
    <!-- Icons Css -->
    <link href=""../assets/css/icons.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- App Css-->

    <link href=""../assets/css/app.min.css"" rel=""stylesheet"" />

");
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""../assets/css/style.css"" />


    <!-- JAVASCRIPT -->
    <script src=""../assets/libs/jquery/jquery.min.js""></script>
    <script src=""../assets/libs/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""../assets/libs/metismenu/metisMenu.min.js""></script>
    <script src=""../assets/libs/simplebar/simplebar.min.js""></script>
    <script src=""../assets/libs/node-waves/waves.min.js""></script>

    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script src=""../js/comum.js""></script>

    <style>
        body[data-sidebar=dark] .navbar-brand-box, .simplebar-content-wrapper{
            background-color: #006bae !important
        }
        .mm-active .active {
            background-color: #f7941e !important;
        }
        #page-topbar {
            background-color: #F3F5F9 !important;
        }
        body {
            background-color: #fff !important;
        }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d738530d2c176063fe96b6170a35b8e3149fb2f16082", async() => {
                WriteLiteral(@"
    <!-- Begin page -->
    <div id=""layout-wrapper"">
        <header id=""page-topbar"">
            <div class=""navbar-header"">
                <div class=""d-flex"">
                    <!-- LOGO -->
                    <div class=""navbar-brand-box"">
                        <a href=""../Painel/Home"" class=""logo logo-dark"">
                            <span class=""logo-sm"">
                                <img src=""../assets/images/logocaixa.png""");
                BeginWriteAttribute("alt", " alt=\"", 2704, "\"", 2710, 0);
                EndWriteAttribute();
                WriteLiteral(" height=\"22\" />\r\n                            </span>\r\n                            <span class=\"logo-lg\">\r\n                                <img src=\"../assets/images/logocaixa.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2890, "\"", 2896, 0);
                EndWriteAttribute();
                WriteLiteral(@" height=""17"" />
                            </span>
                        </a>

                        <a href=""../Painel/Home"" class=""logo logo-light"">
                            <span class=""logo-sm"">
                                <img src=""../assets/images/logocaixa.png""");
                BeginWriteAttribute("alt", " alt=\"", 3183, "\"", 3189, 0);
                EndWriteAttribute();
                WriteLiteral(" height=\"50\" />\r\n                            </span>\r\n                            <span class=\"logo-lg\">\r\n                                <img src=\"../assets/images/logocaixa.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3369, "\"", 3375, 0);
                EndWriteAttribute();
                WriteLiteral(@" height=""50"" />
                            </span>
                        </a>
                    </div>

                    <button type=""button""
                            class=""btn btn-sm px-3 font-size-24 header-item waves-effect""
                            id=""vertical-menu-btn"">
                        <i class=""mdi mdi-menu""></i>
                    </button>
                </div>

                <div class=""d-flex"">
                    <div class=""dropdown d-none d-lg-inline-block"">
                        <button type=""button""
                                class=""btn header-item noti-icon waves-effect""
                                data-bs-toggle=""fullscreen"">
                            <i class=""mdi mdi-fullscreen""></i>
                        </button>
                    </div>

                    <div class=""dropdown d-inline-block"">
                        <button type=""button""
                                class=""btn header-item noti-icon waves-effect""
 ");
                WriteLiteral(@"                               id=""page-header-notifications-dropdown""
                                data-bs-toggle=""dropdown""
                                aria-haspopup=""true""
                                aria-expanded=""false"">
                            <i class=""mdi mdi-bell-outline""></i>
                            <span class=""badge bg-danger rounded-pill"">0</span>
                        </button>
                        <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-end p-0""
                             aria-labelledby=""page-header-notifications-dropdown"">
                            <div class=""p-3"">
                                <div class=""row align-items-center"">
                                    <div class=""col"">
                                        <h5 class=""m-0 font-size-16"">Notificação (0)</h5>
                                    </div>
                                </div>
                            </div>
                        </div>
           ");
                WriteLiteral(@"         </div>


                </div>
            </div>
        </header>

        <!-- ==========  Menu Vertical ========== -->
        <div class=""vertical-menu"">
            <div data-simplebar class=""h-100"">
                <!--- Sidemenu -->
                <div id=""sidebar-menu"">
                    <!-- Left Menu Start -->
                    <ul class=""metismenu list-unstyled"" id=""side-menu"">
                        <li class=""menu-title"">Menu</li>

                        <li>
                            <a href=""../Painel/FechamentoMes"" class=""waves-effect"">
                                <i class=""ti-home""></i>
                                <span>Fechamento mês</span>
                            </a>
                        </li>

                        <li>
                            <a href=""../Painel/CriarAtividade"" class=""waves-effect"">
                                <i class=""ti-plus""></i>
                                <span>Nova atividade</span>
        ");
                WriteLiteral(@"                    </a>
                        </li>

                        <li>
                            <a href=""../Painel/ListaAtividade?Status=Aguardando"" class=""waves-effect"">
                                <i class=""ti-folder""></i>
                                <span>Novas Solicitações</span>
                            </a>
                        </li>

                        <li>
                            <a href=""../Painel/ListaAtividade?Status=Aprovado"" class=""waves-effect"">
                                <i class=""ti-folder""></i>
                                <span>Minhas atividades</span>
                            </a>
                        </li>

                        <li>
                            <a href=""../Painel/ListaAtividadeSolicitada"" class=""waves-effect"">
                                <i class=""ti-folder""></i>
                                <span>Minhas Solicitações</span>
                            </a>
                        </li>

");
                WriteLiteral(@"


                    </ul>
                </div>
                <!-- Sidebar -->
            </div>
        </div>
        <!-- Menu Vertical -->
        <!-- ============================================================== -->
        <!-- CONTEUDO PRINCIPAL -->
        <!-- ============================================================== -->
        <div class=""main-content"">
            <div class=""page-content"">
                ");
#nullable restore
#line 192 "C:\Projetos\projetosxs6\WhatsApp\WhatsApp-API\core\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
    <!-- ============================================================== -->
    <!--  ######################### CONTEUDO PRINCIPAL ######################### -->
    <!-- ============================================================== -->
    <!-- end main content-->
    </div>
    <!-- END layout-wrapper -->
    <!-- Right bar overlay-->
    <div class=""rightbar-overlay""></div>



    <!-- Peity chart-->
");
                WriteLiteral("\r\n    <!-- Plugin Js-->\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script src=""../assets/js/app.js""></script>

    <link rel=""stylesheet""
          type=""text/css""
          href=""https://cdn.datatables.net/1.11.5/css/jquery.dataTables.css"" />

    <script type=""text/javascript""
            charset=""utf8""
            src=""https://cdn.datatables.net/1.11.5/js/jquery.dataTables.js""></script>


    <script>
        $(document).ready(function () {
            $(""#table"").DataTable({
                language: {
                    url: ""https://cdn.datatables.net/plug-ins/1.11.5/i18n/pt-BR.json"",
                },
                ordering: false
            });
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591