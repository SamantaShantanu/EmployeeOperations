using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOperations.DAL
{
    public class EmployeeSave
    {
        private SqlConnection con;

        public bool EmployeeRegistration(Employee emp)
        {
            string constring = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("EmployeeCRUDOperation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmailId", emp.Email);
            cmd.Parameters.AddWithValue("@Password", emp.Password);
            cmd.Parameters.AddWithValue("@Id", emp.Id);
            cmd.Parameters.AddWithValue("@Flag", 0);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}
