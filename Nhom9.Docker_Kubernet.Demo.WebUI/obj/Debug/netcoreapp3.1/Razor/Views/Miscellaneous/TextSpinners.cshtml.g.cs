#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Miscellaneous\TextSpinners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9689b7f9fb2285d3dc69ab622644fd741a29498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_TextSpinners), @"mvc.1.0.view", @"/Views/Miscellaneous/TextSpinners.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9689b7f9fb2285d3dc69ab622644fd741a29498", @"/Views/Miscellaneous/TextSpinners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_TextSpinners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/textSpinners/spinners.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Miscellaneous\TextSpinners.cshtml"
  
    ViewData["Title"] = "TextSpinners";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Text spinners</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 312, 1);
#nullable restore
#line 9 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Miscellaneous\TextSpinners.cshtml"
WriteAttributeValue("", 272, Url.Action("Dashboard_1", "Dashboards"), 272, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Text spinners</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Text spinners</h5>
                </div>

                <div class=""ibox-content"">

                    <p class=""font-bold"">
                        Pure text, CSS only, font independent, inline loading indicators.
                    </p>

                    <p>
                        This project tries to mimic command line spinners like those from cli-spinners (where most of them are taken from) and bring them to the web. <a href=""http://tawian.io/text-spinners");
            WriteLiteral(@"/"" target=""_blank"">http://tawian.io/text-spinners/</a>
                    </p>


                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Ellip </h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading""></span>
                    </div>
                    <code> &lt;span class=""loading""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Dots</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading dots""></span>
    ");
            WriteLiteral(@"                </div>
                    <code> &lt;span class=""loading dots""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Dots 2</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading dots2""></span>
                    </div>
                    <code> &lt;span class=""loading dots2""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Dots 3 </h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <spa");
            WriteLiteral(@"n class=""loading dots3""></span>
                    </div>
                    <code> &lt;span class=""loading dots3""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Line</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading line""></span>
                    </div>
                    <code> &lt;span class=""loading line""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Line 2</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span cl");
            WriteLiteral(@"ass=""loading line2""></span>
                    </div>
                    <code> &lt;span class=""loading line2""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Lifting </h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading lifting""></span>
                    </div>
                    <code> &lt;span class=""loading lifting""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Hamburger</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs");
            WriteLiteral(@" text-navy"">
                        <span class=""loading hamburger""></span>
                    </div>
                    <code> &lt;span class=""loading hamburger""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Bar</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading bar""></span>
                    </div>
                    <code> &lt;span class=""loading bar""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Bar 2 </h5>
                </div>
                <div class=""ibox-content text-center"">
   ");
            WriteLiteral(@"                 <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading bar2""></span>
                    </div>
                    <code> &lt;span class=""loading bar2""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Circle</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading circle""></span>
                    </div>
                    <code> &lt;span class=""loading circle""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Triangle</h5>
                </div>
                <div class=""ibox-content text-center"">
 ");
            WriteLiteral(@"                   <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading triangle""></span>
                    </div>
                    <code> &lt;span class=""loading triangle""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Bullet </h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading bullet""></span>
                    </div>
                    <code> &lt;span class=""loading bullet""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Rhomb</h5>
                </div>
            ");
            WriteLiteral(@"    <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading rhomb""></span>
                    </div>
                    <code> &lt;span class=""loading rhomb""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Toggle</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading toggle""></span>
                    </div>
                    <code> &lt;span class=""loading toggle""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Box bounce");
            WriteLiteral(@" </h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading box-bounce""></span>
                    </div>
                    <code> &lt;span class=""loading box-bounce""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Star</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading star""></span>
                    </div>
                    <code> &lt;span class=""loading star""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5");
            WriteLiteral(@">Words</h5>
                </div>
                <div class=""ibox-content text-center"">
                    <div class=""h1 m-t-xs text-navy"">
                        <span class=""loading words""></span>
                    </div>
                    <code> &lt;span class=""loading words""&gt;&lt;/span&gt; </code>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Example usage with Bootstrap button</h5>
                </div>
                <div class=""ibox-content  text-center"">

                    <button class=""btn btn-default"">Loading <span class=""loading""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading dots""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading dots2""></span> </button>
                    <button class=""bt");
            WriteLiteral(@"n btn-default"">Loading <span class=""loading dots3""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading line""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading bar""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading triangle""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading bar2""></span> </button>
                    <button class=""btn btn-default"">Loading <span class=""loading bullet""></span> </button>
                    <br />
                    <button class=""btn btn-primary"">Loading <span class=""loading triangles""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading beam""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading arrow""></span> </button>
                    <button class=""btn btn-primary"">Loading <span c");
            WriteLiteral(@"lass=""loading open-circle""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading rhomb""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading star""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading triangle""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading circle""></span> </button>
                    <button class=""btn btn-primary"">Loading <span class=""loading fish""></span> </button>


                </div>
            </div>
        </div>
    </div>

</div>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9689b7f9fb2285d3dc69ab622644fd741a2949819172", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9689b7f9fb2285d3dc69ab622644fd741a2949819454", async() => {
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
