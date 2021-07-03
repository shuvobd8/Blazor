using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Connection_Blazor.Data
{
    public class view
    { 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-79JA78Q;Initial Catalog=Blazor;Integrated Security=True");

        
        public  void show()
        {
            SqlCommand cmd = new SqlCommand("usp_view", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }



    }
}
