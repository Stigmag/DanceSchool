using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dance_school.Classes;
using System.Windows.Forms;
// ToDo - отображение всех курсов и цен
namespace Dance_school.ButtonsForms
{
    public partial class ViewAllCoursePrices : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ViewAllCoursePrices()
        {
            InitializeComponent();
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllCoursePrices_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ViewAllCoursePrices_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ViewAllCoursePrices_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllCoursePrices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet15.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dance_schoolDataSet15.Course);

        }

        private void CourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = new Course();
            string name = CourseList.GetItemText(CourseList.SelectedItem);

            double list = course.getCourse(name);

            PriceTbx.Text = list.ToString();
        }
    }
}
