#pragma checksum "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5523f6bc250c1bc9f8481760216e13efae5f27c8"
// <auto-generated/>
#pragma warning disable 1591
namespace movieProyec.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using movieProyec.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using movieProyec.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\movieProyec\Client\_Imports.razor"
using movieProyec.Shared.Entity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddAttribute(2, "style", "background-image: url(\'/Images/lucas_2.jpg\'); width: 100%; min-height: 75%; filter:alpha(opacity=50); ");
            __builder.AddMarkupContent(3, "<h6><small>Ciclo foreach</small></h6>");
#nullable restore
#line 4 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
     foreach (var movie in GetMovie())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "list-group mb-3");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href");
            __builder.AddAttribute(8, "class", "list-group-item list-group-item-action flex-column ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col md-3");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 10 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
                                   movie.MovieImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt");
            __builder.AddAttribute(16, "class", "img-thumbnail");
            __builder.AddAttribute(17, "height", "200px");
            __builder.AddAttribute(18, "width", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col md 9 ");
            __builder.OpenElement(22, "h5");
            __builder.AddAttribute(23, "class", "card-title text-left");
            __builder.OpenElement(24, "em");
            __builder.AddContent(25, 
#nullable restore
#line 13 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
                                                              movie.NameMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "h5");
            __builder.AddAttribute(28, "class", "card-title text-left");
            __builder.OpenElement(29, "em");
            __builder.OpenElement(30, "small");
            __builder.AddContent(31, 
#nullable restore
#line 14 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
                                                                      movie.descriptionMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "class", "text-muted");
            __builder.AddContent(35, 
#nullable restore
#line 15 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
                                                   movie.CurrentMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\ProysCicloIII\movieProyec\Client\Pages\FetchData.razor"
                                                   
    private List<Movie>GetMovie(){
        return new List<Movie>(){
            new Movie(){NameMovie="Luca",
            descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",
            MovieImage="/Images/movie_1.jpg",
            CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",
            descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",
            MovieImage="/Images/movie_2.jpg",
            CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",
            descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",
            MovieImage="/Images/movie_3.jpg",
            CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",
            descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",
            MovieImage="/Images/movie_4.jpg",
            CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",
            descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",
            MovieImage="/Images/movie_5.jpg",
            CurrentMovie= new DateTime(2021,09,18)}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
