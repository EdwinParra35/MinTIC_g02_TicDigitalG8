// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\ShowwActors.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actor")]
    public partial class ShowwActors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Actors\ShowwActors.razor"
       
    private List<Actor> Actors;
    protected override void OnInitialized()
    {
        Actors = actor.GetActors();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceActor actor { get; set; }
    }
}
#pragma warning restore 1591
