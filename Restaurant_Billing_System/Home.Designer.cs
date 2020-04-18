namespace Restaurant_Billing_System
{
    partial class Home
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
            this.additem = new System.Windows.Forms.Button();
            this.take_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // additem
            // 
            this.additem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.additem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.additem.Location = new System.Drawing.Point(68, 40);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(115, 45);
            this.additem.TabIndex = 0;
            this.additem.Text = "Add Item";
            this.additem.UseVisualStyleBackColor = false;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // take_order
            // 
            this.take_order.BackColor = System.Drawing.Color.MintCream;
            this.take_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.take_order.Location = new System.Drawing.Point(68, 120);
            this.take_order.Name = "take_order";
            this.take_order.Size = new System.Drawing.Size(115, 41);
            this.take_order.TabIndex = 1;
            this.take_order.Text = "Take Order";
            this.take_order.UseVisualStyleBackColor = false;
            this.take_order.Click += new System.EventHandler(this.take_order_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 299);
            this.Controls.Add(this.take_order);
            this.Controls.Add(this.additem);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.Button take_order;
    }
}