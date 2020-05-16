using Dance_school.ButtonsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance_school
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static ApplicationContext Context { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Context = new ApplicationContext(new SignIn());
            Application.Run(Context);
        }
    }
}
