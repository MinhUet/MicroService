#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\DataTables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84bc993d3f659e60bd55813ac18228172b997c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tables_DataTables), @"mvc.1.0.view", @"/Views/Tables/DataTables.cshtml")]
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
#line 1 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\_ViewImports.cshtml"
using Nhom9.Docker_Kubernet.Demo.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\_ViewImports.cshtml"
using Nhom9.Docker_Kubernet.Demo.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84bc993d3f659e60bd55813ac18228172b997c8", @"/Views/Tables/DataTables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tables_DataTables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\DataTables.cshtml"
  
    ViewData["Title"] = "DataTables";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Data Tables</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 312, 1);
#nullable restore
#line 11 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\DataTables.cshtml"
WriteAttributeValue("", 272, Url.Action("Dashboard_1", "Dashboards"), 272, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Tables</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Data Tables</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Basic Data Tables example with responsive plugin</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
             ");
            WriteLiteral(@"               <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">

                    <table class=""table table-striped table-bordered table-hover dataTables-example"">
                        <thead>
                            <tr>
                                <th>Rendering engine</th>
                                <th>Browser</th>
                                <th>Platform(s)</th>
                                <th>Engine version</th>
                                <th>CSS grade</th>
                   ");
            WriteLiteral(@"         </tr>
                        </thead>
                        <tbody>
                            <tr class=""gradeX"">
                                <td>Trident</td>
                                <td>
                                    Internet
                                    Explorer 4.0
                                </td>
                                <td>Win 95+</td>
                                <td class=""center"">4</td>
                                <td class=""center"">X</td>
                            </tr>
                            <tr class=""gradeC"">
                                <td>Trident</td>
                                <td>
                                    Internet
                                    Explorer 5.0
                                </td>
                                <td>Win 95+</td>
                                <td class=""center"">5</td>
                                <td class=""center"">C</td>
                          ");
            WriteLiteral(@"  </tr>
                            <tr class=""gradeA"">
                                <td>Trident</td>
                                <td>
                                    Internet
                                    Explorer 5.5
                                </td>
                                <td>Win 95+</td>
                                <td class=""center"">5.5</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Trident</td>
                                <td>
                                    Internet
                                    Explorer 6
                                </td>
                                <td>Win 98+</td>
                                <td class=""center"">6</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                ");
            WriteLiteral(@"                <td>Trident</td>
                                <td>Internet Explorer 7</td>
                                <td>Win XP SP2+</td>
                                <td class=""center"">7</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Trident</td>
                                <td>AOL browser (AOL desktop)</td>
                                <td>Win XP</td>
                                <td class=""center"">6</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Firefox 1.0</td>
                                <td>Win 98+ / OSX.2+</td>
                                <td class=""center"">1.7</td>
                                <td class=""center"">A</td>
                      ");
            WriteLiteral(@"      </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Firefox 1.5</td>
                                <td>Win 98+ / OSX.2+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Firefox 2.0</td>
                                <td>Win 98+ / OSX.2+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Firefox 3.0</td>
                                <td>Win 2k+ / OSX.3+</td>
                                <td class=""center"">1.9</td>
          ");
            WriteLiteral(@"                      <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Camino 1.0</td>
                                <td>OSX.2+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Camino 1.5</td>
                                <td>OSX.3+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Netscape 7.2</td>
                                <td>Win 95+ / Mac OS 8.6-9.2</td>
             ");
            WriteLiteral(@"                   <td class=""center"">1.7</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Netscape Browser 8</td>
                                <td>Win 98SE+</td>
                                <td class=""center"">1.7</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Netscape Navigator 9</td>
                                <td>Win 98+ / OSX.2+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.");
            WriteLiteral(@"0</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.1</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.1</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.2</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.2</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                         ");
            WriteLiteral(@"       <td>Gecko</td>
                                <td>Mozilla 1.3</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.3</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.4</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.4</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.5</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.5</td>
                                <td class=""center"">A</td>
                            </tr>
   ");
            WriteLiteral(@"                         <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.6</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">1.6</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.7</td>
                                <td>Win 98+ / OSX.1+</td>
                                <td class=""center"">1.7</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Mozilla 1.8</td>
                                <td>Win 98+ / OSX.1+</td>
                                <td class=""center"">1.8</td>
                          ");
            WriteLiteral(@"      <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Seamonkey 1.1</td>
                                <td>Win 98+ / OSX.2+</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Gecko</td>
                                <td>Epiphany 2.20</td>
                                <td>Gnome</td>
                                <td class=""center"">1.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>Safari 1.2</td>
                                <td>OSX.3</td>
                                <t");
            WriteLiteral(@"d class=""center"">125.5</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>Safari 1.3</td>
                                <td>OSX.3</td>
                                <td class=""center"">312.8</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>Safari 2.0</td>
                                <td>OSX.4+</td>
                                <td class=""center"">419.3</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>Safari 3.0</td>
                                <td>O");
            WriteLiteral(@"SX.4+</td>
                                <td class=""center"">522.1</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>OmniWeb 5.5</td>
                                <td>OSX.4+</td>
                                <td class=""center"">420</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>iPod Touch / iPhone</td>
                                <td>iPod</td>
                                <td class=""center"">420.1</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Webkit</td>
                                <td>S");
            WriteLiteral(@"60</td>
                                <td>S60</td>
                                <td class=""center"">413</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 7.0</td>
                                <td>Win 95+ / OSX.1+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 7.5</td>
                                <td>Win 95+ / OSX.2+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Prest");
            WriteLiteral(@"o</td>
                                <td>Opera 8.0</td>
                                <td>Win 95+ / OSX.2+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 8.5</td>
                                <td>Win 95+ / OSX.2+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 9.0</td>
                                <td>Win 95+ / OSX.3+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            ");
            WriteLiteral(@"<tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 9.2</td>
                                <td>Win 88+ / OSX.3+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera 9.5</td>
                                <td>Win 88+ / OSX.3+</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Opera for Wii</td>
                                <td>Wii</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
          ");
            WriteLiteral(@"                  </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Nokia N800</td>
                                <td>N800</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Presto</td>
                                <td>Nintendo DS browser</td>
                                <td>Nintendo DS</td>
                                <td class=""center"">8.5</td>
                                <td class=""center"">C/A<sup>1</sup></td>
                            </tr>
                            <tr class=""gradeC"">
                                <td>KHTML</td>
                                <td>Konqureror 3.1</td>
                                <td>KDE 3.1</td>
                                <td class=""center"">3.1</td>
");
            WriteLiteral(@"                                <td class=""center"">C</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>KHTML</td>
                                <td>Konqureror 3.3</td>
                                <td>KDE 3.3</td>
                                <td class=""center"">3.3</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>KHTML</td>
                                <td>Konqureror 3.5</td>
                                <td>KDE 3.5</td>
                                <td class=""center"">3.5</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeX"">
                                <td>Tasman</td>
                                <td>Internet Explorer 4.5</td>
                                <td>Mac OS 8-9</td");
            WriteLiteral(@">
                                <td class=""center"">-</td>
                                <td class=""center"">X</td>
                            </tr>
                            <tr class=""gradeC"">
                                <td>Tasman</td>
                                <td>Internet Explorer 5.1</td>
                                <td>Mac OS 7.6-9</td>
                                <td class=""center"">1</td>
                                <td class=""center"">C</td>
                            </tr>
                            <tr class=""gradeC"">
                                <td>Tasman</td>
                                <td>Internet Explorer 5.2</td>
                                <td>Mac OS 8-X</td>
                                <td class=""center"">1</td>
                                <td class=""center"">C</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Misc</td>
                                <t");
            WriteLiteral(@"d>NetFront 3.1</td>
                                <td>Embedded devices</td>
                                <td class=""center"">-</td>
                                <td class=""center"">C</td>
                            </tr>
                            <tr class=""gradeA"">
                                <td>Misc</td>
                                <td>NetFront 3.4</td>
                                <td>Embedded devices</td>
                                <td class=""center"">-</td>
                                <td class=""center"">A</td>
                            </tr>
                            <tr class=""gradeX"">
                                <td>Misc</td>
                                <td>Dillo 0.8</td>
                                <td>Embedded devices</td>
                                <td class=""center"">-</td>
                                <td class=""center"">X</td>
                            </tr>
                            <tr class=""gradeX"">
                   ");
            WriteLiteral(@"             <td>Misc</td>
                                <td>Links</td>
                                <td>Text only</td>
                                <td class=""center"">-</td>
                                <td class=""center"">X</td>
                            </tr>
                            <tr class=""gradeX"">
                                <td>Misc</td>
                                <td>Lynx</td>
                                <td>Text only</td>
                                <td class=""center"">-</td>
                                <td class=""center"">X</td>
                            </tr>
                            <tr class=""gradeC"">
                                <td>Misc</td>
                                <td>IE Mobile</td>
                                <td>Windows Mobile 6</td>
                                <td class=""center"">-</td>
                                <td class=""center"">C</td>
                            </tr>
                            <tr cla");
            WriteLiteral(@"ss=""gradeC"">
                                <td>Misc</td>
                                <td>PSP browser</td>
                                <td>PSP</td>
                                <td class=""center"">-</td>
                                <td class=""center"">C</td>
                            </tr>
                            <tr class=""gradeU"">
                                <td>Other browsers</td>
                                <td>All others</td>
                                <td>-</td>
                                <td class=""center"">-</td>
                                <td class=""center"">U</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Rendering engine</th>
                                <th>Browser</th>
                                <th>Platform(s)</th>
                                <th>Engine version</th>
                                <");
            WriteLiteral("th>CSS grade</th>\r\n                            </tr>\r\n                        </tfoot>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84bc993d3f659e60bd55813ac18228172b997c831092", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b84bc993d3f659e60bd55813ac18228172b997c831374", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84bc993d3f659e60bd55813ac18228172b997c833746", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84bc993d3f659e60bd55813ac18228172b997c834028", async() => {
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
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84bc993d3f659e60bd55813ac18228172b997c835188", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $('.dataTables-example').DataTable({
                pageLength: 25,
                dom: '<""html5buttons""B>lTfgitp',
                buttons: [
                    { extend: 'copy' },
                    { extend: 'csv' },
                    { extend: 'excel', title: 'ExampleFile' },
                    { extend: 'pdf', title: 'ExampleFile' },

                    {
                        extend: 'print',
                        customize: function (win) {
                            $(win.document.body).addClass('white-bg');
                            $(win.document.body).css('font-size', '10px');

                            $(win.document.body).find('table')
                                .addClass('compact')
                                .css('font-size', 'inherit');
                        }
                    }
                ]

            });


        });


    </script");
                WriteLiteral(">\r\n");
            }
            );
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
