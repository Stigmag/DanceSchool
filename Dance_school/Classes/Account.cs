using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dance_school.Enums;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Dance_school.Classes
{
    //[Table(Name = "Students")]
   public abstract class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public  PermissionEnum permission { get; set; }

        public byte[] accountPhoto { get; set; }

        public Contact contac { get; set; }

        public void authorization() { }
        public void logOut() { }
        public void changePassword() 
        {
         /*   DataContext db = new DataContext
            (@"E:\Отчет\Учеба\Dance_school (4)\Dance_school\Dance_school\DataBase");
            Table<Account> Students = db.GetTable<Account>();*/
        }
        
    }
}
