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
using Dance_school.Enums;

namespace Dance_school.ButtonsForms
{
    public partial class AccountPermission : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AccountPermission()
        {
            InitializeComponent();
            StatusList.DataSource = GetStaffEnum();

        }
        public List<string> GetStaffEnum()
        {
            return Enum.GetNames(typeof(PermissionEnum)).ToList();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountPermission_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void AccountPermission_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AccountPermission_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AccountPermission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet9.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dance_schoolDataSet9.Staff);

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            TeacherAccount staff = new TeacherAccount();
            string staffName = listOfStaff.GetItemText(listOfStaff.SelectedItem);
        
            string email = EmailTbx.Text;
            string phone = PhoneTbx.Text;
            string status = StatusList.GetItemText(StatusList.SelectedItem);
            string text = staff.changePermission(staffName, status,email,phone);

        }

       
    }
}
