using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace Dance_school.Classes
{
    [Table(Name = "Staff")]
   public class TeacherAccount:Account
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        private string name ;
        [Column]
        private string  role { get; set; }

        private void viewScedule() { }
        public string addNewStaff(string clientName, string password,string role,string email,string address,string phoneNumber)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "INSERT into [Staff] ([name], [password], [role]) VALUES (@name, @password,@role)";
            Contact contactNew = new Contact();
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", clientName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read()) // построчно считываем данные
                {





                }
                int idStaff = getStaffId(clientName);
                contactNew.addNewStaffContact(idStaff, email, address, phoneNumber);
            }

            
            return "Done";


        }
        public int getStaffId(string name)
        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Staff] WHERE ([name] LIKE @name)";
            int id = 0;
            

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }
            

            return id;


        }
        public List<string> getTeacherName()
        {
            List<string> listOfTeacher = new List<string>(); 

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [name] FROM [Staff] WHERE ([role] LIKE @role )";
            int id = 0;


            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string role = "TEACHER                                           ";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@role", role);
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


                    string name = (string)reader.GetValue(0);
                    listOfTeacher.Add(name);




                }
            }


            return listOfTeacher;


        }
        public int getTeacherId(string groupName)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Staff] WHERE ([name] LIKE @name) AND([role] LIKE @role)";
            int id = 0;
            string role = "TEACHER                                           ";
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", groupName);
                command.Parameters.AddWithValue("@role", role);
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }

            return id;


        }
        public string changePermission(string name, string status ,string email, string phone)
        {

            int idStaff = getStaffId(name);
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";


            string sqlExpression = "UPDATE [Staff] SET [role] = @role Where id=(SELECT [staff] FROM [Contacts] WHERE ([email] LIKE @email) AND([phone_number] LIKE @phone))  ";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                command.Parameters.AddWithValue("@phone", "%" + phone + "%");
                command.Parameters.AddWithValue("@role",status);
                
               
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {






                }
            }

            return "Done!";


        }
        public string getRole(string email, string password)
        {



            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [role] FROM [Staff] Where [password] LIKE @password AND [id]=(SELECT [staff] FROM [Contacts] Where [email] LIKE @email) ";

            string role = "";
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                command.Parameters.AddWithValue("@password", "%" + password + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {
                   role= (string)reader.GetValue(0);


                }
            }
            return role;
        }
    }
}
