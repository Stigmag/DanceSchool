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
    public partial class UserForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public UserForm()
        {
            InitializeComponent();
            LessonSchool lessonSchool = new LessonSchool();
            List<LessonSchool> list = new List<LessonSchool>();
            list = lessonSchool.getSchedule();

            listBox1.DataSource = list;
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

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void UserForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new SignIn();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }
    }
}
