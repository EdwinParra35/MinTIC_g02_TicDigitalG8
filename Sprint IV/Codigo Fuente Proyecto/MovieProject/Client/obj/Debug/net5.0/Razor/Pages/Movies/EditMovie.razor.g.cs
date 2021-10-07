#pragma checksum "C:\ProysCicloIII\MovieProject\Client\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca4be7cfe4427c301a1a3f14831b79faff8bcd9"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using MovieProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MovieProject\Client\Pages\Movies\EditMovie.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{Id:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MovieProject.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MovieProject.Shared.Entity.Movie>(
#nullable restore
#line 4 "C:\ProysCicloIII\MovieProject\Client\Pages\Movies\EditMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\ProysCicloIII\MovieProject\Client\Pages\Movies\EditMovie.razor"
                                        Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\ProysCicloIII\MovieProject\Client\Pages\Movies\EditMovie.razor"
       
    [Parameter] public int Id { get; set; }
    private Movie Movie;
    protected override void OnInitialized()
    {
        Movie = new Movie()
        {
            Moviename = "El juego del calamar",
            EnCartelera = true,
            Sinopsis = "Sinopsis...",
            Trailer = "Trailer"
        };
    }
    void Edit()
    {
        Console.WriteLine($"Pelicula: {Movie.Moviename}");
        Console.WriteLine($"Premier: {Movie.Premier}");
        Console.WriteLine($"Esta en cartelera: {Movie.EnCartelera}");
        Console.WriteLine($"Poster: {Movie.MovieImage}");
        Console.WriteLine($"Sinopsis: {Movie.Sinopsis}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591