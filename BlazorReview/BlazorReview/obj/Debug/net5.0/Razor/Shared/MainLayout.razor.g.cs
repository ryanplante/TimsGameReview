#pragma checksum "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cffe1f191f9666ad790df5e2162b6f681138c523607cbff365af8e324b91a344"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorReview.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-k8itx9fhfy");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-k8itx9fhfy");
            __builder.OpenComponent<global::BlazorReview.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-k8itx9fhfy");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-k8itx9fhfy><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-k8itx9fhfy>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-k8itx9fhfy");
#nullable restore
#line 14 "C:\Users\knigh\OneDrive\Desktop\TimsGameReview\BlazorReview\BlazorReview\Shared\MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
