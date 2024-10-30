namespace Phase_2_DB.Student
{
    partial class StudentBookViewForm
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
            SearchBar = new TextBox();
            listBox1 = new ListBox();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 5);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 11;
            label1.Text = "Search";
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(119, 10);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(159, 23);
            SearchBar.TabIndex = 10;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(40, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(646, 346);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(240, 388);
            button5.Name = "button5";
            button5.Size = new Size(220, 60);
            button5.TabIndex = 12;
            button5.Text = "Borrow";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(692, 58);
            button1.Name = "button1";
            button1.Size = new Size(108, 60);
            button1.TabIndex = 13;
            button1.Text = "Borrowed books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(713, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 16;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StudentBookViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(SearchBar);
            Controls.Add(listBox1);
            Name = "StudentBookViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentBookView";
            FormClosing += StudentBookViewForm_FormClosing;
            Load += StudentBookViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchBar;
        private ListBox listBox1;
        private Button button5;
        private Button button1;
        private Button button3;
    }
}