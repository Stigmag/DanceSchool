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
    public partial class AdminForm : Form
    {
        // передвижение формы (0)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AdminForm()
        {
            InitializeComponent();
        }
        // крестик вверху справа - закрывает окно
        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Close();
        }
        // черточка вверху справа - сворачивает окно
        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // добавить новый аккаунт
        private void ANAbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewAccount();
            frm.Show();
        }
        // добавить новый курс
        private void ANCrsbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewCourse();
            frm.Show();
        }
        // добавить новый урок
        private void ALbtn_Click(object sender, EventArgs e)
        {
            Form frm = new Lesson(2);
            frm.Show();
        }
        // добавить новую группу
        private void AGbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddGroup();
            frm.Show();
        }
        // добавить аккаунт к группе
        private void AATGbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AddAccountToGroup();
            frm.Show();
        }
        // установить статус зала
        private void SSHbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ListOfHalls(2);
            frm.Show();
        }
        // редактировать существующий урок
        private void ELbtn_Click(object sender, EventArgs e)
        {
            Form frm = new Lesson(1);
            frm.Show();
        }
        // редактировать разрешение аккаунта
        private void AAPbtn_Click(object sender, EventArgs e)
        {
            Form frm = new AccountPermission();
            frm.Show();
        }
        // просмотр всех групп
        private void VAGbtn_Click(object sender, EventArgs e)
        {
            
            Form frm = new ViewAllGroups();
            frm.Show();
        }
        // просмотр всех расписаний
        private void VASbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllShedule();
            frm.Show();
        }
        // просмотр всех клиентов
        private void VACbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllClients();
            frm.Show();
        }
        // просмотреть статусы залов
        private void VLHbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ListOfHalls(1);
            frm.Show();
        }
        // просмотреть все курсы и цены
        private void VACPbtn_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllCoursePrices();
            frm.Show();
        }
        // выход из аккаунта
        private void LgtBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.OKCancel);
            Program.Context.MainForm = new SignIn();

            this.Close();

            // покажет вторую форму и оставит приложение живым до ее закрытия
            Program.Context.MainForm.Show();
        }
        // передвижение формы (1)
        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        // передвижение формы (2)
        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        // передвижение формы (3)
        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        // крестик становится красным при наведении мыши
        private void CloseLbl_MouseHover(object sender, EventArgs e)
        {
            CloseLbl.BackColor = Color.Red;
        }
        // возвращение оригинального цвета крестику
        private void CloseLbl_MouseLeave(object sender, EventArgs e)
        {
            CloseLbl.BackColor = Color.FromArgb(34, 36, 49);
        }
    }
}
