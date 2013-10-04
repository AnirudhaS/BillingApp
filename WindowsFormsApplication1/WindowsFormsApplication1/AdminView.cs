using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SQLite;
namespace WindowsFormsApplication1
{
    public partial class AdminView : Form
    {
        
        public AdminView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = @"Total Items : ";
            SQLiteCommand cmmnd = new SQLiteCommand(@"Select * from Products;", Program.database_connection);
            SQLiteDataReader read = cmmnd.ExecuteReader();
            int srno = 1;
            while (read.Read())
            {
                this.dataGridView1.Rows.Add(srno, read["id"], read["name"], read["stock"], read["price"]);
                srno++;
            }
            label1.Text = @"Total Items : " + Program.TotalItems.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

     
        private void editPricing_Click(object sender, EventArgs e)
        {
            editPrice form = new editPrice();
            if (form.ShowDialog() == DialogResult.Cancel)
                form.Close();
            this.dataGridView1.Rows.Clear();
            button1.PerformClick();
            
        }

        private void orderStock_Click(object sender, EventArgs e)
        {
            using (orderStock form = new orderStock())
            {
                if (form.ShowDialog() == DialogResult.Cancel)
                {
                    form.Close();
                }
            }

            this.dataGridView1.Rows.Clear();
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void billHistory_Click(object sender, EventArgs e)
        {
            using (billHistory view = new billHistory())
            {
                view.ShowDialog();
            }
        }
    }
}
