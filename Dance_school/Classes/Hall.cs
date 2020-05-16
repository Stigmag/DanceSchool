using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dance_school.Enums;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;


namespace Dance_school.Classes
{
    [Table(Name = "Room")]
    public class Hall
    {
        [Column(IsPrimaryKey = true)]
        private int id { get; set; }

        [Column]
        private HallStatus status { get; set; }
        [Column]
        private string name { get; set; }

        public int getRoomId(string roomName)
        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Room] WHERE [name] LIKE @name";
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + roomName + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }

            return id;


        }
        public string changeStatusRoom(string name, string status)
        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "UPDATE [Room] SET [status] = @status Where [name]= @name";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@status", status);



                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read()) // построчно считываем данные
                {





                }
            }
            return "Done!";
        }
        public string getRoomStatus(string roomName)
        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [status] FROM [Room] WHERE [name] LIKE @name";
            string status = "";
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + roomName + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    status = (string)reader.GetValue(0);





                }
            }
            return status;
        }
    }
}
