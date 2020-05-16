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
    public partial class AddAccountToGroup : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AddAccountToGroup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAccountToGroup_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void AddAccountToGroup_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddAccountToGroup_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AddAccountToGroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet3.Group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.dance_schoolDataSet3.Group);
            // TODO: This line of code loads data into the 'dance_schoolDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dance_schoolDataSet2.Student);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string clientName = ClientList.GetItemText(ClientList.SelectedItem);
            string groupName = GroupList.GetItemText(GroupList.SelectedItem);
            CustomerAccount client = new CustomerAccount();
          string text=  client.addStudenttoGroup(clientName, groupName);
            MessageBox.Show(text);
        }
    }
}
