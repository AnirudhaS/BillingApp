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
    public partial class billHistory : Form
    {
        public billHistory()
        {
            InitializeComponent();
        }

        private void billHistory_Load(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand(@"Select * from Bill;", Program.database_connection);
            SQLiteDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem(read["id"].ToString());
                item.SubItems.Add(read["timestamp"].ToString());
                item.SubItems.Add(read["total"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            String id = listView1.SelectedItems[0].ToString();
            BillView bill = new BillView(id);
            bill.ShowDialog();
            

        }
    }
}
