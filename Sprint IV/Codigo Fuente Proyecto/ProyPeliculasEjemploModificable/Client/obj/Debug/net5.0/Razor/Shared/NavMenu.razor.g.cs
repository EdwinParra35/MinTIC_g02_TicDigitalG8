#pragma checksum "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc46e2352e2c18c398259561f2d9b9b73d5c4cbe"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestra.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using ProyBaseMuestra.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using ProyBaseMuestra.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using ProyBaseMuestra.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\_Imports.razor"
using ProyBaseMuestra.Client.Services;

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
            __builder.AddAttribute(2, "b-q8ynpcqgmi");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-q8ynpcqgmi>SEM IV</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-q8ynpcqgmi");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-q8ynpcqgmi></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-q8ynpcqgmi");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-q8ynpcqgmi");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-q8ynpcqgmi");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "categories");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-q8ynpcqgmi></span> Categorías\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-q8ynpcqgmi");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "movies/create");
            __builder.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-dashboard\" aria-hidden=\"true\" b-q8ynpcqgmi></span> Crear peliculas\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-q8ynpcqgmi");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "/movies/search");
            __builder.AddAttribute(42, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-dashboard\" aria-hidden=\"true\" b-q8ynpcqgmi></span> Buscar pelicula\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.AddAttribute(48, "b-q8ynpcqgmi");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "actors");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-q8ynpcqgmi></span> Actores\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\osqui\Documents\GitHub\MinTIC_g02_TicDigitalG8\Sprint IV\ProyPeliculasBlade-master\Client\Shared\NavMenu.razor"
       
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
