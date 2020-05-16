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
    [Table(Name = "Student")]
   public class CustomerAccount : Account

    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        private Group group = new Group();
        [Column]
        private CustomerAccount status { get; set; }
        private string nameS { get; set; }
        private int groupN { get; set; }
        private string statusC{ get; set; }
        private void viewSchedule() { }

        public override string ToString()
        {
            return "Name: "+ nameS +" Group: "+ groupN + " Accaunt Status "+ statusC;
        }

        public string addNewClient(string clientName, string password, int group, string email, string phoneNumber, string address)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "INSERT into [Student] ([name], [password],[group],[account_status]) VALUES (@name,@password,@group,@accountStatus)";
Contact contactNew = new Contact();
            string status = "active                                            ";
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", clientName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@group", group);
                command.Parameters.AddWithValue("@accountStatus",status);

                SqlDataReader reader = command.ExecuteReader();
                
                

                while (reader.Read()) // построчно считываем данные
                {





                }

            }

            int idClient = getClientId(name);
            contactNew.addNewClientContact(idClient, email, address, phoneNumber);
            return "Done";


        }
        public int getClientId(string name)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Student] WHERE [name] LIKE @name";
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }
           

            return id;


        }
        public string addStudenttoGroup(string clientName, string groupName)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

           int groupId= group.getGroupId(groupName);

            string sqlExpression = "UPDATE [Student] SET [group] = @group Where [name] LIKE @Name";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@Name", clientName);
                command.Parameters.AddWithValue("@group", groupId);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read()) // построчно считываем данные
                {


                   
                  


                }
            }

            return "Done!";


        }
        public List<CustomerAccount> getClient()
        {

            List<CustomerAccount> listOfCustomer = new List<CustomerAccount>();
            
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT * FROM [Student] ";


            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {
                    CustomerAccount client = new CustomerAccount();

                    client.nameS = (string)reader.GetValue(1);
                    client.statusC = (string)reader.GetValue(4);

                    client.groupN = (int)reader.GetValue(5);
                 

                    listOfCustomer.Add(client);


                }
            }
            return listOfCustomer;
        }

        public bool checkClient(string email,string password)
        {

            

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [name] FROM [Student] Where [password] LIKE @password AND [id]= (SELECT [student] FROM [Contacts] Where [email] LIKE @email) ";


            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                command.Parameters.AddWithValue("@password", "%" + password + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {
                    return true;


                }
            }
            return false;
        }

    }
}
