using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public static class Program
    {
        public static String connect = @"data source=d:/product_db.s3db; Version=3;";
        public static SQLiteConnection database_connection = new SQLiteConnection(connect);
        public static int TotalItems = 261;
        [STAThread]
        static void Main()
        {
            try
            {

                database_connection.Open();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new employeeLogin());
                //Application.Run(new Form1());
            }

            catch (SQLiteException e)
            {
                var m = e.Message;
            }
        }
    }

}
