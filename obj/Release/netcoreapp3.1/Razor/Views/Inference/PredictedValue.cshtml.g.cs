#pragma checksum "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a880f1872bb7823516dfd07f6badcea530b1c8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a880f1872bb7823516dfd07f6badcea530b1c8", @"/Views/Inference/PredictedValue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf465c4710309e83ab848b855582f6deaea0006", @"/Views/_ViewImports.cshtml")]
    public class Views_Inference_PredictedValue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a880f1872bb7823516dfd07f6badcea530b1c83216", async() => {
                WriteLiteral("\r\n    <title>Predicted Value</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"card-shadow grid\">\r\n    <h1>Predicted Severity Score:</h1>\r\n");
#nullable restore
#line 7 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
     if (Model.PredictedValue < 1.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>No Injury</h1>\r\n");
#nullable restore
#line 10 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 2.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Possible Injury</h1>\r\n");
#nullable restore
#line 14 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 3.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Suspected Minor Injury</h1>\r\n");
#nullable restore
#line 18 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else if (Model.PredictedValue < 4.5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Suspected Serious Injury</h1>\r\n");
#nullable restore
#line 22 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Fatal</h1>\r\n");
#nullable restore
#line 26 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Inference/PredictedValue.cshtml"
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
