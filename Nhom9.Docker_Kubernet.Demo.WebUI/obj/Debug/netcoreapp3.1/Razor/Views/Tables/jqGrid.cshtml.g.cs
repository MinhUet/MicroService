#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\jqGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c130e7897d640cb08d5dca22e00f8141ee6d7d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tables_jqGrid), @"mvc.1.0.view", @"/Views/Tables/jqGrid.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c130e7897d640cb08d5dca22e00f8141ee6d7d28", @"/Views/Tables/jqGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tables_jqGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqGrid/ui.jqgrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqGrid/i18n/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqGrid/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\jqGrid.cshtml"
  
    ViewData["Title"] = "jqGrid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>jqGrid</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 303, 1);
#nullable restore
#line 11 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Tables\jqGrid.cshtml"
WriteAttributeValue("", 263, Url.Action("Dashboard_1", "Dashboards"), 263, 40, false);

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
                <strong>jqGrid</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>jQuery Grid Plugin – jqGrid</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        <strong>jqGrid</strong> is an Ajax-enabled JavaScript control that provides solutions for representing and manipulating tabular data on the web. Since the grid is a client-side solution loading data dynamically through Ajax callbacks, it can be integrated with any server-side technology, including PHP, ASP, Java Servlets, JSP, ColdFusion, and Perl.
                        jqGrid uses a j");
            WriteLiteral(@"Query Java Script Library and is written as plugin for that package. For more information on jQuery Grid, please refer to the <a target=""_blank"" href=""http://www.trirand.com/blog/""> jqGrid web site.</a>
                    </p>

                    <h4>Basic example</h4>

                    <div class=""jqGrid_wrapper"">
                        <table id=""table_list_1""></table>
                        <div id=""pager_list_1""></div>
                    </div>

                    <h4>Advanced example</h4>
                    <p>

                    </p>

                    <div class=""jqGrid_wrapper"">
                        <table id=""table_list_2""></table>
                        <div id=""pager_list_2""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c130e7897d640cb08d5dca22e00f8141ee6d7d288070", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c130e7897d640cb08d5dca22e00f8141ee6d7d288351", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c130e7897d640cb08d5dca22e00f8141ee6d7d2810722", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c130e7897d640cb08d5dca22e00f8141ee6d7d2811004", async() => {
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
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c130e7897d640cb08d5dca22e00f8141ee6d7d2812164", async() => {
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

            // Examle data for jqGrid
            var mydata = [
                { id: ""1"", invdate: ""2010-05-24"", name: ""test"", note: ""note"", tax: ""10.00"", total: ""2111.00"" },
                { id: ""2"", invdate: ""2010-05-25"", name: ""test2"", note: ""note2"", tax: ""20.00"", total: ""320.00"" },
                { id: ""3"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", tax: ""30.00"", total: ""430.00"" },
                { id: ""4"", invdate: ""2007-10-04"", name: ""test"", note: ""note"", tax: ""10.00"", total: ""210.00"" },
                { id: ""5"", invdate: ""2007-10-05"", name: ""test2"", note: ""note2"", tax: ""20.00"", total: ""320.00"" },
                { id: ""6"", invdate: ""2007-09-06"", name: ""test3"", note: ""note3"", tax: ""30.00"", total: ""430.00"" },
                { id: ""7"", invdate: ""2007-10-04"", name: ""test"", note: ""note"", tax: ""10.00"", total: ""210.00"" },
                { id: ""8"", invdate: ""2007-10-03"", name: ""test2"", note: ""note2"", ");
                WriteLiteral(@"amount: ""300.00"", tax: ""21.00"", total: ""320.00"" },
                { id: ""9"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""11"", invdate: ""2007-10-01"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""12"", invdate: ""2007-10-02"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
                { id: ""13"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""14"", invdate: ""2007-10-04"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""15"", invdate: ""2007-10-05"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
                { id: ""16"", invdate: ""2007-09-06"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""17"", invdate: ""2007-10-");
                WriteLiteral(@"04"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""18"", invdate: ""2007-10-03"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
                { id: ""19"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""21"", invdate: ""2007-10-01"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""22"", invdate: ""2007-10-02"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
                { id: ""23"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""24"", invdate: ""2007-10-04"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""25"", invdate: ""2007-10-05"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
            ");
                WriteLiteral(@"    { id: ""26"", invdate: ""2007-09-06"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" },
                { id: ""27"", invdate: ""2007-10-04"", name: ""test"", note: ""note"", amount: ""200.00"", tax: ""10.00"", total: ""210.00"" },
                { id: ""28"", invdate: ""2007-10-03"", name: ""test2"", note: ""note2"", amount: ""300.00"", tax: ""20.00"", total: ""320.00"" },
                { id: ""29"", invdate: ""2007-09-01"", name: ""test3"", note: ""note3"", amount: ""400.00"", tax: ""30.00"", total: ""430.00"" }
            ];

            // Configuration for jqGrid Example 1
            $(""#table_list_1"").jqGrid({
                data: mydata,
                datatype: ""local"",
                height: 250,
                autowidth: true,
                shrinkToFit: true,
                rowNum: 14,
                rowList: [10, 20, 30],
                colNames: ['Inv No', 'Date', 'Client', 'Amount', 'Tax', 'Total', 'Notes'],
                colModel: [
                    { name: 'id', index:");
                WriteLiteral(@" 'id', width: 60, sorttype: ""int"" },
                    { name: 'invdate', index: 'invdate', width: 90, sorttype: ""date"", formatter: ""date"" },
                    { name: 'name', index: 'name', width: 100 },
                    { name: 'amount', index: 'amount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"" },
                    { name: 'tax', index: 'tax', width: 80, align: ""right"", sorttype: ""float"" },
                    { name: 'total', index: 'total', width: 80, align: ""right"", sorttype: ""float"" },
                    { name: 'note', index: 'note', width: 150, sortable: false }
                ],
                pager: ""#pager_list_1"",
                viewrecords: true,
                caption: ""Example jqGrid 1"",
                hidegrid: false
            });

            // Configuration for jqGrid Example 2
            $(""#table_list_2"").jqGrid({
                data: mydata,
                datatype: ""local"",
                height: 450,
                autow");
                WriteLiteral(@"idth: true,
                shrinkToFit: true,
                rowNum: 20,
                rowList: [10, 20, 30],
                colNames: ['Inv No', 'Date', 'Client', 'Amount', 'Tax', 'Total', 'Notes'],
                colModel: [
                    { name: 'id', index: 'id', editable: true, width: 60, sorttype: ""int"", search: true },
                    { name: 'invdate', index: 'invdate', editable: true, width: 90, sorttype: ""date"", formatter: ""date"" },
                    { name: 'name', index: 'name', editable: true, width: 100 },
                    { name: 'amount', index: 'amount', editable: true, width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"" },
                    { name: 'tax', index: 'tax', editable: true, width: 80, align: ""right"", sorttype: ""float"" },
                    { name: 'total', index: 'total', editable: true, width: 80, align: ""right"", sorttype: ""float"" },
                    { name: 'note', index: 'note', editable: true, width: 100, sortable: false }
");
                WriteLiteral(@"                ],
                pager: ""#pager_list_2"",
                viewrecords: true,
                caption: ""Example jqGrid 2"",
                add: true,
                edit: true,
                addtext: 'Add',
                edittext: 'Edit',
                hidegrid: false
            });

            // Add selection
            $(""#table_list_2"").setSelection(4, true);


            // Setup buttons
            $(""#table_list_2"").jqGrid('navGrid', '#pager_list_2',
                    { edit: true, add: true, del: true, search: true },
                    { height: 200, reloadAfterSubmit: true }
            );

            // Add responsive to jqGrid
            $(window).bind('resize', function () {
                var width = $('.jqGrid_wrapper').width();
                $('#table_list_1').setGridWidth(width);
                $('#table_list_2').setGridWidth(width);
            });

        });
    </script>
");
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
