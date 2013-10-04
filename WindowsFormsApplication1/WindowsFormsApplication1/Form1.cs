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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Bill bill;
        public int add_id, add_quantity;
        public double total_price;
        public int ser = 1;
        public List<ProductItem> products = new List<ProductItem>(200);
        public Form1()
        {
            InitializeComponent();
            //
            SQLiteCommand cmmnd = new SQLiteCommand(@"Select * from Products;", Program.database_connection);
            SQLiteDataReader read = cmmnd.ExecuteReader();
            while (read.Read())
            {
                ProductItem p = new ProductItem(int.Parse(read["id"].ToString()), double.Parse(read["price"].ToString()), read["name"].ToString(), int.Parse(read["stock"].ToString()));
                products.Add(p);
            }
            total_price = 0;
            bill = new Bill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_id = -1;
            add_quantity = -1;
            using (AddItem form = new AddItem())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    add_id = form.id;
                    add_quantity = form.quantity;
                }
                
            }
            if (add_id == -1 && add_quantity == -1)
                return;
            else
                addItem();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            if (true)
            {
                AdminLogin form = new AdminLogin();
                form.ShowDialog();
            }
        }
        
        public void update_stock (int id, int quantity)
        {
            String query = null;
            if (quantity > 1)
                query = @"Update Products SET Stock=Stock - " + string.Format("{0}",quantity)+" Where ID=" + string.Format("{0}", id) + ";";
            else if (quantity == 1)
                query = @"Update Products SET Stock=Stock - 1 Where ID=" + string.Format("{0}", id) + ";";

            SQLiteCommand command = new SQLiteCommand(query, Program.database_connection);
            command.ExecuteNonQuery();
        }

        public ProductItem get_details(int id)
        {
            ProductItem prod = null;
            foreach (ProductItem item in products)
                if (item.id == id)
                    prod = item;
            return prod;
        }
        public void addItem() 
        {
            ProductItem product = get_details(add_id);
            double price = product.price;
            update_stock(add_id, add_quantity);

            this.dataGridView1.Rows.Add(ser, product.id, product.name, product.price, add_quantity, add_quantity * product.price);
            
            total_price += add_quantity * price;
            label2.Text = @Math.Round(total_price,2).ToString();
            bill.addItem(new BillItem(ser, product.name, product.price, add_quantity));
            ser++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int serial = -1;
            using (removeItem form = new removeItem())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    serial = form.srno;
                }
            }
            ser--;
            this.dataGridView1.Rows.RemoveAt(serial-1);
            double p = bill.bill[serial - 1].per;
            p *= bill.bill[serial - 1].qty;
            label2.Text = Math.Round((double.Parse(label2.Text) - p), 2).ToString();
            bill.bill.RemoveAt(serial - 1);
        }

        private void clearBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StreamReader fileToPrint = new StreamReader (@"D:\Project Bills\" + bill.bill_id.ToString() + ".txt");
            var printFont = new System.Drawing.Font("Consolas", 10);
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            bill.finalize();
            using (payorprint form = new payorprint())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.choice == 2)
                    {
                        printDocument1.Print();
                    }
                }
            }
            clearBill.PerformClick();
        }

        private void about_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog();
            }
        }
    }
}
