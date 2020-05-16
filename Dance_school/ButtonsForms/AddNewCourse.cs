using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dance_school.Classes;

namespace Dance_school.ButtonsForms
{
    public partial class AddNewCourse : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        string pattern = @"\A[0-9]{1,4}(?:[.,][0-9]{1,2})?\z";
        private TeacherAccount teacher = new TeacherAccount();
        public AddNewCourse()
        {
            InitializeComponent();
             List<string> teachers = teacher.getTeacherName();
            //int id = teacher.getTeacherId("ALLA");

            TeacherList.DataSource = teachers;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewCourse_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void AddNewCourse_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddNewCourse_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {// TODO - валидатор на цену, хотя зачем - просто 4 значные число вводить и все
            // тут есть валидатор
            if (ValidateForm())
            {
                Course courseNew = new Course();
                string nameCourse = NameTbx.Text;
                float price = float.Parse(PriceTbx.Text);
                

                string teacherName = TeacherList.GetItemText(TeacherList.SelectedItem);
                courseNew.addNewCourse(nameCourse, price, teacherName);
            }
            

        }

        private bool ValidateForm()
        {
            string price = PriceTbx.Text;

            // цена - {1-4 знака , 1-2 знака}
            if (!Regex.IsMatch(price, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Incorrect price format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //double correct = double.Parse(price);

            return true;
        }
    }
}
