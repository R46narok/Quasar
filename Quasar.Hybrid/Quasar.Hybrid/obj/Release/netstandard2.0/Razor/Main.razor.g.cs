#pragma checksum "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02894dd0ddc378196754cec5a850da47d60cce29"
// <auto-generated/>
#pragma warning disable 1591
namespace Quasar.Hybrid
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
#line 5 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\_Imports.razor"
using Quasar.Hybrid.Shared;

#line default
#line hidden
    public partial class Main : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.MobileBlazorBindings.Elements.ContentView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.MobileBlazorBindings.Elements.StackLayout>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.MobileBlazorBindings.Elements.BlazorWebView>(6);
                    __builder3.AddAttribute(7, "VerticalOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.LayoutOptions?>(
#line 3 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\Main.razor"
                                        LayoutOptions.FillAndExpand

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(9, "\r\n            ");
                        __builder4.OpenComponent<Quasar.Hybrid.WebUI.App>(10);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(11, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
