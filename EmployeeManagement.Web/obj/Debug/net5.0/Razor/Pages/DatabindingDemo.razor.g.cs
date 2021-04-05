#pragma checksum "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25092f0bc8f15df73c8ff4a5f26f894a74b72d74"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/databindingdemo")]
    public partial class DatabindingDemo : DatabindingDemoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Data Binding Demo</h1>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>One Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<b>Name :</b> ");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                   Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "<b>Name with salutation:</b> ");
            __builder.AddContent(8, 
#nullable restore
#line 12 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                   Gender == "Male" ? $"Mr. {Name}" : $"Miss. {Name}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddMarkupContent(11, "<b>Name :</b> ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 15 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n<hr>\r\n");
            __builder.AddMarkupContent(15, "<h3> Two Way Data Binding</h3>\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "<b>Name :</b> ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 22 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                 Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                                    e => { Name = e.Value.ToString(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "<b>Name :</b> ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddMarkupContent(29, "<b>Name :</b> ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "<b>Colour :</b> ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "style", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DatabindingDemo.razor"
                  Colour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Colour = __value, Colour));
            __builder.SetUpdatesAttributeName("style");
            __builder.AddMarkupContent(43, "<h3>The background colour of this text changes</h3>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
