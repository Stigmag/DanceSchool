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
  
// ToDo - отображение всех клиентов
namespace Dance_school.ButtonsForms
{
    public partial class ViewAllClients : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ViewAllClients()
        {
            InitializeComponent();
            CustomerAccount customer = new CustomerAccount();
            List<CustomerAccount> list = new List<CustomerAccount>();
            list = customer.getClient();

            StudentsList.DataSource = list;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllClients_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void ViewAllClients_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ViewAllClients_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
