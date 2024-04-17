namespace ProjectExamination.Forms
{
    partial class Form4
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Thistle;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(414, 110);
            label6.Name = "label6";
            label6.Size = new Size(25, 28);
            label6.TabIndex = 15;
            label6.Text = "is";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 14;
            label4.Text = "[His Name]";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(156, 110);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 13;
            label3.Text = "Your grade In  : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(309, 110);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 12;
            label2.Text = "[Subject]";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(458, 110);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 11;
            label1.Text = "[Grade]";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(626, 237);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 16;
            button1.Text = "End ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(224, 228);
            button2.Name = "button2";
            button2.Size = new Size(321, 50);
            button2.TabIndex = 17;
            button2.Text = "Do you Want to Take Another Exam ?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(126, 110);
            label5.Name = "label5";
            label5.Size = new Size(16, 28);
            label5.TabIndex = 18;
            label5.Text = ",";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Navy;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}