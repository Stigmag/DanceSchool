using Dance_school.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dance_school.Classes;

namespace Dance_school.ButtonsForms
{
    public partial class AddNewAccount : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        public AddNewAccount()
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

        private void button1_Click(object sender, EventArgs e)
        {
           bool check= ValidateForm();
            if (check == true)
            {
                string role = StatusList.GetItemText(StatusList.SelectedItem);
                string name = NameTbx.Text;
                string email = EmailTb.Text;
                string password = PasswordTbx.Text;
                string phoneNumber = PhoneTbx.Text;
                string address = AddressTbx.Text;
                string text = "";
 Contact contact = new Contact();

                if (role.Equals("CLIENT"))
                {
                    CustomerAccount client = new CustomerAccount();
                   int group = Int32.Parse(textBox1.Text);
                  
                    text = client.addNewClient(name, password,group,email,phoneNumber,address);
                                     
                    

                }
                else
                {
                    TeacherAccount staff = new TeacherAccount();
                    text = staff.addNewStaff(name, password, role,email,address,phoneNumber);
                    
                }
               
                MessageBox.Show(text);
               
            }
        }

        private void AddNewAccount_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void AddNewAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddNewAccount_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private bool ValidateForm()
        {
            string name = NameTbx.Text;
            string password = PasswordTbx.Text;
            string email = EmailTb.Text;
            string phone = PhoneTbx.Text;
            string address = AddressTbx.Text;

            // строка с именем не должна быть пустой (без пробелов сначала и конца)
            if (name.Trim() == string.Empty)
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // строка с паролем не должна быть пустой (без пробелов сначала и конца)
            if (password.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // корректность формата почты
            if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Некорректный email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // номер должен быть полным
            if (Remove(phone).Length < 10)
            {
                MessageBox.Show("Phone number error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            // адресс не должен == 0
            if (address.Trim() == string.Empty)
            {
                MessageBox.Show("Address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ToDo - добавить проверку на одинаковых людей
            // ToDo - добавить создание новых людей

            return true;
        }
        // оставляет только цифры для проверки номера
        static string Remove(string s)
        {
            s = s.Replace("-", "");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("_", "");
            s = s.Replace(" ", "");
            return s;
        }

        private void StatusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusList.SelectedIndex == 2)
            {
                textBox1.Visible = true;
                label1.Visible = true;
            }
        }
    }
}
