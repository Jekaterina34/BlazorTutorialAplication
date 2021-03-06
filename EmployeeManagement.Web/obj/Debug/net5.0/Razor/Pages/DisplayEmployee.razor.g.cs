#pragma checksum "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f24217a88a91a3bd61bb07e3c51bbb060565c03a"
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
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "checked", 
#nullable restore
#line 6 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                         IsSelected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                                CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n        ");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, 
#nullable restore
#line 8 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
             Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 8 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                 Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 10 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-footer text-center");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 14 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn btn-primary m-1");
            __builder.AddContent(23, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n            ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 17 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-primary m-1");
            __builder.AddContent(28, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-danger m-1");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                              Delete_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n                Delete\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenComponent<PragimTech.Components.Confirm>(36);
            __builder.AddAttribute(37, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 27 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                        ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                               $"Are you sure you want to delete \"{Employee.FirstName}\""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 27 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
               DeleteConfirmation = (PragimTech.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
