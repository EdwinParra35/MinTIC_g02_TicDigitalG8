#pragma checksum "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d55000dcab07e6b3040af275dea1e30bece942"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Components
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
    public partial class ImageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.OpenElement(5, "label");
            __builder.AddAttribute(6, "class", "form-label");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
                                       Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(9);
            __builder.AddAttribute(10, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
                                 OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "accept", ".jpg,.png,.jpeg,.gif");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
#nullable restore
#line 11 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
         if (imageT !=  null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "margin:10px");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 15 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
                                                      imageT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "width", "300px");
            __builder.AddAttribute(20, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
         if (ImageURL !=  null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "margin:10px");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 24 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
                               ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "width", "300px");
            __builder.AddAttribute(27, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint IV\Codigo Fuente Proyecto\MovieProject\Client\Pages\Components\ImageComponent.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImageURL { get; set; }
    [Parameter] public EventCallback<string> ImageSelected { get; set; }


    private string imageT;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var images = e.GetMultipleFiles();
        foreach (var image in images)
        {
            var tamaño = new byte[image.Size];
            await image.OpenReadStream().ReadAsync(tamaño);
            imageT =Convert.ToBase64String(tamaño);
            ImageURL = null;
            await ImageSelected.InvokeAsync(imageT);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
