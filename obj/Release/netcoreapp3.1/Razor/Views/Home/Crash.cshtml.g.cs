#pragma checksum "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a691ec3747ff97660e735b176182ab49c6ff00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Crash), @"mvc.1.0.view", @"/Views/Home/Crash.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a691ec3747ff97660e735b176182ab49c6ff00", @"/Views/Home/Crash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf465c4710309e83ab848b855582f6deaea0006", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Crash : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Accident>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a691ec3747ff97660e735b176182ab49c6ff003219", async() => {
                WriteLiteral("\r\n        <title>Crash Details</title>\r\n    ");
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
            WriteLiteral("\r\n  \r\n            <div class=\"crash-data-page-table card-shadow\">\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Crash ID:</div>\r\n                    <div>");
#nullable restore
#line 14 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.crash_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Crash Date:</div>\r\n                    <div>");
#nullable restore
#line 18 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.crash_datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Latitude:</div>\r\n                    <div>");
#nullable restore
#line 22 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.lat_utm_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Milepoint:</div>\r\n                    <div>");
#nullable restore
#line 26 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.milepoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Longitude::</div>\r\n                    <div>");
#nullable restore
#line 30 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.long_utm_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Route:</div>\r\n                    <div>");
#nullable restore
#line 34 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.route);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Main Road:</div>\r\n                    <div>");
#nullable restore
#line 38 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.main_road_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">City:</div>\r\n                    <div>");
#nullable restore
#line 42 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">County:</div>\r\n                    <div>");
#nullable restore
#line 46 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.county_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Crash Severity:</div>\r\n                    <div>");
#nullable restore
#line 50 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.crash_severity_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Pedestrian Involved:??</div>\r\n                    <div>");
#nullable restore
#line 54 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.pedestrian_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Work Zone Related:??</div>\r\n                    <div>");
#nullable restore
#line 58 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.work_zone_related);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Bicyclist Involved:??</div>\r\n                    <div>");
#nullable restore
#line 62 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.bicyclist_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Motorcycle Involved:??</div>\r\n                    <div>");
#nullable restore
#line 66 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.motorcycle_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Improper Restraint:</div>\r\n                    <div>");
#nullable restore
#line 70 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.improper_restraint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Unrestrained:</div>\r\n                    <div>");
#nullable restore
#line 74 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.unrestrained);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">DUI:</div>\r\n                    <div>");
#nullable restore
#line 78 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.dui);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Intersection Related:</div>\r\n                    <div>");
#nullable restore
#line 82 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.intersection_related);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Wild Animal Related:</div>\r\n                    <div>");
#nullable restore
#line 86 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.wild_animal_related);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Domestic Animal Related:</div>\r\n                    <div>");
#nullable restore
#line 90 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.domestic_animal_related);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Overturn Rollover:</div>\r\n                    <div>");
#nullable restore
#line 94 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.overturn_rollover);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Commercial Moter Vehicle Involved:</div>\r\n                    <div>");
#nullable restore
#line 98 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.commercial_motor_veh_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Teenage Driver Involved:</div>\r\n                    <div>");
#nullable restore
#line 102 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.teenage_driver_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Older Driver Involved:</div>\r\n                    <div>");
#nullable restore
#line 106 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.older_driver_involved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Night/Dark Condition:</div>\r\n                    <div>");
#nullable restore
#line 110 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.night_dark_condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Single Vehicle: </div>\r\n                    <div>");
#nullable restore
#line 114 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.single_vehicle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Distracted Driving: </div>\r\n                    <div>");
#nullable restore
#line 118 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.distracted_driving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Drowsy Driving:</div>\r\n                    <div>");
#nullable restore
#line 122 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.drowsy_driving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"crash-line-item\">\r\n                    <div class=\"text-bold\">Roadway Departure:</div>\r\n                    <div>");
#nullable restore
#line 126 "/Users/camrynwhisenant/Downloads/CrashUtah2/Views/Home/Crash.cshtml"
                    Write(Model.roadway_departure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Accident> Html { get; private set; }
    }
}
#pragma warning restore 1591
