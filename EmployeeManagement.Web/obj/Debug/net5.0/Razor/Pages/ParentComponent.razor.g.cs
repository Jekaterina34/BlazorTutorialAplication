#pragma checksum "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b056111f708dddd6fb61b09a24251d14f75af949"
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
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                          IncrementCounter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    Increment Counter\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "h1");
            __builder.AddAttribute(6, "style", 
#nullable restore
#line 7 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
            Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, "Parent Component Text - ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                            Counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __Blazor.EmployeeManagement.Web.Pages.ParentComponent.TypeInference.CreateCascadingValue_0(__builder, 10, 11, 
#nullable restore
#line 9 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                        Counter

#line default
#line hidden
#nullable disable
            , 12, "Counter", 13, 
#nullable restore
#line 9 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                                         false

#line default
#line hidden
#nullable disable
            , 14, (__builder2) => {
                __Blazor.EmployeeManagement.Web.Pages.ParentComponent.TypeInference.CreateCascadingValue_1(__builder2, 15, 16, 
#nullable restore
#line 10 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                            Style

#line default
#line hidden
#nullable disable
                , 17, "ColorStyle", 18, 
#nullable restore
#line 10 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                                              true

#line default
#line hidden
#nullable disable
                , 19, (__builder3) => {
                    __Blazor.EmployeeManagement.Web.Pages.ParentComponent.TypeInference.CreateCascadingValue_2(__builder3, 20, 21, 
#nullable restore
#line 11 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                BorderStyle

#line default
#line hidden
#nullable disable
                    , 22, "BorderStyle", 23, 
#nullable restore
#line 11 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                    , 24, (__builder4) => {
                        __builder4.OpenComponent<EmployeeManagement.Web.Pages.ChildComponent>(25);
                        __builder4.CloseComponent();
                    }
                    );
                }
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\ParentComponent.razor"
       
    public string Style { get; set; } = "color:red";
    public string BorderStyle { get; set; } = "border:1px solid red";
    public int Counter { get; set; } = 0;

    private void IncrementCounter()
    {
        Counter = Counter + 1;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.EmployeeManagement.Web.Pages.ParentComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
