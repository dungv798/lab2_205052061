#pragma checksum "D:\321\Lab2_205052061\Lab2_205052061\Lab2_205052061\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1dda3509ccd169d102414d28706a21daa27d4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "D:\321\Lab2_205052061\Lab2_205052061\Lab2_205052061\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#line 2 "D:\321\Lab2_205052061\Lab2_205052061\Lab2_205052061\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dda3509ccd169d102414d28706a21daa27d4ee", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d6898af3ee645766c02769f00bd7edd74cd52", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\321\Lab2_205052061\Lab2_205052061\Lab2_205052061\Views\HelloWorld\Index.cshtml"
  
    ViewData["Title"] = "Movie List";

#line default
#line hidden
            BeginContext(46, 62, true);
            WriteLiteral("<h2>My Movie List</h2>\r\n<p>Hello from our View Template!</p>\r\n");
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
