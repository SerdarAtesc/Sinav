using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sinav
{
    public class DataBase
    {

        public SqlConnection con;
        SqlCommand cmd;
      


        public SqlConnection connectDataBase()
        {
            con = new SqlConnection("Data Source=DESKTOP-1DMDCN6;Initial Catalog=Sinav;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
            return con;

        }







    }
}
