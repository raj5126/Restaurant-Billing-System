namespace Restaurant_Billing_System
{
    partial class DisplayItems
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.totalbill = new System.Windows.Forms.Button();
            this.pricelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(12, 315);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(345, 184);
            this.listBox.TabIndex = 0;
            // 
            // totalbill
            // 
            this.totalbill.Location = new System.Drawing.Point(98, 574);
            this.totalbill.Name = "totalbill";
            this.totalbill.Size = new System.Drawing.Size(110, 44);
            this.totalbill.TabIndex = 1;
            this.totalbill.Text = "Generate Bill";
            this.totalbill.UseVisualStyleBackColor = true;
            this.totalbill.Click += new System.EventHandler(this.totalbill_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(13, 529);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(0, 25);
            this.pricelabel.TabIndex = 2;
            // 
            // DisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 661);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.totalbill);
            this.Controls.Add(this.listBox);
            this.Name = "DisplayItems";
            this.Text = "DisplayItems";
            this.Load += new System.EventHandler(this.DisplayItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button totalbill;
        private System.Windows.Forms.Label pricelabel;
    }
}