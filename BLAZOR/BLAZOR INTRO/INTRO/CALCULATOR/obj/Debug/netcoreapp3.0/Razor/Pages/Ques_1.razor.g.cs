#pragma checksum "D:\BLAZOR INTRO\INTRO\CALCULATOR\Pages\Ques_1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4496bb72e7e4f7cf3f9a0e6bed5bc87cf2d2a6d4"
// <auto-generated/>
#pragma warning disable 1591
namespace CALCULATOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using CALCULATOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BLAZOR INTRO\INTRO\CALCULATOR\_Imports.razor"
using CALCULATOR.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ques1")]
    public partial class Ques_1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ques 1: Difference between the Blazor client-side and server-side and also explain web assembly and Signal R connection?</h3>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, @"<div>
    <h4>Blazor client side</h4>
    <p>
        Blazor is a framework designed to run the client side in the browser on a web assembly based model that .net runtime provides.
    All the dependencies and the runtime is downloaded in the browser.The app is directly executed on the browser without using server communication.
    </p>

    <h4>Blazor server side</h4>
    <p>
        In blazor servide side blazor app is executed on the server. Event handling and all the task are handled by the signal r connection. 
        It creates the signal R endpoint where the client can connect.
    </p>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
