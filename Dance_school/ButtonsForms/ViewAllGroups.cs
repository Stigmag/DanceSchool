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
// ToDo - отображение всех групп и их участтников
namespace Dance_school.ButtonsForms
{
    public partial class ViewAllGroups : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ViewAllGroups()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllGroups_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void ViewAllGroups_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ViewAllGroups_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            List<string> listOfName = group.getStudentFromSameGroup(Int32.Parse(text));


            foreach (string nameClient in listOfName)
            {
                StudentsList.Items.Add(nameClient);

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet.Group' table. You can move, or remove it, as needed.
            this.groupTableAdapter1.Fill(this.dance_schoolDataSet.Group);

            // TODO: This line of code loads data into the 'dance_schoolDataSet1.Group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.dance_schoolDataSet1.Group);
            

        }
    }
}
