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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        // крестик вверху справа - закрывает окно
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // изменеие из темной на светлую и наоборот темы
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.FromArgb(255,34,36,48))
            {
                BackColor = Color.DarkSalmon;
                pictureBox1.BackColor = Color.DarkSalmon;
                label1.ForeColor = Color.Black;
            }
            else if (BackColor == Color.DarkSalmon)
            {
                BackColor = Color.FromArgb(255, 34, 36, 48);
                pictureBox1.BackColor = Color.FromArgb(255, 34, 36, 48);
                label1.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
