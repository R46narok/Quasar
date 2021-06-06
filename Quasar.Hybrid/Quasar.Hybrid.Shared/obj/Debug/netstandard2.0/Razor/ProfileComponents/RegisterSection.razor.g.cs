#pragma checksum "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e20161e7742e51aee13c9fb25e5d3203860984e"
// <auto-generated/>
#pragma warning disable 1591
namespace Quasar.Hybrid.Shared.ProfileComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\_Imports.razor"
using Quasar.Hybrid.Shared;

#line default
#line hidden
#line 1 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
using System.Text;

#line default
#line hidden
#line 3 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
using System.Text.Json;

#line default
#line hidden
#line 4 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
using Quasar.Core;

#line default
#line hidden
#line 5 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
using Quasar.Core.DataAccess;

#line default
#line hidden
    public partial class RegisterSection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "login");
            __builder.AddAttribute(2, "class", "container reg-log-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h3>Join team Quasar now</h3>\r\n    ");
            __builder.AddMarkupContent(5, "<p style=\"color: rgb(74,75,77);\">Experience fully your Gen1 device. Improve your everyday life.</p>\r\n\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "username-field");
            __builder.AddAttribute(9, "placeholder", "Username");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 17 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                                           e => { UsernameValue = (string) e.Value; }

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                  UsernameValue

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UsernameValue = __value, UsernameValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    <p></p>\r\n\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "email");
            __builder.AddAttribute(16, "class", "email-field");
            __builder.AddAttribute(17, "placeholder", "Email@example.com");
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 22 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                                          (e) => { EmailValue = (string)e.Value;}

#line default
#line hidden
            ));
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 22 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                  EmailValue

#line default
#line hidden
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmailValue = __value, EmailValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n    <p></p>\r\n\r\n    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "password");
            __builder.AddAttribute(24, "class", "pass-field");
            __builder.AddAttribute(25, "placeholder", "Password");
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 27 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                                           e => { PasswordValue = (string) e.Value; }

#line default
#line hidden
            ));
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 27 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                  PasswordValue

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PasswordValue = __value, PasswordValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    <p></p>\r\n\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "style", "background-color: rgb(249, 178, 51); color: black;");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                                                                                                                       RegisterBtnClicked

#line default
#line hidden
            ));
            __builder.AddContent(35, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary secondary-btn");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "style", "background-color: rgb(72,74,77);");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 32 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
                                                                                                                   LoginBtnClicked

#line default
#line hidden
            ));
            __builder.AddContent(42, "Log in");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 35 "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\RegisterSection.razor"
       


    private string UsernameValue { get; set; } = string.Empty;
    private string EmailValue { get; set; } = string.Empty;
    private string PasswordValue { get; set; } = string.Empty;


    private async Task RegisterBtnClicked()
    {
        var salt = UserCredentialsHasher.GenerateSalt(64);
        var passwordBytes = Encoding.UTF8.GetBytes(PasswordValue);

        User user = new User
        {
            Username = UsernameValue,
            Email = EmailValue,
            PasswordHash = UserCredentialsHasher.GenerateHash(passwordBytes, salt, 10, passwordBytes.Length),
            PasswordIterations = 10,
            PasswordSalt = salt
        };

        var json = JsonSerializer.Serialize(user);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        await HttpClient.PostAsync("api/user/register", content);
    }


    private void LoginBtnClicked()
    {
        NavigationManager.NavigateTo("/login");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private User User { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
