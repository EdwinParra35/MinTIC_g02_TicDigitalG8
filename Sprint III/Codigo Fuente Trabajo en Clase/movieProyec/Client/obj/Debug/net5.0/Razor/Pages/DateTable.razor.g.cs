#pragma checksum "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b9810c793522f31f0e70ba031d58343faaf94a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DateTable")]
    public partial class DateTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">Imagen </th>\r\n      <th scope=\"col\">Nombre</th>\r\n      <th scope=\"col\">Descripcion</th>\r\n      <th scope=\"col\">Fecha de estreno</th></tr></thead>\r\n  ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 14 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
       foreach (var movie in GetMovie())
      {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "scope", "row");
            __builder.AddContent(9, 
#nullable restore
#line 17 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
                              movie.MovieImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 18 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
                 movie.NameMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 19 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
                 movie.descriptionMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
                 movie.CurrentMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
      }  

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\ProysCicloIII\movieProyec\Client\Pages\DateTable.razor"
                                                   
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
    }
}
#pragma warning restore 1591
