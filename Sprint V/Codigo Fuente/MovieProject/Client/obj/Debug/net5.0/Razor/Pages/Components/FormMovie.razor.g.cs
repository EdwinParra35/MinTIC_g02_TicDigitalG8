#pragma checksum "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812afa8befa80e9054c23b2a8ed2c231cc60dc98"
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
#line 12 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
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
#line 3 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                 Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                       OnDataAnnotationsValidated

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
                __builder2.AddAttribute(15, "class", "col col-sm-7");
                __builder2.AddMarkupContent(16, "<label>Nombre de la Pelicula</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                      Movie.Moviename

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Moviename = __value, Movie.Moviename))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Moviename));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 14 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.Moviename

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col col-sm-5");
                __builder2.AddMarkupContent(28, "<label>Calificacion:</label>\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateInputNumber_1(__builder2, 29, 30, "form-control", 31, 
#nullable restore
#line 18 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                        Movie.Score

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Score = __value, Movie.Score)), 33, () => Movie.Score);
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_2(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.Score

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
                __builder2.AddAttribute(43, "class", "col col-sm-12 col-lg-7");
                __builder2.AddMarkupContent(44, "<label>Trailer de la pelicula:</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                      Movie.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Trailer = __value, Movie.Trailer))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_3(__builder2, 51, 52, 
#nullable restore
#line 29 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col col-sm-12 col-lg-5");
                __builder2.AddMarkupContent(56, "<label>Fecha de Lansamiento:</label>\r\n                        ");
                __builder2.OpenElement(57, "div");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateInputDate_4(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 35 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                          Movie.Premier

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Premier = __value, Movie.Premier)), 62, () => Movie.Premier);
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_5(__builder2, 64, 65, 
#nullable restore
#line 36 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                      ()=>Movie.Premier

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col col-sm-8");
                __builder2.AddMarkupContent(73, "<label>Duracion de la Pelicula:</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                      Movie.MovieTime

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.MovieTime = __value, Movie.MovieTime))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.MovieTime));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_6(__builder2, 80, 81, 
#nullable restore
#line 46 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.MovieTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "col col-sm-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(85);
                __builder2.AddAttribute(86, "id", "en_cartelera");
                __builder2.AddAttribute(87, "class", "form-check-input");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                                                Movie.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.EnCartelera = __value, Movie.EnCartelera))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Movie.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.AddMarkupContent(92, "<label class=\"form-check-label\" for=\"en_cartelera\">En cartelera</label>\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_7(__builder2, 93, 94, 
#nullable restore
#line 53 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                  ()=>Movie.EnCartelera

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.AddMarkupContent(98, "<label>Sipnosis:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(99);
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                  Movie.Sinopsis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Movie.Sinopsis = __value, Movie.Sinopsis))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Movie.Sinopsis));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateValidationMessage_8(__builder2, 105, 106, 
#nullable restore
#line 61 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                          ()=>Movie.Sinopsis

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "row");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col");
                __builder2.AddMarkupContent(114, "<label>Selecciona las categorías</label>\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.OpenComponent<MovieProject.Client.Pages.Components.SelectorMultiple>(116);
                __builder2.AddAttribute(117, "Seleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 69 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                             Seleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "NoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 69 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                                             NoSeleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                    ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.OpenComponent<MovieProject.Client.Pages.Components.ImageComponent>(124);
                __builder2.AddAttribute(125, "Label", "");
                __builder2.AddAttribute(126, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 76 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                    ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(127, "ImageURL", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group");
                __builder2.AddMarkupContent(131, "<label>Reparto:</label>\r\n                ");
                __builder2.OpenElement(132, "div");
                __Blazor.MovieProject.Client.Pages.Components.FormMovie.TypeInference.CreateSelectorMultipleTypeaHead_9(__builder2, 133, 134, 
#nullable restore
#line 84 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                             BuscarActores

#line default
#line hidden
#nullable disable
                , 135, 
#nullable restore
#line 85 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                ActoresSeleccionados

#line default
#line hidden
#nullable disable
                , 136, (actor) => (__builder3) => {
                    __builder3.OpenElement(137, "img");
                    __builder3.AddAttribute(138, "style", "width: 30px");
                    __builder3.AddAttribute(139, "src", 
#nullable restore
#line 87 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                           actor.Photo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(140, "\r\n                                    ");
                    __builder3.AddContent(141, 
#nullable restore
#line 88 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                     actor.ActorName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(142, "/");
                    __builder3.OpenElement(143, "input");
                    __builder3.AddAttribute(144, "type", "text");
                    __builder3.AddAttribute(145, "placeholder", "Personaje");
                    __builder3.AddAttribute(146, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                                                                       actor.Character

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => actor.Character = __value, actor.Character));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\r\n                            ");
                    __builder3.AddContent(149, 
#nullable restore
#line 89 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                             actor.ActorName

#line default
#line hidden
#nullable disable
                    );
                }
                , 150, (actor) => (__builder3) => {
                    __builder3.OpenElement(151, "img");
                    __builder3.AddAttribute(152, "style", "width: 30px");
                    __builder3.AddAttribute(153, "src", 
#nullable restore
#line 92 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                                                           actor.Photo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\r\n                            ");
                    __builder3.AddContent(155, 
#nullable restore
#line 93 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
                             actor.ActorName

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n\r\n            ");
                __builder2.AddMarkupContent(157, "<button type=\"submit\" class=\"btn btn-success\">Aceptar</button>\r\n            ");
                __builder2.AddMarkupContent(158, "<button type=\"submit\" class=\"btn btn-danger\">Cancelar</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormMovie.razor"
       
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

    private async Task OnDataAnnotationsValidated(){
    Movie.CategoriesMovie = Seleccionados.Select(x => new CategoryMovie{CategoryId= int.Parse(x.Key)}).ToList();
    Movie.MoviesActor = ActoresSeleccionados.Select(x =>new MovieActor{ActorId = x.Id, Character = x.Character}).ToList();
    if(!string.IsNullOrWhiteSpace(Movie.MovieImage)){
        posterTemporal = null;
    }
    await OnValidSubmit.InvokeAsync(null);
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSelectorMultipleTypeaHead_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
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
