#pragma checksum "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d324c92d8be89f5acae3ae4925ba800ddcb9d8d"
// <auto-generated/>
#pragma warning disable 1591
namespace Quasar.Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Quasar.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Quasar.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\_Imports.razor"
using Quasar.Hybrid.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Quasar.Hybrid.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "main");
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
