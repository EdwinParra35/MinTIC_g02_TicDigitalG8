#pragma checksum "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a2f27dffbc53bd8d35368fe7bca8a0a5479152"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class ShowCategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"form-group mb-3\"><a class=\"btn btn-info\" href=\"/categories/create\">Agregar Categoria</a></div>\r\n");
            __builder.AddMarkupContent(1, "<h6>Listado de Categorias</h6>\r\n\r\n");
            __Blazor.MovieProject.Client.Pages.Categories.ShowCategories.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 12 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                          Categories

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-striped table-hover");
                __builder2.AddMarkupContent(7, "<thead><tr><th scope=\"col\">Nombre</th>\r\n                    <th scope=\"col\">Opciones</th></tr></thead>\r\n            ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 22 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                 foreach (var item in Categories)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.AddContent(11, 
#nullable restore
#line 25 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                             item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n                        ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "a");
                __builder2.AddAttribute(15, "href", "/categories/edit/" + (
#nullable restore
#line 27 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                                                       item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "class", "btn btn-info btn-sm");
                __builder2.AddContent(17, "Editar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                                                ()=>DeleteCategory(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "class", "btn btn-danger btn-sm");
                __builder2.AddContent(22, "Eliminar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\ShowCategories.razor"
       
    public List<Category> Categories { get; set; }
    protected async override Task OnInitializedAsync()
    {

        await Load();
    }
    private async Task Load()
    {
        var responseHttp = await movie.Get<List<Category>>("api/categories");
        Categories = responseHttp.Response;
    }

    private async Task DeleteCategory(Category category){
        var responseHttp = await movie.Delete($"api/categories/{category.Id}");
        if (responseHttp.Error)
        {
            await showMessage.ShowErrorMessage(await responseHttp.GetBody());
        }else{
            await Load();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
namespace __Blazor.MovieProject.Client.Pages.Categories.ShowCategories
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MovieProject.Client.Pages.Components.GenericList<Titem>>(seq);
        __builder.AddAttribute(__seq0, "ListResults", __arg0);
        __builder.AddAttribute(__seq1, "ItemsComplete", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
