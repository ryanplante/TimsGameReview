#pragma checksum "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a5d53c614d779514aa8534e3a5b74e3de23246"
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
#line 1 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 11 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\_Imports.razor"
using BlazorReview.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Game Admin</h3>");
#nullable restore
#line 7 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
 if (games == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Title</th>\r\n                <th>Description</th>\r\n                <th>Price</th>\r\n                <th>Genre</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 24 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
             foreach (var game in games)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 27 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                         game.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                         game.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                         game.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                         game.genre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                                                                  () => EditGame(game.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
                                                                 () => DeleteGame(game.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Admin.razor"
       
    private List<GameModel> games;

    protected override async Task OnInitializedAsync()
    {
        games = await HttpClient.GetFromJsonAsync<List<GameModel>>("/api/VideoRating/GetGames");
    }

    private void EditGame(int gameId)
    {
        Navigation.NavigateTo($"/edit-game/{gameId}");
    }

    private async Task DeleteGame(int gameId)
    {
        // Call API to delete the game
        var response = await HttpClient.DeleteAsync($"/api/VideoRating/DeleteGame/{gameId}");

        if (response.IsSuccessStatusCode)
        {
            // Reload the game list or remove the game from the list locally
            games = games.Where(game => game.id != gameId).ToList();
        }
        else
        {
            // Handle error
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591