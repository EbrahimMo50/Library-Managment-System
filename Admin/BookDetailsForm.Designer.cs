﻿namespace Phase_2_DB.Admin
{
    partial class BookDetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 32);
            label2.TabIndex = 1;
            label2.Text = "Null";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 109);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 3;
            label3.Text = "Null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 109);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 2;
            label4.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(205, 165);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 5;
            label5.Text = "Null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 165);
            label6.Name = "label6";
            label6.Size = new Size(137, 32);
            label6.TabIndex = 4;
            label6.Text = "Publication:";
            // 
            // button1
            // 
            button1.Location = new Point(44, 276);
            button1.Name = "button1";
            button1.Size = new Size(90, 69);
            button1.TabIndex = 6;
            button1.Text = "Show authors";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 276);
            button2.Name = "button2";
            button2.Size = new Size(90, 69);
            button2.TabIndex = 7;
            button2.Text = "Add author";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(335, 388);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDetails";
            FormClosing += BookDetailsForm_FormClosing;
            Load += BookDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}