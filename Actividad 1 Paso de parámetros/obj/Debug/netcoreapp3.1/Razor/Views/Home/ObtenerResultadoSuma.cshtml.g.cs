#pragma checksum "A:\7mo Semestre\Programación Web\Actividad 1 Paso de parámetros\Actividad 1 Paso de parámetros\Views\Home\ObtenerResultadoSuma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e667e809c2826d7640ea48f7cd8db8a953bf331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ObtenerResultadoSuma), @"mvc.1.0.view", @"/Views/Home/ObtenerResultadoSuma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e667e809c2826d7640ea48f7cd8db8a953bf331", @"/Views/Home/ObtenerResultadoSuma.cshtml")]
    public class Views_Home_ObtenerResultadoSuma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Int32>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "A:\7mo Semestre\Programación Web\Actividad 1 Paso de parámetros\Actividad 1 Paso de parámetros\Views\Home\ObtenerResultadoSuma.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Resultado de los valores</h1>\r\n<p>\r\n    El resultado de la suma de tus dos valores es: ");
#nullable restore
#line 7 "A:\7mo Semestre\Programación Web\Actividad 1 Paso de parámetros\Actividad 1 Paso de parámetros\Views\Home\ObtenerResultadoSuma.cshtml"
                                              Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Int32> Html { get; private set; }
    }
}
#pragma warning restore 1591
