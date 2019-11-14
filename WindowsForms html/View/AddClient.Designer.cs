namespace WindowsForms_html
{
    partial class AddClient
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
            this.AdClbl1 = new System.Windows.Forms.Label();
            this.AdClbl2 = new System.Windows.Forms.Label();
            this.AdClbl3 = new System.Windows.Forms.Label();
            this.AdClbl4 = new System.Windows.Forms.Label();
            this.AdCltxtbox1 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox2 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox3 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox4 = new System.Windows.Forms.TextBox();
            this.AdClbtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdClbl1
            // 
            this.AdClbl1.AutoSize = true;
            this.AdClbl1.Location = new System.Drawing.Point(251, 42);
            this.AdClbl1.Name = "AdClbl1";
            this.AdClbl1.Size = new System.Drawing.Size(57, 13);
            this.AdClbl1.TabIndex = 0;
            this.AdClbl1.Text = "First Name";
            // 
            // AdClbl2
            // 
            this.AdClbl2.AutoSize = true;
            this.AdClbl2.Location = new System.Drawing.Point(251, 77);
            this.AdClbl2.Name = "AdClbl2";
            this.AdClbl2.Size = new System.Drawing.Size(58, 13);
            this.AdClbl2.TabIndex = 1;
            this.AdClbl2.Text = "Last Name";
            // 
            // AdClbl3
            // 
            this.AdClbl3.AutoSize = true;
            this.AdClbl3.Location = new System.Drawing.Point(251, 108);
            this.AdClbl3.Name = "AdClbl3";
            this.AdClbl3.Size = new System.Drawing.Size(32, 13);
            this.AdClbl3.TabIndex = 2;
            this.AdClbl3.Text = "Email";
            // 
            // AdClbl4
            // 
            this.AdClbl4.AutoSize = true;
            this.AdClbl4.Location = new System.Drawing.Point(251, 140);
            this.AdClbl4.Name = "AdClbl4";
            this.AdClbl4.Size = new System.Drawing.Size(22, 13);
            this.AdClbl4.TabIndex = 3;
            this.AdClbl4.Text = "Tel";
            // 
            // AdCltxtbox1
            // 
            this.AdCltxtbox1.Location = new System.Drawing.Point(407, 43);
            this.AdCltxtbox1.Name = "AdCltxtbox1";
            this.AdCltxtbox1.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox1.TabIndex = 4;
            // 
            // AdCltxtbox2
            // 
            this.AdCltxtbox2.Location = new System.Drawing.Point(407, 77);
            this.AdCltxtbox2.Name = "AdCltxtbox2";
            this.AdCltxtbox2.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox2.TabIndex = 5;
            // 
            // AdCltxtbox3
            // 
            this.AdCltxtbox3.Location = new System.Drawing.Point(407, 108);
            this.AdCltxtbox3.Name = "AdCltxtbox3";
            this.AdCltxtbox3.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox3.TabIndex = 6;
            // 
            // AdCltxtbox4
            // 
            this.AdCltxtbox4.Location = new System.Drawing.Point(407, 140);
            this.AdCltxtbox4.Name = "AdCltxtbox4";
            this.AdCltxtbox4.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox4.TabIndex = 7;
            // 
            // AdClbtn1
            // 
            this.AdClbtn1.Location = new System.Drawing.Point(254, 213);
            this.AdClbtn1.Name = "AdClbtn1";
            this.AdClbtn1.Size = new System.Drawing.Size(317, 23);
            this.AdClbtn1.TabIndex = 8;
            this.AdClbtn1.Text = "Submit";
            this.AdClbtn1.UseVisualStyleBackColor = true;
            this.AdClbtn1.Click += new System.EventHandler(this.AdClbtn1_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdClbtn1);
            this.Controls.Add(this.AdCltxtbox4);
            this.Controls.Add(this.AdCltxtbox3);
            this.Controls.Add(this.AdCltxtbox2);
            this.Controls.Add(this.AdCltxtbox1);
            this.Controls.Add(this.AdClbl4);
            this.Controls.Add(this.AdClbl3);
            this.Controls.Add(this.AdClbl2);
            this.Controls.Add(this.AdClbl1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdClbl1;
        private System.Windows.Forms.Label AdClbl2;
        private System.Windows.Forms.Label AdClbl3;
        private System.Windows.Forms.Label AdClbl4;
        private System.Windows.Forms.TextBox AdCltxtbox1;
        private System.Windows.Forms.TextBox AdCltxtbox2;
        private System.Windows.Forms.TextBox AdCltxtbox3;
        private System.Windows.Forms.TextBox AdCltxtbox4;
        private System.Windows.Forms.Button AdClbtn1;
    }
}