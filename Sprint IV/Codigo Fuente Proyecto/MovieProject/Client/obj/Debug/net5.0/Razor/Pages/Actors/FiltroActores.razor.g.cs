#pragma checksum "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca05e58ce1eb32ba91fe30052bb92947d4decaf2"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Actors
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
#line 2 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Actors/search")]
    public partial class FiltroActores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mb-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group mb-2");
            __builder.AddMarkupContent(8, "<label for=\"actor_name\" class=\"sr-only\">Nombre del Actor</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
                                   (KeyboardEventArgs e)=>ActorNameKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "id", "actor_name");
            __builder.AddAttribute(14, "placeholder", "Buscar Actor");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
                                                actor_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => actor_name = __value, actor_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-primary mb-2 btn-sm");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
                                                                        CargarNuevosActors

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n        Buscar\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-secondary mb-2 btn-sm");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
                                                                          LimpiarCampos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n        Limpiar campos\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenComponent<MovieProject.Client.Pages.Components.CardActorsComponent>(30);
            __builder.AddAttribute(31, "Actors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Shared.Entity.Actor>>(
#nullable restore
#line 24 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
                             Actors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\ProysCicloIII\MovieProject\Client\Pages\Actors\FiltroActores.razor"
      
    private List<Actor> Actors;
    string actor_name = "";

    protected override void OnInitialized()
    {
        Actors = actor.GetActors();
    }
    private void ActorNameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNuevosActors();
        }
    }
    private void CargarNuevosActors()
    {
        Actors = actor.GetActors().Where(x => x.ActorName.ToLower().Contains(actor_name.ToLower())).ToList();
        Console.WriteLine($"Nombre Actor: {actor_name}");
        
    }

    private void LimpiarCampos()
    {
        Actors = actor.GetActors();
        actor_name = "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceActor actor { get; set; }
    }
}
#pragma warning restore 1591
