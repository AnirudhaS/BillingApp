namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.clearBill = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.ItemID,
            this.ItemName,
            this.UnitPrice,
            this.ItemQuantity,
            this.TotalPerUnit});
            this.dataGridView1.Location = new System.Drawing.Point(4, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemNo
            // 
            this.ItemNo.HeaderText = "Sr. No.";
            this.ItemNo.Name = "ItemNo";
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Barcode";
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 250;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Price per One";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 110;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 75;
            // 
            // TotalPerUnit
            // 
            this.TotalPerUnit.HeaderText = "Total";
            this.TotalPerUnit.Name = "TotalPerUnit";
            this.TotalPerUnit.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(651, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(737, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "0.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearBill
            // 
            this.clearBill.Location = new System.Drawing.Point(520, 92);
            this.clearBill.Name = "clearBill";
            this.clearBill.Size = new System.Drawing.Size(87, 31);
            this.clearBill.TabIndex = 5;
            this.clearBill.Text = "Clear Bill";
            this.clearBill.UseVisualStyleBackColor = true;
            this.clearBill.Click += new System.EventHandler(this.clearBill_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(229, 94);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(81, 31);
            this.pay.TabIndex = 6;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(23, 12);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(88, 33);
            this.adminLogin.TabIndex = 7;
            this.adminLogin.Text = "Admin Login";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(749, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 27);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(657, 12);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(86, 27);
            this.about.TabIndex = 9;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.about);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.clearBill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Bill Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPerUnit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearBill;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button about;
    }
}

