using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Connection_Blazor.Data
{
    public class CustomerDataAccess
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79JA78Q;Initial Catalog=Blazor;Integrated Security=True");
        //string myDb1ConnectionString = Configuration.GetConnectionString("myDb1");


        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConfig"].ConnectionString);

        public void savedata(Customer info)
        {
            SqlCommand cmd = new SqlCommand("usp_AddCustomer", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",info.Name );
            cmd.Parameters.AddWithValue("@City", info.City);
            cmd.Parameters.AddWithValue("@Country", info.Country);
            cmd.Parameters.AddWithValue("@Gender", info.Gender);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


         
        
    }
}
