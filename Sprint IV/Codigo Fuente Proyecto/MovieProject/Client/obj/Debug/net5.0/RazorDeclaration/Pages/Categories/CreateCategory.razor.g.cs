// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MovieProject.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Categories\CreateCategory.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/create")]
    public partial class CreateCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Categories\CreateCategory.razor"
      
    private Category Category = new Category();

    private async Task Create(){
        var httpResponse = await movie.Post("api/categories", Category);
        if(httpResponse.Error){
            var body = await httpResponse.GetBody();
            await showMessage.ShowErrorMessage(body);
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Categories\CreateCategory.razor"
                                      
        }else{
            navigationManager.NavigateTo("/categories");
        }
        Console.WriteLine($"Creando la categoria {Category.Name}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
