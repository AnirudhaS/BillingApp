namespace WindowsFormsApplication1
{
    partial class AdminView
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sr_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editPricing = new System.Windows.Forms.Button();
            this.orderStock = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.billHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Items : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Initiliaze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sr_no,
            this.ItemCode,
            this.ItemName,
            this.ItemStock,
            this.ItemPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 363);
            this.dataGridView1.TabIndex = 3;
            // 
            // sr_no
            // 
            this.sr_no.HeaderText = "Sr No.";
            this.sr_no.Name = "sr_no";
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Barcode";
            this.ItemCode.Name = "ItemCode";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 300;
            // 
            // ItemStock
            // 
            this.ItemStock.HeaderText = "Stock";
            this.ItemStock.Name = "ItemStock";
            this.ItemStock.Width = 150;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Width = 150;
            // 
            // editPricing
            // 
            this.editPricing.Location = new System.Drawing.Point(119, 13);
            this.editPricing.Name = "editPricing";
            this.editPricing.Size = new System.Drawing.Size(101, 34);
            this.editPricing.TabIndex = 4;
            this.editPricing.Text = "Edit Pricing";
            this.editPricing.UseVisualStyleBackColor = true;
            this.editPricing.Click += new System.EventHandler(this.editPricing_Click);
            // 
            // orderStock
            // 
            this.orderStock.Location = new System.Drawing.Point(226, 15);
            this.orderStock.Name = "orderStock";
            this.orderStock.Size = new System.Drawing.Size(101, 33);
            this.orderStock.TabIndex = 5;
            this.orderStock.Text = "Order Stock";
            this.orderStock.UseVisualStyleBackColor = true;
            this.orderStock.Click += new System.EventHandler(this.orderStock_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // billHistory
            // 
            this.billHistory.Location = new System.Drawing.Point(333, 15);
            this.billHistory.Name = "billHistory";
            this.billHistory.Size = new System.Drawing.Size(105, 33);
            this.billHistory.TabIndex = 8;
            this.billHistory.Text = "Bill History";
            this.billHistory.UseVisualStyleBackColor = true;
            this.billHistory.Click += new System.EventHandler(this.billHistory_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 484);
            this.Controls.Add(this.billHistory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.orderStock);
            this.Controls.Add(this.editPricing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.Button editPricing;
        private System.Windows.Forms.Button orderStock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button billHistory;
    }
}