#pragma checksum "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717de28ffcbf3764338ce2bc14609901eaf80029"
// <auto-generated/>
#pragma warning disable 1591
namespace APBDProject.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Shared.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\Shared\RedirectToLogin.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\mateu\Desktop\new approach\APBDProject\APBDProject\Client\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
