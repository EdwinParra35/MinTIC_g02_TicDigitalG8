#pragma checksum "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679f226f9c52a802094be3ae093c384e86e79213"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

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
            __builder.AddAttribute(2, "b-5tbrt1z0lx");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" rel=\"home\" href title=\"MinTIC\" b-5tbrt1z0lx><img style=\"max-width:80px; margin-top: -7px;\" src=\"/Images/logo.png\" b-5tbrt1z0lx></a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-5tbrt1z0lx");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-5tbrt1z0lx></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 11 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-5tbrt1z0lx");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-5tbrt1z0lx");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "/");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Peliculas\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "/");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                                         ()=>expandSubMenu = !expandSubMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-move\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Peliculas\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 22 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
             if(expandSubMenu){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "ul");
            __builder.AddAttribute(37, "class", "nav flex-column");
            __builder.AddAttribute(38, "b-5tbrt1z0lx");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddAttribute(41, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "/movies/create");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Crear Pelicula\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", "nav-item px-3");
            __builder.AddAttribute(50, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "nav-link");
            __builder.AddAttribute(53, "href", "/movies/edit/2");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Editar Peliculas\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "nav-item px-3");
            __builder.AddAttribute(59, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "nav-link");
            __builder.AddAttribute(62, "href", "/Actoresp");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                                                 ()=>expandSubMenuActor = !expandSubMenuActor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<span class=\"oi oi-move\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Actores\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
             if(expandSubMenuActor){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "ul");
            __builder.AddAttribute(67, "class", "nav flex-column");
            __builder.AddAttribute(68, "b-5tbrt1z0lx");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "nav-item px-3");
            __builder.AddAttribute(71, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
            __builder.AddAttribute(73, "class", "nav-link");
            __builder.AddAttribute(74, "href", "/actors/create");
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Crear Actor\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "class", "nav-item px-3");
            __builder.AddAttribute(80, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "class", "nav-link");
            __builder.AddAttribute(83, "href", "/actors/edit/3");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Editar Actor\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "nav-item px-3");
            __builder.AddAttribute(89, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(90);
            __builder.AddAttribute(91, "class", "nav-link");
            __builder.AddAttribute(92, "href", "/categories");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
                                                                   ()=>expandSubMenuCateg = !expandSubMenuCateg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(95, "<span class=\"oi oi-move\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Categorias\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 60 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
             if(expandSubMenuCateg){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(96, "ul");
            __builder.AddAttribute(97, "class", "nav flex-column");
            __builder.AddAttribute(98, "b-5tbrt1z0lx");
            __builder.OpenElement(99, "li");
            __builder.AddAttribute(100, "class", "nav-item px-3");
            __builder.AddAttribute(101, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(102);
            __builder.AddAttribute(103, "class", "nav-link");
            __builder.AddAttribute(104, "href", "categories");
            __builder.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(106, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Crear Categoria\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.OpenElement(108, "li");
            __builder.AddAttribute(109, "class", "nav-item px-3");
            __builder.AddAttribute(110, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(111);
            __builder.AddAttribute(112, "class", "nav-link");
            __builder.AddAttribute(113, "href", "/categories/edit/3");
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(115, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Editar Categoria\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.OpenElement(117, "li");
            __builder.AddAttribute(118, "class", "nav-item px-3");
            __builder.AddAttribute(119, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(120);
            __builder.AddAttribute(121, "class", "nav-link");
            __builder.AddAttribute(122, "href", "/actors");
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(124, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Vista de Actores\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.OpenElement(126, "li");
            __builder.AddAttribute(127, "class", "nav-item px-3");
            __builder.AddAttribute(128, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(129);
            __builder.AddAttribute(130, "class", "nav-link");
            __builder.AddAttribute(131, "href", "/movies/search");
            __builder.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(133, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Buscar Peliculas\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.OpenElement(135, "li");
            __builder.AddAttribute(136, "class", "nav-item px-3");
            __builder.AddAttribute(137, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(138);
            __builder.AddAttribute(139, "class", "nav-link");
            __builder.AddAttribute(140, "href", "/Actors/search");
            __builder.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(142, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Buscar Actores\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n        ");
            __builder.OpenElement(144, "li");
            __builder.AddAttribute(145, "class", "nav-item px-3");
            __builder.AddAttribute(146, "b-5tbrt1z0lx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(147);
            __builder.AddAttribute(148, "class", "nav-link");
            __builder.AddAttribute(149, "href", "/moviesre");
            __builder.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(151, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-5tbrt1z0lx></span> Pagina no encontrada\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubMenu;
    private bool expandSubMenuActor;
    private bool expandSubMenuCateg;

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
