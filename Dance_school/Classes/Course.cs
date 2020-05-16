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
    [Table(Name = "Course")]
    public class Course
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        private TeacherAccount teacher { get; set; }
        [Column]
        private double price { get; set; }
        [Column]
        private Group group { get; set; }

     
        public int getCourseId(string courseName)
        {
            List<string> listOfClient = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Course] WHERE [name] LIKE @name";
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", courseName);
                SqlDataReader reader = command.ExecuteReader();
                Contact contactNew = new Contact();
                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }

            return id;


        }
        public string addNewCourse(string name,float price, string teacher)
        {
            TeacherAccount teacherAcc = new TeacherAccount();
            int teacherId=teacherAcc.getTeacherId(teacher);

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "INSERT into [Course] ([name], [prise], [teacher]) VALUES (@name, @price,@teacher)";
            
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@teacher", teacherId);
                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read()) // построчно считываем данные
                {





                }
                
            }


            return "Done";


        }
        public string changePrice(string courseName,float price)
        {
            

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";
            

            string sqlExpression = "UPDATE [Course] SET [prise] = @price Where [name] LIKE @Name";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@Name", "%" + courseName + "%");
                command.Parameters.AddWithValue("@price", price);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {






                }
            }

            return "Done!";


        }
        public double getCourse(string name)
        {

            List<float> listOfCourse = new List<float>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [prise] FROM [Course] Where [name] LIKE @name";


            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    price = (double)reader.GetValue(0);




                    


                }
            }
            return price;
        }


        public List<string> getCoursePrice()
        {

            List<string> listOfCourse = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [prise],[name] FROM [Course]";
            string nameS = "";
            string priceS = "";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
               
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    nameS = (string)reader.GetValue(1);


                    priceS = reader.GetValue(0).ToString();


                    listOfCourse.Add(nameS.TrimEnd() + "     " + priceS);



                }
            }
            return listOfCourse;
        }

    }
}
