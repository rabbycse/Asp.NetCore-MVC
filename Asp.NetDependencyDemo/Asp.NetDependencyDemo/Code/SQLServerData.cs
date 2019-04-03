using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetDependencyDemo.Code
{
    public class SQLServerData
    {
        public void GetStudentName()
        {
            SqlConnection connection = new SqlConnection("Server=RABBI-LAPTOP\\MSSQLSERVERR;Database=DotNetCore;User Id=devskill;Password = 123456; ");

            try
            {
                SqlCommand command = new SqlCommand("insert into Student(name) values('Rabby')", connection);

                connection.Open();
                int effected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();

            }

        }
    }
}
