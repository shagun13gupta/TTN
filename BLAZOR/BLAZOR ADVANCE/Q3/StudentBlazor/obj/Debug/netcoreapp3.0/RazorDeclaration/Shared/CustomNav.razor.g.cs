#pragma checksum "D:\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\CustomNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033b2685c80ef4d4483864e2a01f7325be9442b3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentApi.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\_Imports.razor"
using StudentApi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\CustomNav.razor"
using StudentApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\CustomNav.razor"
using StudentBlazor.Services;

#line default
#line hidden
#nullable disable
    public partial class CustomNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\BLAZOR ADVANCE\Q3\StudentBlazor\Shared\CustomNav.razor"
 
    List<NavBarInfo> objnavBarInfo;
    protected override async Task OnInitializedAsync()
    {

        objnavBarInfo = await Task.Run(() => _navbar.GetNav());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavBarService _navbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigate { get; set; }
    }
}
#pragma warning restore 1591
