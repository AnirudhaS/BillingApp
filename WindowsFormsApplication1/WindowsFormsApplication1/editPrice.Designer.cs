namespace WindowsFormsApplication1
{
    partial class editPrice
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.newproductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.warnLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(19, 105);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(109, 105);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Barcode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Price :";
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(109, 24);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(100, 20);
            this.productId.TabIndex = 4;
            // 
            // newproductPrice
            // 
            this.newproductPrice.Location = new System.Drawing.Point(109, 50);
            this.newproductPrice.Name = "newproductPrice";
            this.newproductPrice.Size = new System.Drawing.Size(100, 20);
            this.newproductPrice.TabIndex = 5;
            this.newproductPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newproductPrice_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            this.label3.Visible = false;
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.ForeColor = System.Drawing.Color.Red;
            this.warnLabel.Location = new System.Drawing.Point(22, 79);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(0, 13);
            this.warnLabel.TabIndex = 3;
            this.warnLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Visible = false;
            // 
            // editPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 140);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newproductPrice);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "editPrice";
            this.Text = "Enter new product price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.TextBox newproductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.Label label4;
    }
}