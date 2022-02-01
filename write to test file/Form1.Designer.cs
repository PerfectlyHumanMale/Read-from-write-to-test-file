namespace write_to_test_file
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Write_Text = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit_Text = new System.Windows.Forms.Button();
            this.Delete_Text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Write_Text
            // 
            this.Write_Text.Location = new System.Drawing.Point(173, 12);
            this.Write_Text.Name = "Write_Text";
            this.Write_Text.Size = new System.Drawing.Size(62, 20);
            this.Write_Text.TabIndex = 1;
            this.Write_Text.Text = "Write";
            this.Write_Text.UseVisualStyleBackColor = true;
            this.Write_Text.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Write Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Find Line";
            // 
            // Edit_Text
            // 
            this.Edit_Text.Location = new System.Drawing.Point(50, 64);
            this.Edit_Text.Name = "Edit_Text";
            this.Edit_Text.Size = new System.Drawing.Size(62, 20);
            this.Edit_Text.TabIndex = 6;
            this.Edit_Text.Text = "Edit Text";
            this.Edit_Text.UseVisualStyleBackColor = true;
            this.Edit_Text.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete_Text
            // 
            this.Delete_Text.Location = new System.Drawing.Point(118, 64);
            this.Delete_Text.Name = "Delete_Text";
            this.Delete_Text.Size = new System.Drawing.Size(72, 20);
            this.Delete_Text.TabIndex = 7;
            this.Delete_Text.Text = "Delete Text";
            this.Delete_Text.UseVisualStyleBackColor = true;
            this.Delete_Text.Click += new System.EventHandler(this.Delete_Text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 87);
            this.Controls.Add(this.Delete_Text);
            this.Controls.Add(this.Edit_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Write_Text);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Write_Text;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Edit_Text;
        private System.Windows.Forms.Button Delete_Text;
    }
}

