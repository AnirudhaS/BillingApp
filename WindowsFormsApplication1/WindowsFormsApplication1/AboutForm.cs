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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        
        private void AboutForm_Load(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = @"D:\logo.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = @"This software is developed by RSR Billing Systems, RSR Software Inc. The Software title and trademarks are subject to "+ Environment.NewLine + "Copyrights owned by RSR Software, Inc.";
            label2.Text = @"KGS Billing Provides industrial grade billing management for small scale Grocery Stores with an easy-to-use Interface." + Environment.NewLine + 
                            @"                                                                           Rights Reserved.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
