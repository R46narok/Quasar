// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Quasar.Hybrid.WebUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
#line 1 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Quasar.Hybrid.WebUI.Shared;

#line default
#line hidden
#line 8 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\_Imports.razor"
using Quasar.Hybrid.Shared;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
