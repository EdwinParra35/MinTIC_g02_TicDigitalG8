#pragma checksum "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\EditActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c8b79824e8579d93a5cde12291b08599ad0b40"
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
#nullable restore
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\EditActor.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/edit/{ActorId:int}")]
    public partial class EditActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MovieProject.Client.Pages.Components.FormActor>(0);
            __builder.AddAttribute(1, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\EditActor.razor"
                          Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MovieProject.Shared.Entity.Actor>(
#nullable restore
#line 4 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\EditActor.razor"
                                       Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\EditActor.razor"
       
    [Parameter] public int ActorId { get; set; }
    Actor Actor = new Actor();
    protected override void OnInitialized()
    {
        Actor = new Actor()
        {
            Id = ActorId,
            ActorName = "Will Smith",
            BirthDate = DateTime.Today
        };
    }
    private void Edit(){
        Console.WriteLine("Editando actor");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
