#pragma checksum "E:\Diplomka\DPClientVS\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a479d44fdb31a5e16c0f72bbadfbb1985784ad27"
// <auto-generated/>
#pragma warning disable 1591
namespace DPClientVS.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using DPClientVS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using DPClientVS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Diplomka\DPClientVS\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-15ph1cr6d6");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-15ph1cr6d6>DPClientVS</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "E:\Diplomka\DPClientVS\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-15ph1cr6d6");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-15ph1cr6d6></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "E:\Diplomka\DPClientVS\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "E:\Diplomka\DPClientVS\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-15ph1cr6d6");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-15ph1cr6d6");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-15ph1cr6d6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "races");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-british-pound\" aria-hidden=\"true\" b-15ph1cr6d6></span> Races\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n <div class=\"separator\" b-15ph1cr6d6></div>\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "scroller");
            __builder.AddAttribute(28, "b-15ph1cr6d6");
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "nav flex-column");
            __builder.AddAttribute(31, "b-15ph1cr6d6");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item px-3");
            __builder.AddAttribute(34, "b-15ph1cr6d6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "results");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<span class=\"syncfusion-blazor-icons syncfusion-blazor-icon-datagrid\" aria-hidden=\"true\" b-15ph1cr6d6></span>Results\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n ");
            __builder.AddMarkupContent(41, @"<style b-15ph1cr6d6>
        .scroller {
            height: calc(100vh - 160px) !important;
            overflow-y: auto;
            width:287px;
        }

            .scroller::-webkit-scrollbar, scrollbar-thumb
            .scroller::-webkit-scrollbar-thumb {
                width: 8px;
                height: 110px;
                border-radius: 4px;
                position: center;
            }

            .scroller::-webkit-scrollbar-thumb {
                box-shadow: inset 0 0 0 10px #313C75;
                border-radius: 4px;
            }

            .scroller::-webkit-scrollbar-track {
                width: 28px;
            }
	    .separator{
           border:1px solid #FFFFFF;
           opacity:0.14;
           width:247px;
           margin:1rem;
           margin-top:0px;
        }
    </style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "E:\Diplomka\DPClientVS\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591