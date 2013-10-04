using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApplication1
{
    public partial class orderStock : Form
    {
        public int st = -1;
        public orderStock()
        {
            InitializeComponent();
            productId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prod_id = int.Parse(productId.Text);
            st = int.Parse(stock.Text);
            if (prod_id <= Program.TotalItems && st > 0)
            {
                String query = @"Update Products SET Stock=Stock+" + string.Format("{0}", st) + " Where ID=" + string.Format("{0}", prod_id) + ";";
                SQLiteCommand com = new SQLiteCommand(query, Program.database_connection);
                com.ExecuteNonQuery();
            }
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (productId.Text != "" && stock.Text != "" && e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
