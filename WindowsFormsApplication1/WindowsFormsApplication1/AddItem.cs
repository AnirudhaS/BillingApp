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
    public partial class AddItem : Form
    {
        public int id, quantity;
        public AddItem()
        {
            InitializeComponent();
            SQLiteCommand cmmnd = new SQLiteCommand(@"Select * from Products;", Program.database_connection);
            SQLiteDataReader read = cmmnd.ExecuteReader();
            while (read.Read())
            {
                this.dataGridView1.Rows.Add(read["id"].ToString(), read["name"].ToString(), read["price"].ToString(), read["stock"].ToString());
            }
            ProductID.Focus();
        }

        private void ProductQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add.PerformClick();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ProductID.Text != "" && ProductQuantity.Text != "")
            {
                if (int.Parse(ProductID.Text) > Program.TotalItems && int.Parse(ProductID.Text) < 1)
                {
                    label3.Visible = true;
                    label3.Text = @"Product ID does not exist.";
                }
                else
                {
                    id = int.Parse(ProductID.Text);
                    quantity = int.Parse(ProductQuantity.Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                label3.Visible = true;
                label3.Text = @"Enter Product ID and Quantity.";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void ProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.ProductID.Text != "" && this.ProductQuantity.Text != "")
                add.PerformClick();
            if (e.KeyCode == Keys.Tab && this.ProductID.Text != "")
                ProductQuantity.Focus();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            this.ProductID.Focus();
        }

    }
}
