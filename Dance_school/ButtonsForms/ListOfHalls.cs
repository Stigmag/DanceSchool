using Dance_school.Enums;
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

namespace Dance_school.ButtonsForms
{
    public partial class ListOfHalls : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Hall room = new Hall();
        public ListOfHalls(int n)
        {
            InitializeComponent();
            

            if (n==1)
            {

                ChangeBtn.Visible = false;
                OKBtn.Left = 174;
                
            }
            if (n == 2)
            {
                OKBtn.Visible = false;
                ChangeBtn.Left = 174;
                StatusList.DataSource = GetStaffEnum();
            }
        }

        public List<string> GetStaffEnum()
        {
            return Enum.GetNames(typeof(HallStatus)).ToList();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string nameRoom = ListRooms.GetItemText(ListRooms.SelectedItem);
            string text = room.getRoomStatus(nameRoom);
            List<string> list = new List<string>();
            list.Add(text);
            StatusList.DataSource = list;
          
        }

        private void ListOfHalls_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void ListOfHalls_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ListOfHalls_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            string nameRoom = ListRooms.GetItemText(ListRooms.SelectedItem);
            string status = StatusList.GetItemText(StatusList.SelectedItem);
           string text= room.changeStatusRoom(nameRoom, status);
            MessageBox.Show(text);


        }

        private void ListOfHalls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dance_schoolDataSet14.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dance_schoolDataSet14.Room);

        }

       
    }
}
