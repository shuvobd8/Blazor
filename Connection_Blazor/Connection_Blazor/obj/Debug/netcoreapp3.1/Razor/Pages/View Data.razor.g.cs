#pragma checksum "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\View Data.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47da55f499e7c414bdf2df168c7d65f9c8e73f1d"
// <auto-generated/>
#pragma warning disable 1591
namespace Connection_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Propertis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Method;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\_Imports.razor"
using Connection_Blazor.Design;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/View Data")]
    public partial class View_Data : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View_Data</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label for=\"Name\" class=\"control-label\">Show</label>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 9 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\View Data.razor"
     foreach (var item in viewsall)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "table");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "tr");
            __builder.AddContent(8, 
#nullable restore
#line 12 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\View Data.razor"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 14 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\View Data.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\View Data.razor"
       
    view v = new view();

    List<Employee> viewsall = new List<Employee>();

    public void data()
    {

        v.show();

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
