#pragma checksum "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6db4be2ee12ddc6eb6d3f03fe419b3ab3d7eba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inference_PredictedValue), @"mvc.1.0.view", @"/Views/Inference/PredictedValue.cshtml")]
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
#line 1 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/_ViewImports.cshtml"
using CrashUtahProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/_ViewImports.cshtml"
using CrashUtahProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/_ViewImports.cshtml"
using CrashUtahProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6db4be2ee12ddc6eb6d3f03fe419b3ab3d7eba7", @"/Views/Inference/PredictedValue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf465c4710309e83ab848b855582f6deaea0006", @"/Views/_ViewImports.cshtml")]
    public class Views_Inference_PredictedValue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card-shadow grid\">\r\n    <h1>Predicted Severity Score:</h1>\r\n");
#nullable restore
#line 5 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
     if (Model.PredictedValue < 1.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>No Injury</h1>\r\n");
#nullable restore
#line 8 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 2.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Possible Injury</h1>\r\n");
#nullable restore
#line 12 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 3.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Suspected Minor Injury</h1>\r\n");
#nullable restore
#line 16 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 4.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Suspected Serious Injury</h1>\r\n");
#nullable restore
#line 20 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Fatal</h1>\r\n");
#nullable restore
#line 24 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
