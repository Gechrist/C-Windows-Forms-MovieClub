namespace WindowsForms_html
{
    partial class AddRental
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AdRenlbl2 = new System.Windows.Forms.Label();
            this.AdRenlbl3 = new System.Windows.Forms.Label();
            this.AdRenNum = new System.Windows.Forms.NumericUpDown();
            this.AdRenlbl4 = new System.Windows.Forms.Label();
            this.AdRenBtn = new System.Windows.Forms.Button();
            this.AdRelbl3 = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdRenNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AdRenlbl2
            // 
            this.AdRenlbl2.AutoSize = true;
            this.AdRenlbl2.Location = new System.Drawing.Point(120, 51);
            this.AdRenlbl2.Name = "AdRenlbl2";
            this.AdRenlbl2.Size = new System.Drawing.Size(35, 13);
            this.AdRenlbl2.TabIndex = 4;
            this.AdRenlbl2.Text = "Name";
            // 
            // AdRenlbl3
            // 
            this.AdRenlbl3.AutoSize = true;
            this.AdRenlbl3.Location = new System.Drawing.Point(380, 51);
            this.AdRenlbl3.Name = "AdRenlbl3";
            this.AdRenlbl3.Size = new System.Drawing.Size(36, 13);
            this.AdRenlbl3.TabIndex = 5;
            this.AdRenlbl3.Text = "Movie";
            // 
            // AdRenNum
            // 
            this.AdRenNum.Location = new System.Drawing.Point(512, 69);
            this.AdRenNum.Name = "AdRenNum";
            this.AdRenNum.Size = new System.Drawing.Size(71, 20);
            this.AdRenNum.TabIndex = 6;
            this.AdRenNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // AdRenlbl4
            // 
            this.AdRenlbl4.AutoSize = true;
            this.AdRenlbl4.Location = new System.Drawing.Point(527, 52);
            this.AdRenlbl4.Name = "AdRenlbl4";
            this.AdRenlbl4.Size = new System.Drawing.Size(31, 13);
            this.AdRenlbl4.TabIndex = 7;
            this.AdRenlbl4.Text = "Days";
            // 
            // AdRenBtn
            // 
            this.AdRenBtn.Location = new System.Drawing.Point(337, 168);
            this.AdRenBtn.Name = "AdRenBtn";
            this.AdRenBtn.Size = new System.Drawing.Size(146, 23);
            this.AdRenBtn.TabIndex = 8;
            this.AdRenBtn.Text = "Submit";
            this.AdRenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AdRenBtn.UseMnemonic = false;
            this.AdRenBtn.UseVisualStyleBackColor = true;
            this.AdRenBtn.Click += new System.EventHandler(this.AdRenBtn_Click);
            // 
            // AdRelbl3
            // 
            this.AdRelbl3.AutoSize = true;
            this.AdRelbl3.Location = new System.Drawing.Point(686, 51);
            this.AdRelbl3.Name = "AdRelbl3";
            this.AdRelbl3.Size = new System.Drawing.Size(43, 13);
            this.AdRelbl3.TabIndex = 10;
            this.AdRelbl3.Text = "Amount";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WindowsForms_html.Models.Client);
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(642, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(128, 20);
            this.comboBox3.TabIndex = 11;
            // 
            // AddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.AdRelbl3);
            this.Controls.Add(this.AdRenBtn);
            this.Controls.Add(this.AdRenlbl4);
            this.Controls.Add(this.AdRenNum);
            this.Controls.Add(this.AdRenlbl3);
            this.Controls.Add(this.AdRenlbl2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddRental";
            this.Text = "Add Rental";
            ((System.ComponentModel.ISupportInitialize)(this.AdRenNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label AdRenlbl2;
        private System.Windows.Forms.Label AdRenlbl3;
        private System.Windows.Forms.NumericUpDown AdRenNum;
        private System.Windows.Forms.Label AdRenlbl4;
        private System.Windows.Forms.Button AdRenBtn;
        private System.Windows.Forms.Label AdRelbl3;
        private System.Windows.Forms.TextBox comboBox3;
    }
}