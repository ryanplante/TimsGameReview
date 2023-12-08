#pragma checksum "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d8a87489ab75d45210dd462c24ea51c96dcf6f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/reviews")]
    public partial class Reviews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Game Reviews</h3>");
#nullable restore
#line 6 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
 if (games == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
}
else
{
    foreach (var game in games)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h4");
            __builder.AddContent(3, 
#nullable restore
#line 14 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
             game.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 15 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
            game.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Average Rating: ");
            __builder.AddContent(10, 
#nullable restore
#line 16 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
                            gameRatings[game.Id]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\aweso\Documents\Github\TimsGameReview\BlazorReview\BlazorReview\Pages\Reviews.razor"
       
    private List<GameModel> games;
    private Dictionary<int, string> gameRatings = new Dictionary<int, string>();

    protected override async Task OnInitializedAsync()
    {
        games = await GameService.GetGamesAsync();
        foreach (var game in games)
        {
            gameRatings[game.Id] = await GetAverageRatingAsync(game.Id);
        }
    }

    private async Task<string> GetAverageRatingAsync(int gameId)
    {
        var ratings = await GameService.GetGameRatingsAsync(gameId);
        if (ratings.Any())
        {
            double avgRating = ratings.Average(r => r.Rating);
            return avgRating.ToString("0.0");
        }
        return "Not rated";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameService GameService { get; set; }
    }
}
#pragma warning restore 1591
