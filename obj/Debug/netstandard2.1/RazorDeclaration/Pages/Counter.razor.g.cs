#pragma checksum "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68b2a916ab4b7fb5e7ba4736ea1b5283ae69d0f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestProgressiveWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using TestProgressiveWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\_Imports.razor"
using TestProgressiveWebApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Art Unlimited User\source\repos\TestProgressiveWebApp\TestProgressiveWebApp\Pages\Counter.razor"
       
    public int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void DecramentCounter()
    {
        currentCount--;
    }

    private void SquareCounter()
    {
        currentCount = (int)Math.Pow(currentCount, 2);
    }

    private void SetButton()
    {
        //int number_from_input = change_number.text;
        //currentCount = number_from_input;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591