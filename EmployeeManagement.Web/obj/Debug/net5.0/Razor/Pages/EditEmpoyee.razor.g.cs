#pragma checksum "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73842ae8ecc73459b7157754cb026701cbfe5faf"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmpoyee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                  EditEmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<h3>Edit Employee</h3>\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            First Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "firstName");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "First Name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.FirstName = __value, EditEmployeeModel.FirstName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 17 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                      () => EditEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.AddMarkupContent(27, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Last Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "lastName");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "placeholder", "Last Name");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.LastName = __value, EditEmployeeModel.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 27 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                      () => EditEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group row");
                __builder2.AddMarkupContent(43, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n            Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "email");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "placeholder", "Email");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Email = __value, EditEmployeeModel.Email))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#nullable restore
#line 37 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                      () => EditEmployeeModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.AddMarkupContent(59, "<label for=\"confirmEmail\" class=\"col-sm-2 col-form-label\">\r\n            Confirm Email\r\n        </label>\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "id", "confirmEmail");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.ConfirmEmail = __value, EditEmployeeModel.ConfirmEmail))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditEmployeeModel.ConfirmEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 47 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                      () => EditEmployeeModel.ConfirmEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row");
                __builder2.AddMarkupContent(74, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n            Department\r\n        </label>\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateCustomInputSelect_4(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 55 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                            EditEmployeeModel.DepartmentId

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DepartmentId = __value, EditEmployeeModel.DepartmentId)), 81, () => EditEmployeeModel.DepartmentId, 82, (__builder3) => {
#nullable restore
#line 56 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                 foreach (var dept in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(83, "option");
                    __builder3.AddAttribute(84, "value", 
#nullable restore
#line 58 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(85, 
#nullable restore
#line 58 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                                        dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 59 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row");
                __builder2.AddMarkupContent(89, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\r\n            Gender\r\n        </label>\r\n        ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateInputSelect_5(__builder2, 92, 93, "form-control", 94, 
#nullable restore
#line 68 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                      EditEmployeeModel.Gender

#line default
#line hidden
#nullable disable
                , 95, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.Gender = __value, EditEmployeeModel.Gender)), 96, () => EditEmployeeModel.Gender, 97, (__builder3) => {
#nullable restore
#line 69 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                 foreach (var gender in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(98, "option");
                    __builder3.AddAttribute(99, "value", 
#nullable restore
#line 71 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(100, 
#nullable restore
#line 71 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                             gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 72 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group row");
                __builder2.AddMarkupContent(104, "<label for=\"dateOfBirth\" class=\"col-sm-2 col-form-label\">\r\n            Date Of Birth\r\n        </label>\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee.TypeInference.CreateInputDate_6(__builder2, 107, 108, "form-control", 109, 
#nullable restore
#line 81 "C:\DEV\Blazor Tutorial\EmployeeManagement.Web\Pages\EditEmpoyee.razor"
                                    EditEmployeeModel.DateOfBrith

#line default
#line hidden
#nullable disable
                , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditEmployeeModel.DateOfBrith = __value, EditEmployeeModel.DateOfBrith)), 111, () => EditEmployeeModel.DateOfBrith);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n    ");
                __builder2.AddMarkupContent(113, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManagement.Web.Pages.EditEmpoyee
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
        public static void CreateCustomInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::PragimTech.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
