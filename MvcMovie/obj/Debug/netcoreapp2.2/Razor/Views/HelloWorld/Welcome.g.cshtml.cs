#pragma checksum "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/HelloWorld/Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e7a7d51d812944c87a51d8f0e001c6843f08ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
#line 1 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e7a7d51d812944c87a51d8f0e001c6843f08ae", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/HelloWorld/Welcome.cshtml"
  
    ViewData["Title"] = "Welcome from <View>";

#line default
#line hidden
            BeginContext(52, 23, true);
            WriteLiteral("\n<h2>Welcome</h2>\n<ul>\n");
            EndContext();
#line 7 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/HelloWorld/Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(138, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(151, 19, false);
#line 9 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/HelloWorld/Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(170, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 10 "/Users/cathyli99/Desktop/Training/DotNet/MvcMovie/MvcMovie/Views/HelloWorld/Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(182, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
