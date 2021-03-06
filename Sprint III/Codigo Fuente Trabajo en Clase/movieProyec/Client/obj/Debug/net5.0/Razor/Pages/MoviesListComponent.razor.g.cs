#pragma checksum "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acab15de9603b2c776ae6562bed0a0e970feb6a1"
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
    public partial class MoviesListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
#nullable restore
#line 3 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
 if (Movies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<img src=\"/Images/loading.gif\" width=\"200px\" height=\"200px\">");
#nullable restore
#line 6 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
}else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
     foreach (var movie in GetMovie())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group mb-3");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href");
            __builder.AddAttribute(7, "class", "list-group-item list-group-item-action flex-column ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col md-3");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 14 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                   movie.MovieImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt");
            __builder.AddAttribute(15, "class", "img-thumbnail");
            __builder.AddAttribute(16, "height", "200px");
            __builder.AddAttribute(17, "width", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col md 9 ");
            __builder.OpenElement(21, "h5");
            __builder.AddAttribute(22, "class", "card-title text-left");
            __builder.OpenElement(23, "em");
            __builder.AddContent(24, 
#nullable restore
#line 17 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                                              movie.NameMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "class", "card-title text-left");
            __builder.OpenElement(28, "em");
            __builder.OpenElement(29, "small");
            __builder.AddContent(30, 
#nullable restore
#line 18 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                                                      movie.descriptionMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "small");
            __builder.AddAttribute(33, "class", "text-muted");
            __builder.AddContent(34, 
#nullable restore
#line 19 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
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
#line 25 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                                   
    public List<Movie> Movies;
    private List<Movie>GetMovie(){
        return new List<Movie>(){
            new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/movie_1.jpg",CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/movie_2.jpg",CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/movie_3.jpg",CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/movie_4.jpg",CurrentMovie= new DateTime(2021,09,18)},
            new Movie(){NameMovie="Luca",descriptionMovie="Ambientada en un precioso pueblo costero de la Riviera italiana, narra la historia sobre el paso a la edad adulta de un chico que vive un verano inolvidable lleno de helados, pasta e infinitos paseos en scooter",MovieImage="/Images/movie_5.jpg",CurrentMovie= new DateTime(2021,09,18)}

        };
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                                   
    protected override async Task OnInitializedAsync(){
        await Task.Delay(1000);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\ProysCicloIII\movieProyec\Client\Pages\MoviesListComponent.razor"
                                                                  
        Movies = GetMovie();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
