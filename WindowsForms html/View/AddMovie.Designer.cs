namespace WindowsForms_html
{
    partial class AddMovie
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
            this.AdMobtn1 = new System.Windows.Forms.Button();
            this.AdCltxtbox4 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox3 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox2 = new System.Windows.Forms.TextBox();
            this.AdCltxtbox1 = new System.Windows.Forms.TextBox();
            this.AdMolbl4 = new System.Windows.Forms.Label();
            this.AdMolbl3 = new System.Windows.Forms.Label();
            this.AdMolbl2 = new System.Windows.Forms.Label();
            this.AdMolbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdMobtn1
            // 
            this.AdMobtn1.Location = new System.Drawing.Point(237, 223);
            this.AdMobtn1.Name = "AdMobtn1";
            this.AdMobtn1.Size = new System.Drawing.Size(317, 23);
            this.AdMobtn1.TabIndex = 17;
            this.AdMobtn1.Text = "Submit";
            this.AdMobtn1.UseVisualStyleBackColor = true;
            this.AdMobtn1.Click += new System.EventHandler(this.AdMobtn1_Click);
            // 
            // AdCltxtbox4
            // 
            this.AdCltxtbox4.Location = new System.Drawing.Point(390, 150);
            this.AdCltxtbox4.Name = "AdCltxtbox4";
            this.AdCltxtbox4.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox4.TabIndex = 16;
            // 
            // AdCltxtbox3
            // 
            this.AdCltxtbox3.Location = new System.Drawing.Point(390, 118);
            this.AdCltxtbox3.Name = "AdCltxtbox3";
            this.AdCltxtbox3.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox3.TabIndex = 15;
            // 
            // AdCltxtbox2
            // 
            this.AdCltxtbox2.Location = new System.Drawing.Point(390, 87);
            this.AdCltxtbox2.Name = "AdCltxtbox2";
            this.AdCltxtbox2.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox2.TabIndex = 14;
            // 
            // AdCltxtbox1
            // 
            this.AdCltxtbox1.Location = new System.Drawing.Point(390, 53);
            this.AdCltxtbox1.Name = "AdCltxtbox1";
            this.AdCltxtbox1.Size = new System.Drawing.Size(164, 20);
            this.AdCltxtbox1.TabIndex = 13;
            // 
            // AdMolbl4
            // 
            this.AdMolbl4.AutoSize = true;
            this.AdMolbl4.Location = new System.Drawing.Point(234, 150);
            this.AdMolbl4.Name = "AdMolbl4";
            this.AdMolbl4.Size = new System.Drawing.Size(31, 13);
            this.AdMolbl4.TabIndex = 12;
            this.AdMolbl4.Text = "Price";
            // 
            // AdMolbl3
            // 
            this.AdMolbl3.AutoSize = true;
            this.AdMolbl3.Location = new System.Drawing.Point(234, 118);
            this.AdMolbl3.Name = "AdMolbl3";
            this.AdMolbl3.Size = new System.Drawing.Size(47, 13);
            this.AdMolbl3.TabIndex = 11;
            this.AdMolbl3.Text = "Duration";
            // 
            // AdMolbl2
            // 
            this.AdMolbl2.AutoSize = true;
            this.AdMolbl2.Location = new System.Drawing.Point(234, 87);
            this.AdMolbl2.Name = "AdMolbl2";
            this.AdMolbl2.Size = new System.Drawing.Size(36, 13);
            this.AdMolbl2.TabIndex = 10;
            this.AdMolbl2.Text = "Genre";
            // 
            // AdMolbl1
            // 
            this.AdMolbl1.AutoSize = true;
            this.AdMolbl1.Location = new System.Drawing.Point(234, 52);
            this.AdMolbl1.Name = "AdMolbl1";
            this.AdMolbl1.Size = new System.Drawing.Size(27, 13);
            this.AdMolbl1.TabIndex = 9;
            this.AdMolbl1.Text = "Title";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdMobtn1);
            this.Controls.Add(this.AdCltxtbox4);
            this.Controls.Add(this.AdCltxtbox3);
            this.Controls.Add(this.AdCltxtbox2);
            this.Controls.Add(this.AdCltxtbox1);
            this.Controls.Add(this.AdMolbl4);
            this.Controls.Add(this.AdMolbl3);
            this.Controls.Add(this.AdMolbl2);
            this.Controls.Add(this.AdMolbl1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdMobtn1;
        private System.Windows.Forms.TextBox AdCltxtbox4;
        private System.Windows.Forms.TextBox AdCltxtbox3;
        private System.Windows.Forms.TextBox AdCltxtbox2;
        private System.Windows.Forms.TextBox AdCltxtbox1;
        private System.Windows.Forms.Label AdMolbl4;
        private System.Windows.Forms.Label AdMolbl3;
        private System.Windows.Forms.Label AdMolbl2;
        private System.Windows.Forms.Label AdMolbl1;
    }
}