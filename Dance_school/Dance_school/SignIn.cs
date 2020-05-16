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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        // ввод имени пользователя
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            // если поля остались не заполеными
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "Email";
            }

            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }
        // ввод пароля
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            // если поля остались не заполеными
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
            if(textBox3.Text == "")
            {
                textBox3.Text = "Email";
            }

            textBox2.PasswordChar = '*';

            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }
        // ввод почты
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            // если поля остались не заполеными
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }

            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.FromArgb(255, 34, 36, 48))
            {
                BackColor = Color.DarkSalmon;
                pictureBox1.BackColor = Color.DarkSalmon;
                label2.ForeColor = Color.Black;
                textBox1.BackColor = Color.DarkSalmon;
                textBox2.BackColor = Color.DarkSalmon;
                textBox3.BackColor = Color.DarkSalmon;
                button1.BackColor = Color.Plum;
                button1.ForeColor = Color.Black;
            }
            else if (BackColor == Color.DarkSalmon)
            {
                BackColor = Color.FromArgb(255, 34, 36, 48);
                pictureBox1.BackColor = Color.FromArgb(255, 34, 36, 48);
                label2.ForeColor = Color.WhiteSmoke;
                textBox1.BackColor = Color.FromArgb(255, 34, 36, 48);
                textBox2.BackColor = Color.FromArgb(255, 34, 36, 48);
                textBox3.BackColor = Color.FromArgb(255, 34, 36, 48);
                button1.BackColor = Color.FromArgb(255, 78, 184, 206);
                button1.ForeColor = Color.FromArgb(255, 34, 36, 48);
            }
        }
    }
}
