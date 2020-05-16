using Dance_school.ButtonsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance_school
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        // крестик вверху справа - закрывает окно
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // черточка вверху справа - сворачивает окно
        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ANCbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewAccount();
            frm.Show();
        }

        private void ANTbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewAccount();
            frm.Show();
        }

        private void ANMbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewAccount();
            frm.Show();
        }

        private void ANCrsbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewCourse();
            frm.Show();
        }

        private void ALbtn_Click(object sender, EventArgs e)
        {
            Form frm = new Lesson();
            frm.Show();
        }

        private void AGbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddGroup();
            frm.Show();
        }

        private void AATGbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddAccountToGroup();
            frm.Show();
        }

        private void SSHbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ListOfHalls();
            frm.Show();
        }

        private void ELbtn_Click(object sender, EventArgs e)
        {
            Form frm = new Lesson();
            frm.Show();
        }

        private void AAPbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AccountPermission();
            frm.Show();
        }

        private void VAGbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllGroups();
            frm.Show();
        }

        private void VASbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllShedule();
            frm.Show();
        }

        private void VACbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllClients();
            frm.Show();
        }

        private void VLHbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ListOfHalls();
            frm.Show();
        }

        private void VACPbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllCoursePrices();
            frm.Show();
        }

        private void LgtBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", null, MessageBoxButtons.OKCancel);
        }
    }
}
