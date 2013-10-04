using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class BillView : Form
    {
        public string id;
        public BillView(String id)
        {
            InitializeComponent();
            this.id = id;
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillView_Load(object sender, EventArgs e)
        {
            //((BillView)this.ParentForm).listView1.SelectedItems[0].ToString() = "new text!";
            String filename = id.Substring(id.Length - 3, 2);
            TextReader read = File.OpenText(@"D:\Project Bills\" + filename + ".txt");
            bill.Text = read.ReadToEnd();
            this.button1.Focus();
        }
    }
}
