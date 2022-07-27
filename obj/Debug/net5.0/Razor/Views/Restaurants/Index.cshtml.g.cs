#pragma checksum "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "625bf5137240575ab989c613f42e0de096a52459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 5 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"625bf5137240575ab989c613f42e0de096a52459", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurants.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Restaurants</h1>\n\n");
#nullable restore
#line 10 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No Restaurants have been added yet!</h3>\n");
#nullable restore
#line 13 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
 foreach (Restaurant restaurant in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 17 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
 Write(Html.ActionLink($"{restaurant.Description}", "Details", new { id = restaurant.RestaurantId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 17 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
                                                                                                  Write(restaurant.Cuisine.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 20 "/Users/WinnieWang/Desktop/E/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("Add new restaurant", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurants.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
