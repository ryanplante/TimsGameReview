#pragma checksum "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373ae0fcb85c36d8c5588596a7de61bf9747c0e0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorReview.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
                  loginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
                                             Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"username\">Username:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "username");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
                                              loginModel.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Username = __value, loginModel.Username))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"password\">Password:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "password");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
                                              loginModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.AddMarkupContent(30, "<button type=\"submit\" class=\"btn btn-primary\">Login</button>");
#nullable restore
#line 26 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
     if (!string.IsNullOrEmpty(errorMessage))
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "alert alert-danger mt-3");
                __builder2.AddContent(33, 
#nullable restore
#line 29 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
             errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Login.razor"
       
    private LoginModel loginModel = new LoginModel();
    private string errorMessage;

    private async Task Submit()
    {
        var response = await HttpClient.PostAsJsonAsync("api/User/VerifyPassword", loginModel);

        if (response.IsSuccessStatusCode)
        {
            var user = await response.Content.ReadFromJsonAsync<UserModel>();
            await SessionStorage.SetItemAsStringAsync("UserId", user.Id.ToString());
            await SessionStorage.SetItemAsStringAsync("UserName", user.UName.ToString());
            await SessionStorage.SetItemAsStringAsync("PermissionLevel", user.PermissionLevel.ToString());

            // Redirect to home or another page
            Navigation.NavigateTo("/");
        }
        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
        {
            // Invalid username or password
            errorMessage = "Invalid username or password.";
        }
        else
        {
            // Handle other errors
            errorMessage = "An error occurred while processing your request.";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
