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

namespace Dance_school
{
    public partial class SignIn : Form
    { 
        // передвижение формы (0)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public SignIn()
        {
            InitializeComponent();
        }
        // ввод пароля
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (PasswordTbx.Text == "Password")
            {
                PasswordTbx.Clear();
            }
            // если поля остались не заполеными
            if(EmailTbx.Text == "")
            {
                EmailTbx.Text = "Email";
            }

            PasswordTbx.PasswordChar = '*';

            panel2.BackColor = Color.FromArgb(78, 184, 206);
            PasswordTbx.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;

            panel3.BackColor = Color.WhiteSmoke;
            EmailTbx.ForeColor = Color.WhiteSmoke;
        }
        // ввод почты
        private void textBox3_Click(object sender, EventArgs e)
        {
            if (EmailTbx.Text == "Email")
            {
                EmailTbx.Clear();
            }
            // если поля остались не заполеными
            if (PasswordTbx.Text == "")
            {
                PasswordTbx.Text = "Password";
            }

            panel3.BackColor = Color.FromArgb(78, 184, 206);
            EmailTbx.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;

            panel2.BackColor = Color.WhiteSmoke;
            PasswordTbx.ForeColor = Color.WhiteSmoke;
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
                SettingsPBx.BackColor = Color.DarkSalmon;
                CloseLbl.ForeColor = Color.Black;
                PasswordTbx.BackColor = Color.DarkSalmon;
                EmailTbx.BackColor = Color.DarkSalmon;
                SIbtn.BackColor = Color.Plum;
                SIbtn.ForeColor = Color.Black;
            }
            else if (BackColor == Color.DarkSalmon)
            {
                BackColor = Color.FromArgb(255, 34, 36, 48);
                SettingsPBx.BackColor = Color.FromArgb(255, 34, 36, 48);
                CloseLbl.ForeColor = Color.WhiteSmoke;
                PasswordTbx.BackColor = Color.FromArgb(255, 34, 36, 48);
                EmailTbx.BackColor = Color.FromArgb(255, 34, 36, 48);
                SIbtn.BackColor = Color.FromArgb(255, 78, 184, 206);
                SIbtn.ForeColor = Color.FromArgb(255, 34, 36, 48);
            }
        }
        // вход в аккаунт
        private void SIbtn_Click(object sender, EventArgs e)
        {
            string email = EmailTbx.Text;
            string password = PasswordTbx.Text;
            CustomerAccount client = new CustomerAccount();
            bool presentClient = client.checkClient(email, password);
            if (presentClient == true)
            {
                Form frm = new UserForm();
                frm.Show();
                this.Close();

            }
            else
            {
                TeacherAccount staff = new TeacherAccount();
                string role = staff.getRole(email, password);
                if (role.Equals("TEACHER                                           "))
                {
                    Program.Context.MainForm = new UserForm();

                    this.Close();

                    // покажет вторую форму и оставит приложение живым до ее закрытия
                    Program.Context.MainForm.Show();
                }
                else if (role.Equals("ADMIN                                             "))
                {
                    Program.Context.MainForm = new AdminForm();

                    this.Close();

                    // покажет вторую форму и оставит приложение живым до ее закрытия
                    Program.Context.MainForm.Show();
                }
                else if (role.Equals("MANAGER                                           "))
                {   

                    
                    Program.Context.MainForm = new ManagerForm();

                    this.Close();

                    // покажет вторую форму и оставит приложение живым до ее закрытия
                    Program.Context.MainForm.Show();


                }
            }
        }
        // передвижение формы (1)
        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        // передвижение формы (2)
        private void SignIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        // передвижение формы (3)
        private void SignIn_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
