using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dance_school.Classes;

namespace Dance_school.ButtonsForms
{
    public partial class Lesson : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private int choose;

        public Lesson(int n)
        {
            choose = n;
            InitializeComponent();
            if (n==2)
            {
                OKBtn.Text = "Add";
                NameLb.Visible = true;
                LessonsName.Visible = true;
            }
            if (n==1)
            {
                OKBtn.Text = "Change";
                LessonsList.Visible = true;
                ExistingLbl.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LessonSchool lesson = new LessonSchool();
           // bool check= ValidateForm();
           // if (check == true)
           // {
                 string nameNew = LessonsName.Text;
                string nameEx = LessonsList.GetItemText(LessonsList.SelectedItem);

            string date = DateTbx.Text;
            string time = TimeTbx.Text;
           // var date = DateTime.ParseExact(dateS, "yyyyMMdd", null);
            //DateTime date = DateTime.Parse(DateTbx.Text);
                //DateTime time = DateTime.Parse(TimeTbx.Text);
                string groupName = GroupList.GetItemText(GroupList.SelectedItem);
                string courseName = CourseList.GetItemText(CourseList.SelectedItem);
                string roomName = RoomList.GetItemText(RoomList.SelectedItem);
                if (choose == 2)
                {
                    ValidateForm();
                    string text = lesson.addNewLesson(nameNew, date, time, courseName, groupName, roomName);
                    MessageBox.Show(text);


                }
                if(choose == 1)
                {
                    ValidateForm();
                    string text = lesson.changeLesson(nameEx, date, time, courseName, groupName, roomName);
                    MessageBox.Show(text);
                }


            //}
        }

        private void Lesson_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void Lesson_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Lesson_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private bool ValidateForm()
        {
            DateTime date;
            DateTime time;
            DateTime cmp_date = DateTime.Now.Date;

            // правильный формат времени
            if (!DateTime.TryParse(DateTbx.Text, out date))
            {
                MessageBox.Show("Unresolved date data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // правильный формат даты
            if (!DateTime.TryParse(TimeTbx.Text, out time))
            {
                MessageBox.Show("Unresolved time data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // дата и время не могут быть равны текущему моменту
            if (date < cmp_date)
            {
                MessageBox.Show("You can't back in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ToDo - добавить проверку полей списков и существующих уроков
            // ToDo - добавить создание новых уроков

            return true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet13.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dance_schoolDataSet13.Course);
            // TODO: This line of code loads data into the 'dance_schoolDataSet12.Group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.dance_schoolDataSet12.Group);
            // TODO: This line of code loads data into the 'dance_schoolDataSet11.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dance_schoolDataSet11.Room);
            // TODO: This line of code loads data into the 'dance_schoolDataSet10.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.dance_schoolDataSet10.Schedule);

        }
    }
}
