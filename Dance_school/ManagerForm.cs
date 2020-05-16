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
using Dance_school.Classes;

namespace Dance_school
{
    public partial class ManagerForm : Form
    {
        // передвижение формы (0)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ManagerForm()
        {
            InitializeComponent();
            Course customer = new Course();
            List<string> list = new List<string>();
            list = customer.getCoursePrice();
            CorseList.DataSource = list;
            ManagerAccount accounting = new ManagerAccount();
            List<string> accountingList = new List<string>();
            accountingList = accounting.getStatus();
            HallList.DataSource = accountingList;
            EmailLbl.Text = "iejfoi@gmail.com";
            PhoneLbl.Text = "(984) 898-9080";
            NameLbl.Text = "ALLA";
        }
        // крестик вверху справа - закрывает окно
        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // изменить цену за курс
        private void CPbtn_Click(object sender, EventArgs e)
        {
            
            Form frm = new ChangePrice();
            frm.Show();
            Course customer = new Course();
            List<string> list = new List<string>();
            list = customer.getCoursePrice();
            CorseList.DataSource = list;
        }
        // изменить статус зала
        private void CSbtn_Click(object sender, EventArgs e)
        {
           

            Form frm = new ChangePrice();
            frm.Show();
            Course customer = new Course();
            List<string> list = new List<string>();
            list = customer.getCoursePrice();
            CorseList.DataSource = list;
        }
        // выход из аккаунта
        private void LGTbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel);
            Program.Context.MainForm = new SignIn();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }
        // передвижение формы (1)
        private void ManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        // передвижение формы (2)
        private void ManagerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        // передвижение формы (3)
        private void ManagerForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        // крестик становится красным при наведении мыши
        private void labelClose_MouseHover(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Red;
        }
        // возвращение оригинального цвета крестику
        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet18.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.dance_schoolDataSet18.Course);
            // TODO: This line of code loads data into the 'dance_schoolDataSet17.Accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.dance_schoolDataSet17.Accounting);
            // TODO: This line of code loads data into the 'dance_schoolDataSet16.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dance_schoolDataSet16.Course);

        }
    }
}
