#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Peity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef3566c50078106b79c8980d1936ec3d6e9ed84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graphs_Peity), @"mvc.1.0.view", @"/Views/Graphs/Peity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef3566c50078106b79c8980d1936ec3d6e9ed84", @"/Views/Graphs/Peity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Graphs_Peity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/peity/jquery.peity.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/peity/jquery.peity.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Peity.cshtml"
  
    ViewData["Title"] = "Peity";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Peity Charts</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 257, "\"", 304, 1);
#nullable restore
#line 9 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Peity.cshtml"
WriteAttributeValue("", 264, Url.Action("Dashboard_1", "Dashboards"), 264, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Graphs</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Peity Charts</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInDown"">
    <div class=""row"">
        <div class=""col-lg-5"">
            <div class=""jumbotron"">
                <h1>Peity Charts</h1>
                <p>Is a perfect library for inline graphics visualization data.</p>
                <p>
                    <a href=""http://benpickles.github.io/peity/"" target=""_blank"" class=""btn btn-primary btn-lg"" role=""button"">Learn more about Peity</a>
                </p>
            </div>
        </div>
        <div class=""col-lg-7"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Pie Charts <small>With custom colors.</small></h5>
                    <div class=""ibox-tools"">
               ");
            WriteLiteral(@"         <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div>
                    <table class=""table table-bordered white-bg"">
                        <thead>
                            <tr>
                                <th>Graph</th>
                                <th>Code</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <td>
                                    <span class=""pie"">1/5</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;1/5&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span cl");
            WriteLiteral(@"ass=""pie"">226/360</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;226/360&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">0.52/1.561</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;0.52/1.561&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">1,4</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;1,4&lt;/span&gt;</code>
                                </td>
             ");
            WriteLiteral(@"               </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">226,134</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;226,134&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">0.52,1.041</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;0.52,1.041&lt;/span&gt;</code>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox");
            WriteLiteral(@" "">
                <div class=""ibox-title"">
                    <h5>Line and Bars Charts</h5>
                    <div class=""ibox-tools"">
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div>
                    <table class=""table table-bordered white-bg"">
                        <thead>
                            <tr>
                                <th>Graph</th>
                                <th>Code</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <span data-diameter=""40"" class=""updating-chart"">5,3,9,6,5,9,7,3,5,2,5,3,9,6,5,9,7,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""");
            WriteLiteral(@"line""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""line"">5,3,9,6,5,9,7,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""line"">5,3,2,-1,-3,-2,2,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;5,3,2,-1,-3,-2,2,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                ");
            WriteLiteral(@"<td>
                                    <span class=""line"">0,-3,-6,-4,-5,-4,-7,-3,-5,-2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;0,-3,-6,-4,-5,-4,-7,-3,-5,-2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""bar"">5,3,9,6,5,9,7,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""bar""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""bar"">5,3,2,-1,-3,-2,2,3,5,2</span>
                                </td>
                                <td>
            ");
            WriteLiteral(@"                        <code>&lt;span class=""bar""&gt;5,3,2,-1,-3,-2,2,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef3566c50078106b79c8980d1936ec3d6e9ed8413471", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef3566c50078106b79c8980d1936ec3d6e9ed8413753", async() => {
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
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef3566c50078106b79c8980d1936ec3d6e9ed8415886", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef3566c50078106b79c8980d1936ec3d6e9ed8416168", async() => {
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
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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

            $(""span.pie"").peity(""pie"", {
                fill: ['#1ab394', '#d7d7d7', '#ffffff']
            })

            $("".line"").peity(""line"", {
                fill: '#1ab394',
                stroke: '#169c81',
            })

            $("".bar"").peity(""bar"", {
                fill: [""#1ab394"", ""#d7d7d7""]
            })

            $("".bar_dashboard"").peity(""bar"", {
                fill: [""#1ab394"", ""#d7d7d7""],
                width: 100
            })

            var updatingChart = $("".updating-chart"").peity(""line"", { fill: '#1ab394', stroke: '#169c81', width: 64 })

            setInterval(function () {
                var random = Math.round(Math.random() * 10)
                var values = updatingChart.text().split("","")
                values.shift()
                values.push(random)

                updatingChart
                    .text(values.join("",""))
                    .c");
                WriteLiteral("hange()\r\n            }, 1000);\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
