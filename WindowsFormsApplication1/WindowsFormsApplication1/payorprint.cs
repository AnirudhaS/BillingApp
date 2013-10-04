using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class payorprint : Form
    {
        public int choice = -1;
        public payorprint()
        {
            InitializeComponent();
        }

        private void onlyPay_Click(object sender, EventArgs e)
        {
            
            choice = 1;
            this.Close();
        }

        private void payandprint_Click(object sender, EventArgs e)
        {
            choice = 2;
            this.Close();
        }
    }
}
