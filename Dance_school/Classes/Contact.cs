using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Dance_school.Classes
{
    [Table(Name = "Contacts")]
    public class Contact
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        public string email { get; set; }

        [Column]
        public string phoneNumber { get; set; }


        public string addNewClientContact(int id, string email, string address, string phoneNumber)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "INSERT into [Contacts] ( [address],[phone_number],[email],[student]) VALUES ( @address,@phoneNumber,@email,@student)";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@address", address);
               
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@student", id);
               

                SqlDataReader reader = command.ExecuteReader();
                

                while (reader.Read()) // построчно считываем данные
                {





                }
            }

            return "Done";
        }
        public string addNewStaffContact(int id, string email, string address, string phoneNumber)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "INSERT into [Contacts] ( [address],[phone_number],[email],[staff]) VALUES ( @address,@phoneNumber,@email,@staff)";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@staff", id);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read()) // построчно считываем данные
                {





                }
            }

            return "Done";
        }


       

    }
}
