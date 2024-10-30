namespace Phase_2_DB.Admin
{
    partial class AuthorManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorManagerForm));
            button6 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(326, 367);
            button6.Margin = new Padding(0, 5, 0, 5);
            button6.Name = "button6";
            button6.Size = new Size(217, 60);
            button6.TabIndex = 9;
            button6.Text = "Student manager";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(14, 367);
            button5.Margin = new Padding(0, 5, 0, 5);
            button5.Name = "button5";
            button5.Size = new Size(217, 60);
            button5.TabIndex = 8;
            button5.Text = "Book manager";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(14, 25);
            listBox1.Margin = new Padding(0, 5, 0, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(529, 308);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 113);
            textBox1.Margin = new Padding(0, 5, 0, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 93);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 11;
            label1.Text = "Author name";
            // 
            // button1
            // 
            button1.Location = new Point(626, 143);
            button1.Margin = new Padding(0, 5, 0, 5);
            button1.Name = "button1";
            button1.Size = new Size(133, 25);
            button1.TabIndex = 12;
            button1.Text = "Create Author";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(654, 226);
            button2.Margin = new Padding(0, 5, 0, 5);
            button2.Name = "button2";
            button2.Size = new Size(77, 55);
            button2.TabIndex = 13;
            button2.Text = "Delete Author";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(575, 203);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(244, 5);
            label2.TabIndex = 14;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(753, 25);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 15;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AuthorManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(840, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Margin = new Padding(0, 5, 0, 5);
            Name = "AuthorManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorManagerForm";
            FormClosing += AuthorManagerForm_FormClosing;
            Load += AuthorManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
    }
}