#pragma checksum "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502d9db035e49adef1c697d79e68e2dbc7553267"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pc")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<EmployeeManagement.Web.Pages.ChildComponent>(0);
            __builder.AddAttribute(1, "InputAttributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 4 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                 attributesFromParent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
       
    public Dictionary<string, object> attributesFromParent { get; set; } =
        new Dictionary<string, object>()
        {
            { "required", "required" },
            { "placeholder", "Parent Component Placeholder" },
            { "size", "50" },
            { "maxlength", "5" }
            };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
