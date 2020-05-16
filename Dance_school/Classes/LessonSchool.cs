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
    [Table(Name = "Schedule")]
   public class LessonSchool
    {
        [Column(IsPrimaryKey = true)]
        public int id { get; set; }
        [Column]
        private string name { get; set; }
        [Column]
        private Hall room = new Hall();
        [Column]
        private DateTime time { get; set; }
        [Column]
        private Course course = new Course();

        [Column]
        private Group group = new Group();
        [Column]
        private DateTime date { get; set; }

        public override string ToString()
        {
            return "Lesson: " + name + time + date +" Hall:"+ roomS+" Course:" + courseS+" Group:" + groupS;
        }

        private int roomS =0;
        private int courseS = 0;
        private int groupS = 0;
        public string addNewLesson(string name, string date, string time, string nameCourse, string nameGroup, string nameRoom)
            
        {
           

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            int idGroup = group.getGroupId(nameGroup);
            int idCourse = course.getCourseId(nameCourse);
            int idRoom = room.getRoomId(nameRoom);

            string sqlExpression = "INSERT into [Schedule] ( [name],[date],[time],[room],[course],[group]) VALUES ( @name,@date,@time,@room,@course,@group)";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@room", idRoom);
                command.Parameters.AddWithValue("@course", idCourse);
                command.Parameters.AddWithValue("@group", idGroup);


                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read()) // построчно считываем данные
                {





                }
            }

            return "Done";
        }
        public string changeLesson(string name, string date, string time, string nameCourse, string nameGroup, string nameRoom)

        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            int idGroup = group.getGroupId(nameGroup);
            int idCourse = course.getCourseId(nameCourse);
            int idRoom = room.getRoomId(nameRoom);
            int id = getLessonId(name);

            string sqlExpression = "UPDATE [Schedule] SET [name] = @name,[date]=@date,[time]=@time,[room]=@room,[course]=@course,[group]=@group Where [id]= @id";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@room", idRoom);
                command.Parameters.AddWithValue("@course", idCourse);
                command.Parameters.AddWithValue("@group", idGroup);
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read()) // построчно считываем данные
                {





                }
            }

            return "Done";
        }
        public int getLessonId(string lessonName)
        {


            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [id] FROM [Schedule] WHERE [name] LIKE @name";
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", "%" + lessonName + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    id = (int)reader.GetValue(0);





                }
            }

            return id;


        }
        public List<LessonSchool> getSchedule()
        {

            List<LessonSchool> lesson = new List<LessonSchool>();
            
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT * FROM [Schedule] ";
            

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {

                    LessonSchool lessonS = new LessonSchool();
                    lessonS.name = (string)reader.GetValue(1);
                    lessonS.date = (DateTime)reader.GetValue(2);
                    
                    lessonS.roomS =(int) reader.GetValue(4);
                    lessonS.courseS = (int)reader.GetValue(5);
                    lessonS.groupS = (int)reader.GetValue(6);





                    lesson.Add(lessonS);


                }
            }
            return lesson;
        }

    }
}
