// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addCustomer")]
    public partial class AddCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "E:\E Drive File\ASP. NET\Blazor\Connection_Blazor\Connection_Blazor\Pages\AddCustomer.razor"
       


    string Message = null;

    Customer cus = new Customer();
    CustomerDataAccess cusdata = new CustomerDataAccess();
    public void CreateCustomer()
    {
        cusdata.savedata(cus);

        Message = "Save Data Successfully";


    }

    public void Cancel()
    {

    }


    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
