#pragma checksum "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43139a5306d15b1eb5147cf265d2efc0b3e6570f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Mario\Documents\MetProg\tarea1\Views\_ViewImports.cshtml"
using tarea1;

#line default
#line hidden
#line 2 "C:\Users\Mario\Documents\MetProg\tarea1\Views\_ViewImports.cshtml"
using tarea1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43139a5306d15b1eb5147cf265d2efc0b3e6570f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2aada87970059bfb067034afc8dc8e6b51fb2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tarea1.Models.Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 25, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n");
            EndContext();
#line 6 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(135, 24, false);
#line 8 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
Write(Html.Label(Model.Saludo));

#line default
#line hidden
            EndContext();
            BeginContext(161, 11, true);
            WriteLiteral("    <br/>\r\n");
            EndContext();
            BeginContext(178, 24, false);
#line 10 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
Write(Html.Label(Model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(204, 22, true);
            WriteLiteral("    <br/>\r\n    <br/>\r\n");
            EndContext();
            BeginContext(228, 42, false);
#line 13 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
Write(Html.TextBoxFor(persona => persona.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(272, 51, true);
            WriteLiteral("   <br/>\r\n   <input type=\"submit\" name=\"submit\"/>\r\n");
            EndContext();
#line 16 "C:\Users\Mario\Documents\MetProg\tarea1\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(326, 199, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tarea1.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591