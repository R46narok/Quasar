#pragma checksum "D:\Development\Projects\Quasar\Quasar.Hybrid\Quasar.Hybrid.Shared\ProfileComponents\ProfileSection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d43532b5b71b1bf97726a61335b012008f5d77c"
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
    public partial class ProfileSection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container profile-section\">\r\n    <div class=\"row\">\r\n        <div class=\"col profile-nav\">\r\n            <a class=\"text-left profile-nav-link\" href=\"#\" style=\"/*color: rgb(0,0,0);*/font-size: 20px;\">Overview</a><a class=\"text-left profile-nav-link\" href=\"#\" style=\"/*color: rgb(0,0,0);*/font-size: 20px;\">Configurations</a><a class=\"text-left profile-nav-link\" href=\"#\" style=\"/*color: rgb(0,0,0);*/font-size: 20px;\">Achievements</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <div>\r\n                <img class=\"rounded-circle avatar-img\" src=\"img/avatar.jpg\">\r\n                <h4 class=\"text-left\">Username</h4>\r\n            </div>\r\n            <h5 class=\"text-left\" style=\"color: rgb(123,120,120);\">Email</h5><button class=\"btn btn-primary edit-profile-btn\" type=\"button\" style=\"background-color: rgb(249,178,51);color: rgb(0,0,0);\">Edit profile</button>\r\n        </div>\r\n        <div class=\"col-9\">\r\n            <p class=\"text-left profile-section-title\">Devices owned:</p>\r\n            <div class=\"shadow\" style=\"padding: 10px;text-align: right;margin-top: -10px;\">\r\n                <p class=\"text-left\">{DEVICE_NAME} - Gen 1<br></p><button class=\"btn btn-primary text-right\" type=\"button\" style=\"background-color: rgb(249,178,51);color: rgb(0,0,0);\">Manage devices</button>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-8\">\r\n                    <p class=\"text-left profile-section-title\">Lab activity:</p>\r\n                </div>\r\n                <div class=\"col\" style=\"text-align: right;\">\r\n                    <div class=\"dropdown\">\r\n                        <button class=\"btn btn-primary dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\" type=\"button\" style=\"margin-top: 10px;/*margin-left: 38px;*/background-color: inherit;color: rgb(114,93,93);/*align-self: end;*/border: none;\">Activity settings</button>\r\n                        <div class=\"dropdown-menu\" role=\"menu\"><a class=\"dropdown-item\" role=\"presentation\" href=\"#\">First Item</a><a class=\"dropdown-item\" role=\"presentation\" href=\"#\">Second Item</a><a class=\"dropdown-item\" role=\"presentation\" href=\"#\">Third Item</a></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"shadow\" style=\"padding: 10px;text-align: right;margin-top: -10px;\">\r\n                <div><canvas data-bs-chart=\"{&quot;type&quot;:&quot;radar&quot;,&quot;data&quot;:{&quot;labels&quot;:[&quot;January&quot;,&quot;February&quot;,&quot;March&quot;,&quot;April&quot;,&quot;May&quot;,&quot;June&quot;],&quot;datasets&quot;:[{&quot;label&quot;:&quot;Revenue&quot;,&quot;backgroundColor&quot;:&quot;rgb(249,178,51)&quot;,&quot;borderColor&quot;:&quot;rgb(270,240,120)&quot;,&quot;data&quot;:[&quot;4500&quot;,&quot;5300&quot;,&quot;6250&quot;,&quot;7800&quot;,&quot;9800&quot;,&quot;15000&quot;],&quot;fill&quot;:true}]},&quot;options&quot;:{&quot;maintainAspectRatio&quot;:true,&quot;legend&quot;:{&quot;display&quot;:false},&quot;title&quot;:{}}}\"></canvas></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
