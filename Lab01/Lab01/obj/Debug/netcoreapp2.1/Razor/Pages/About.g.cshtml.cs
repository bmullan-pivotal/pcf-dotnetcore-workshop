#pragma checksum "/Users/bmullan/Downloads/pcf-dotnetcore-workshop/Lab01/Lab01/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e81e69373cd5383ea567dcadb7b4c62153783692"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Lab01.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(Lab01.Pages.Pages_About), null)]
namespace Lab01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/bmullan/Downloads/pcf-dotnetcore-workshop/Lab01/Lab01/Pages/_ViewImports.cshtml"
using Lab01;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e81e69373cd5383ea567dcadb7b4c62153783692", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b09daeadd866cc6b721c04cd7f700632588ccb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/bmullan/Downloads/pcf-dotnetcore-workshop/Lab01/Lab01/Pages/About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(62, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(67, 17, false);
#line 6 "/Users/bmullan/Downloads/pcf-dotnetcore-workshop/Lab01/Lab01/Pages/About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(84, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(95, 13, false);
#line 7 "/Users/bmullan/Downloads/pcf-dotnetcore-workshop/Lab01/Lab01/Pages/About.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(108, 63, true);
            WriteLiteral("</h3>\n\n<p>Use this area to provide additional information.</p>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
