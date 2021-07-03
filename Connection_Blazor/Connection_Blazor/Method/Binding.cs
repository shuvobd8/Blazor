using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection_Blazor.Propertis;

namespace Connection_Blazor.Method
{
    public class Binding:ComponentBase
    {

        public Employee details { get; set; }

        protected override Task OnInitializedAsync()
        {

            details = new Employee()
            {
                Id =101,
                Name ="joherulhoq",
                Address = "Dhaka",
                Email = "joherulhoq@gmail.com"
            };


            return base.OnInitializedAsync();
        }
        

    }
}
