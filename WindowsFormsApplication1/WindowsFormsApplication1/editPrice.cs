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
    public partial class editPrice : Form
    {
        public editPrice()
        {
            InitializeComponent();
        }

        private void newproductPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (newproductPrice.Text != "" && e.KeyCode == Keys.Enter)
            {
                buttonOk.PerformClick();
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            if (productId.Text != "" && newproductPrice.Text != "")
            {
                double price = double.Parse(newproductPrice.Text);
                int id = int.Parse(productId.Text);
                if (id <= Program.TotalItems)
                {
                    String query = @"Update Products SET Price=" + string.Format("{0}", price) + @" Where ID=" + string.Format("{0}", id) + ";";
                    SQLiteCommand cmmnd = new SQLiteCommand(query, Program.database_connection);
                    var read = cmmnd.ExecuteNonQuery();
                }
                else if (int.Parse(productId.Text) > 261)
                {
                    label4.Visible = true;
                    label4.Text = "Incorrect ID";
                }
            }
            else
            {
                label4.Visible = true;
                label4.Text = " Enter ID and Price.";
            }
            this.Close();
               
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
