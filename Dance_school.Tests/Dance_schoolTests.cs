using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using System.Collections.Generic;
using Dance_school.Classes;

namespace Dance_school.Tests
{
    [TestClass]
    public class Dance_schoolTests
    {
        [TestMethod]
        public void GetCourseIdTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    Course course = new Course();

                    int id = course.getCourseId("HIP_HOP                                                                                                                                               ");




                    Assert.AreEqual(2, id);
                }
            }
        }
        [TestMethod]
        public void GetGroupIdTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    Group group = new Group();

                    int id = group.getGroupId("HIP-HOP.Introduction                                                                                                                                  ");




                    Assert.AreEqual(3, id);
                }
            }
        }
        [TestMethod]
        public void GeHallIdTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    Hall room = new Hall();

                    int id = room.getRoomId("GREEN                                             ");


                    Assert.AreEqual(1, id);
                }
            }
        }
        [TestMethod]
        public void GeLessonIdTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    LessonSchool lesson = new LessonSchool();

                    int id = lesson.getLessonId("L1                                                ");


                    Assert.AreEqual(1, id);
                }
            }
        }
        [TestMethod]
        public void AddNewClientContactTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    Contact contact = new Contact();

                 string text= contact.addNewClientContact(8,"kreate@gmail.com","Kol Str.,13","7987908198");


                    Assert.AreEqual("Done",text);
                }
            }
        }
        [TestMethod]
        public void AddNewClientTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    CustomerAccount client = new CustomerAccount();

                    string text = client.addNewClient("JOJO","juoiwefj88",3,"ijfioe@gmail.com","9797277","VL1 Str.,13");


                    Assert.AreEqual("Done", text);
                }
            }
        }
        [TestMethod]
        public void ViewScheduleTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    LessonSchool lesson = new LessonSchool();

                    List<LessonSchool> list = lesson.getSchedule();


                    Assert.AreEqual(1, list.Count);
                }
            }
        }
        [TestMethod]
        public void ViewClientTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    CustomerAccount client = new CustomerAccount();

                    List<CustomerAccount> list = client.getClient();


                    Assert.AreEqual(14, list.Count);
                }
            }
        }
        [TestMethod]
        public void ViewCoursePriseTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    Course course = new Course();

                    double price= course.getCourse("CONTEMPORARY                                                                                                                                          ");


                    Assert.AreEqual(12390, price);
                }
            }
        }
        [TestMethod]
        public void GetteacherIdTest()
        {
            string connStr = @"Data Source=DESKTOP-SDGK59R\SQLEXPRESS;
                            Initial Catalog=dance_school;
                            
                            Integrated Security=True";

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection =
                    new SqlConnection(connStr))
                {
                    connection.Open();
                    TeacherAccount teacher = new TeacherAccount();

                    List<string>list= teacher.getTeacherName();


                    Assert.AreEqual(2, list.Count);
                }
            }
        }
    }
}