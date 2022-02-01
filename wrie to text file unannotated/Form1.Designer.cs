namespace wrie_to_text_file_unannotated
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
            this.Delete_Text = new System.Windows.Forms.Button();
            this.Edit_Text = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Write_Text = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Delete_Text
            // 
            this.Delete_Text.Location = new System.Drawing.Point(125, 58);
            this.Delete_Text.Name = "Delete_Text";
            this.Delete_Text.Size = new System.Drawing.Size(72, 20);
            this.Delete_Text.TabIndex = 14;
            this.Delete_Text.Text = "Delete Text";
            this.Delete_Text.UseVisualStyleBackColor = true;
            this.Delete_Text.Click += new System.EventHandler(this.Delete_Text_Click);
            // 
            // Edit_Text
            // 
            this.Edit_Text.Location = new System.Drawing.Point(57, 58);
            this.Edit_Text.Name = "Edit_Text";
            this.Edit_Text.Size = new System.Drawing.Size(62, 20);
            this.Edit_Text.TabIndex = 13;
            this.Edit_Text.Text = "Edit Text";
            this.Edit_Text.UseVisualStyleBackColor = true;
            this.Edit_Text.Click += new System.EventHandler(this.Edit_Text_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Find Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Write Text";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // Write_Text
            // 
            this.Write_Text.Location = new System.Drawing.Point(180, 6);
            this.Write_Text.Name = "Write_Text";
            this.Write_Text.Size = new System.Drawing.Size(62, 20);
            this.Write_Text.TabIndex = 9;
            this.Write_Text.Text = "Write";
            this.Write_Text.UseVisualStyleBackColor = true;
            this.Write_Text.Click += new System.EventHandler(this.Write_Text_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
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

        private System.Windows.Forms.Button Delete_Text;
        private System.Windows.Forms.Button Edit_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Write_Text;
        private System.Windows.Forms.TextBox textBox1;
    }
}

