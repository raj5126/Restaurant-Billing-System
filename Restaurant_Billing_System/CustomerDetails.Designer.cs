namespace Restaurant_Billing_System
{
    partial class CustomerDetails
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
            this.title = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mb = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Price_Tag = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(62, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(161, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Customer Details";
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Location = new System.Drawing.Point(67, 95);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(57, 17);
            this.nm.TabIndex = 1;
            this.nm.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 2;
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Location = new System.Drawing.Point(67, 148);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(81, 17);
            this.mb.TabIndex = 3;
            this.mb.Text = "Mobile no : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Price_Tag
            // 
            this.Price_Tag.AutoSize = true;
            this.Price_Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Tag.Location = new System.Drawing.Point(70, 205);
            this.Price_Tag.Name = "Price_Tag";
            this.Price_Tag.Size = new System.Drawing.Size(0, 25);
            this.Price_Tag.TabIndex = 5;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(75, 295);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(111, 40);
            this.button.TabIndex = 6;
            this.button.Text = "Print Receipt";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Price_Tag);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.title);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Price_Tag;
        private System.Windows.Forms.Button button;
    }
}