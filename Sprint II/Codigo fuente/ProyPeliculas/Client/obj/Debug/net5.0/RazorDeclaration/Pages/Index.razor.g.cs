// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyPeliculas.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\_Imports.razor"
using ProyPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\Pages\Index.razor"
       
    public string movie1 = "Star wars";
    public string movie2 = "Avengers";
    public string movie3 = "Spiderman";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\Pages\Index.razor"
                                                                             
    public string function_convert_mayusc(string value) => value.ToUpper();
    public string function_convert_minusc(string value) => value.ToLower();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\Pages\Index.razor"
                       
    public void click_event_button()
    {
        Console.WriteLine("Has dado click en el bot??n");
    }
    public void click_event_cancel()
    {
        Console.WriteLine("Cancelaste el proceso");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "c:\ProysCicloIII\MinTIC_g02_TicDigitalG8\Sprint II\Codigo fuente\ProyPeliculas\Client\Pages\Index.razor"
               
            string ciclo = "Desarrollo de software";
            private void Confirmar(){
                Console.WriteLine("Acabas de dar click en el bot??n, evento capturado");
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
