#pragma checksum "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37602287ac30cf33e083e0fa54fbd0541b806c0d"
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
#line 1 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
using MovieProject.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "jumbotron");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                      Movie.Moviename

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Moviename = __value, Movie.Moviename))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Moviename));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 13 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.Moviename

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col col-sm-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(27);
                __builder2.AddAttribute(28, "id", "en_cartelera");
                __builder2.AddAttribute(29, "class", "form-check-input");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                                                Movie.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.EnCartelera = __value, Movie.EnCartelera))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.AddMarkupContent(34, "<label class=\"form-check-label\" for=\"en_cartelera\">En cartelera</label>\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 20 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.EnCartelera

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                      Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_2(__builder2, 50, 51, 
#nullable restore
#line 29 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateInputDate_3(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 34 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                          Movie.Premier

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Premier = __value, Movie.Premier)), 61, () => Movie.Premier);
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_4(__builder2, 63, 64, 
#nullable restore
#line 35 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                      ()=>Movie.Premier

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(68);
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                  Movie.Sinopsis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Sinopsis = __value, Movie.Sinopsis))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Sinopsis));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_5(__builder2, 74, 75, 
#nullable restore
#line 43 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                          ()=>Movie.Sinopsis

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col");
                __builder2.AddMarkupContent(83, "<label>Selecciona las categorías</label>\r\n                        ");
                __builder2.OpenElement(84, "div");
                __builder2.OpenComponent<MovieProject.Client.Pages.Components.SelectorMultiple>(85);
                __builder2.AddAttribute(86, "Seleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 51 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                             Seleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "NoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 51 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                                             NoSeleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.OpenComponent<MovieProject.Client.Pages.Components.ImageComponent>(93);
                __builder2.AddAttribute(94, "Label", "");
                __builder2.AddAttribute(95, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 58 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                    ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(96, "ImageURL", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddMarkupContent(100, "<label>Actores:</label>\r\n                ");
                __builder2.OpenElement(101, "div");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateSelectorMultipleTypeaHead_6(__builder2, 102, 103, 
#nullable restore
#line 66 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                             BuscarActores

#line default
#line hidden
#nullable disable
                , 104, 
#nullable restore
#line 67 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                ActoresSeleccionados

#line default
#line hidden
#nullable disable
                , 105, (actor) => (__builder3) => {
                    __builder3.AddContent(106, 
#nullable restore
#line 69 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                             actor.ActorName

#line default
#line hidden
#nullable disable
                    );
                }
                , 107, (actor) => (__builder3) => {
                    __builder3.OpenElement(108, "img");
                    __builder3.AddAttribute(109, "src", 
#nullable restore
#line 72 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
                                       actor.Photo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(110, "alt");
                    __builder3.AddAttribute(111, "style", "width: 30px");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n            ");
                __builder2.AddMarkupContent(113, "<button type=\"submit\" class=\"btn btn-success\">Aceptar</button>\r\n            ");
                __builder2.AddMarkupContent(114, "<button type=\"submit\" class=\"btn btn-danger\">Cancelar</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\ProysCicloIII\MovieProject\Client\Pages\Components\FormMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Category> CategoriasSeleccionadas { get; set; } = new List<Category>();
    [Parameter] public List<Category> CategoriasNoSeleccionadas { get; set; } = new List<Category>();
    [Parameter] public List<Actor> ActoresSeleccionados { get; set; } = new List<Actor>();

    private string posterTemporal;
    private List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();

    private List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();

    private void ImageSelected(string imageB64)
    {
        Movie.MovieImage = imageB64;
    }

    protected override void OnInitialized()
    {
        Seleccionados = CategoriasSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        NoSeleccionados = CategoriasNoSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.MovieImage))
        {
            posterTemporal = Movie.MovieImage;
            Movie.MovieImage = null;
        }
    }

    private async Task<IEnumerable<Actor>> BuscarActores(string searchText)
    {
        return new List<Actor>(){
        new Actor(){Id=1, ActorName="Yaneth Mejía", Photo="https://pbs.twimg.com/profile_images/1079060744891785216/dAsFSbHH_400x400.jpg"},
        new Actor(){Id=2, ActorName="Carolina Marquez", Photo="https://archivo.autonoma.edu.co/sites/default/files/styles/medium/public/carolina-marquez-narvaez.jpg?itok=CcL43PAR"},
        new Actor(){Id=3, ActorName="Juan Esteban", Photo="https://cdn1.vectorstock.com/i/1000x1000/29/65/cinema-award-best-actor-flat-style-vector-13602965.jpg"}
        };
    }    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MovieProject.Client.Pages.Components.FormMovie
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSelectorMultipleTypeaHead_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::MovieProject.Client.Pages.Components.SelectorMultipleTypeaHead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ElementosSeleccionados", __arg1);
        __builder.AddAttribute(__seq2, "MyListTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
