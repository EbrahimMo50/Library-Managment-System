namespace Phase_2_DB.Student
{
    partial class BorrowedBooksForm
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
            button1 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(678, 56);
            button1.Name = "button1";
            button1.Size = new Size(122, 60);
            button1.TabIndex = 16;
            button1.Text = "Browse books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(242, 371);
            button5.Name = "button5";
            button5.Size = new Size(220, 60);
            button5.TabIndex = 15;
            button5.Text = "Return Copy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(26, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(646, 346);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(698, 19);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 17;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BorrowedBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Name = "BorrowedBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowedBooks";
            FormClosing += BorrowedBooksForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button5;
        private ListBox listBox1;
        private Button button3;
    }
}