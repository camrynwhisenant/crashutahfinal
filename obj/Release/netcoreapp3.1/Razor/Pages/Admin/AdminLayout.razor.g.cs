#pragma checksum "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3844391dbde3b0079e5b454ca41bd28fc6b3ee50"
// <auto-generated/>
#pragma warning disable 1591
namespace CrashUtahProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/_Imports.razor"
using CrashUtahProject.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-info text-white p-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"col-10\">\r\n                <span class=\"navbar-brand m-lg-2\">Crash Utah Administration</span>\r\n            </div>\r\n\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-1");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-light btn-sm ");
            __builder.AddAttribute(15, "href", "/admin/create");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Create");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.AddMarkupContent(20, "<div class=\"col-1\">\r\n                <a class=\"btn btn-sm btn-dark\" href=\"/account/logout\">Log Out</a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(26, "href", "/admin");
            __builder.AddAttribute(27, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(28, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/AdminLayout.razor"
                                                                                                             NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, "Admin Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container-fluid");
            __builder.AddMarkupContent(34, "\r\n    ");
#nullable restore
#line 24 "/Users/camrynwhisenant/Downloads/CrashUtah2/Pages/Admin/AdminLayout.razor"
__builder.AddContent(35, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
