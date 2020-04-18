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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mb = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Price_Tag = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm.Location = new System.Drawing.Point(67, 95);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(68, 20);
            this.nm.TabIndex = 1;
            this.nm.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.name_validate);
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb.Location = new System.Drawing.Point(67, 148);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(96, 20);
            this.mb.TabIndex = 3;
            this.mb.Text = "Mobile no : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.phoneno_validate);
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
            this.button.AutoSize = true;
            this.button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(169, 246);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 46);
            this.button.TabIndex = 6;
            this.button.Text = "Print Receipt";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 336);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}