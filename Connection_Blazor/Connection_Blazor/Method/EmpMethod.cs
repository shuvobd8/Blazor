using Connection_Blazor.Propertis;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Connection_Blazor.Method
{
    public class EmpMethod: ComponentBase
    {
      public  List<Employee> name { get; set; }

        protected override Task OnInitializedAsync()
        {

            initializeEmployee();

                return base.OnInitializedAsync();
        }
      


        public void initializeEmployee()
        {
            name = new List<Employee>()
            {

            new Employee { Id = 1, Name = "joherulhoq" },
            new Employee { Id = 2, Name = "shuvo" },
            new Employee {Address="Dhaka", Email = "joherulhoq@gmail.com"},

            };

        }
     
        
    }
}
