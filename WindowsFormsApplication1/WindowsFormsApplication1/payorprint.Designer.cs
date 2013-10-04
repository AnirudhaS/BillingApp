namespace WindowsFormsApplication1
{
    partial class payorprint
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
            this.onlyPay = new System.Windows.Forms.Button();
            this.payandprint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onlyPay
            // 
            this.onlyPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.onlyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyPay.Location = new System.Drawing.Point(44, 32);
            this.onlyPay.Name = "onlyPay";
            this.onlyPay.Size = new System.Drawing.Size(82, 32);
            this.onlyPay.TabIndex = 0;
            this.onlyPay.Text = "Pay";
            this.onlyPay.UseVisualStyleBackColor = true;
            this.onlyPay.Click += new System.EventHandler(this.onlyPay_Click);
            // 
            // payandprint
            // 
            this.payandprint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.payandprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payandprint.Location = new System.Drawing.Point(176, 32);
            this.payandprint.Name = "payandprint";
            this.payandprint.Size = new System.Drawing.Size(102, 32);
            this.payandprint.TabIndex = 0;
            this.payandprint.Text = "Pay and Print";
            this.payandprint.UseVisualStyleBackColor = true;
            this.payandprint.Click += new System.EventHandler(this.payandprint_Click);
            // 
            // payorprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 95);
            this.Controls.Add(this.payandprint);
            this.Controls.Add(this.onlyPay);
            this.Name = "payorprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onlyPay;
        private System.Windows.Forms.Button payandprint;
    }
}