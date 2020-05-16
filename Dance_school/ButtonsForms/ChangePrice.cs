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
    public partial class ChangePrice : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        string pattern = @"\A[0-9]{1,4}(?:[.,][0-9]{1,2})?\z";

        public ChangePrice()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CourseList.SelectedItem == null)
            {
                MessageBox.Show("Please, select item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PriceTbx.Text != "")
            {
                MessageBox.Show("Your changes won't save", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void ChangePrice_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void ChangePrice_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ChangePrice_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            bool check = ValidateForm();
            if (check == true)
            {
                string text = "";
                string courseName = CourseList.GetItemText(CourseList.SelectedItem);
                float price = float.Parse(PriceTbx.Text);
                Course course = new Course();
                text = course.changePrice(courseName,price);
                MessageBox.Show(text);
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

        private void PriceTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, клавиша BackSpace и запятая а ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet6.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dance_schoolDataSet6.Course);

        }
    }
}
