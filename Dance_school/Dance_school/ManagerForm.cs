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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CPbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ChangePrice();
            frm.Show();
        }

        private void CSbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AccountPermission();
            frm.Show();
        }

        private void LGTbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
