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
    public partial class AddGroup : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AddGroup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGroup_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void AddGroup_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddGroup_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet5.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.dance_schoolDataSet5.Course);
            // TODO: This line of code loads data into the 'dance_schoolDataSet4.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dance_schoolDataSet4.Course);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            string groupName = NameTbx.Text;
            string courseName = CourseList.GetItemText(CourseList.SelectedItem);
            Group newGroup = new Group();
            string text = newGroup.addNewGroup(courseName, groupName);
            MessageBox.Show(text);

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
