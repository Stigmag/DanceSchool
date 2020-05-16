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
    [Table(Name = "Accounting")]
    class ManagerAccount:Account
    
    {

        [Column(IsPrimaryKey = true)]
        private int id { get; set; }

        [Column]
        private double size { get; set; }
        [Column]
        private string status { get; set; }

        [Column]
        private int student { get; set; }



        public List<string> getStatus()
        {

            List<string> listOfCourse = new List<string>();

            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";



            string sqlExpression = "SELECT [status],[student] FROM [Accounting]";
            string nameS = "";
            string priceS = "";

            using (SqlConnection connection = new SqlConnection(connStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {


                    nameS =reader.GetValue(1).ToString();


                    priceS = reader.GetValue(0).ToString();


                    listOfCourse.Add(nameS.TrimEnd() + "     " + priceS);



                }
            }
            return listOfCourse;
        }

    }
}
