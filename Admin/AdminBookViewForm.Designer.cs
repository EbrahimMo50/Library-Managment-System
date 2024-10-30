namespace Phase_2_DB.Admin
{
    partial class AdminBookViewForm
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            SearchBar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(705, 51);
            button1.Name = "button1";
            button1.Size = new Size(83, 61);
            button1.TabIndex = 0;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(705, 118);
            button2.Name = "button2";
            button2.Size = new Size(83, 61);
            button2.TabIndex = 1;
            button2.Text = "Show book details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(705, 185);
            button3.Name = "button3";
            button3.Size = new Size(83, 61);
            button3.TabIndex = 2;
            button3.Text = "Remove book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(705, 316);
            button4.Name = "button4";
            button4.Size = new Size(83, 61);
            button4.TabIndex = 3;
            button4.Text = "Update Publication Year";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(12, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(687, 346);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(12, 387);
            button5.Name = "button5";
            button5.Size = new Size(220, 60);
            button5.TabIndex = 5;
            button5.Text = "Author manager";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(479, 387);
            button6.Name = "button6";
            button6.Size = new Size(220, 60);
            button6.TabIndex = 6;
            button6.Text = "Student manager";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(91, 9);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(159, 23);
            SearchBar.TabIndex = 7;
            SearchBar.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(702, 267);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(94, 5);
            label2.TabIndex = 15;
            label2.Text = "------------------------------------------------------------------------------------------";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(705, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 16;
            // 
            // button7
            // 
            button7.Location = new Point(721, 4);
            button7.Name = "button7";
            button7.Size = new Size(75, 31);
            button7.TabIndex = 17;
            button7.Text = "LogOut";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // AdminBookViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchBar);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminBookViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminBookView";
            FormClosing += AdminBookViewForm_FormClosing;
            Load += AdminBookViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
        private Button button6;
        private TextBox SearchBar;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button7;
    }
}