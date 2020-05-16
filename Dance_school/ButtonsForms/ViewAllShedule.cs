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
// ToDo - отображение рассписания
namespace Dance_school.ButtonsForms
{
    public partial class ViewAllShedule : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ViewAllShedule()
        {
            InitializeComponent();
            LessonSchool lessonSchool = new LessonSchool();
            List<LessonSchool> list = new List<LessonSchool>();
            list = lessonSchool.getSchedule();
            
            ScheduleList.DataSource = list;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllShedule_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ViewAllShedule_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ViewAllShedule_MouseUp(object sender, MouseEventArgs e)
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
