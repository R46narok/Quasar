// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Quasar.Hybrid.WebUI.Pages
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
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\Pages\FetchData.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid\WebUI\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        // The static web asset is loaded from the wwwroot from _content/<AssemblyOrNugetName>/weather.json
        // see https://docs.microsoft.com/aspnet/core/razor-pages/ui-class?view=aspnetcore-3.1&tabs=visual-studio#consume-content-from-a-referenced-rcl for more info

        var fileInfo = FileProvider.GetFileInfo("_content/Quasar.Hybrid/weather.json");

        if (fileInfo != null && fileInfo.Exists)
        {
            using (var stream = fileInfo.CreateReadStream())
            {
                forecasts = await JsonSerializer.DeserializeAsync<WeatherForecast[]>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.FileProviders.IFileProvider FileProvider { get; set; }
    }
}
#pragma warning restore 1591