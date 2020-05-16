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
    [Table(Name = "Group")]
    public class Group
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        private string name { get; set; }
        private List<CustomerAccount> student = new List<CustomerAccount>();
        private TeacherAccount teacher = new TeacherAccount();
        private Course course = new Course();
        public List<string>  getStudentFromSameGroup (int groupNumber)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [name] FROM [Student] WHERE [group]= @group";
            
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@group", groupNumber );
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {

                    
                   string  client= (string)reader.GetValue(0);


                    listOfClient.Add(client);


                }
            }

            return listOfClient;


        }
        public string addNewGroup(string courseName, string groupName)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

           
            int idCourse = course.getCourseId(courseName);

            string sqlExpression = "INSERT into [Group] ([name], [course]) VALUES (@name, @courseId)";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", groupName);
                command.Parameters.AddWithValue("@courseId", idCourse);
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


               


                }
            }

            return "Done";


        }
        public int getGroupId(string groupName)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Group] WHERE [name] LIKE @name";
            int id=0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + groupName + "%");
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


                     id = (int)reader.GetValue(0);


                   


                }
            }

            return id;


        }
    }
}
