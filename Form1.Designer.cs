namespace Phase_2_DB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            EmailField = new TextBox();
            Clearbtn = new Button();
            label3 = new Label();
            Registerbtn = new Button();
            Submitbtn = new Button();
            PasswordField = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 165);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 224);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // EmailField
            // 
            EmailField.Location = new Point(181, 162);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(165, 23);
            EmailField.TabIndex = 1;
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(100, 345);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(75, 33);
            Clearbtn.TabIndex = 4;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(126, 61);
            label3.Name = "label3";
            label3.Size = new Size(265, 38);
            label3.TabIndex = 5;
            label3.Text = "Welcome to Library ";
            label3.Click += label3_Click;
            // 
            // Registerbtn
            // 
            Registerbtn.Location = new Point(351, 345);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(75, 33);
            Registerbtn.TabIndex = 6;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // Submitbtn
            // 
            Submitbtn.Location = new Point(223, 282);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(75, 23);
            Submitbtn.TabIndex = 3;
            Submitbtn.Text = "Login";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // PasswordField
            // 
            PasswordField.Location = new Point(181, 224);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(165, 23);
            PasswordField.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(504, 441);
            Controls.Add(PasswordField);
            Controls.Add(Submitbtn);
            Controls.Add(Registerbtn);
            Controls.Add(label3);
            Controls.Add(Clearbtn);
            Controls.Add(EmailField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EmailField;
        private Button Clearbtn;
        private Label label3;
        private Button Registerbtn;
        private Button Submitbtn;
        private TextBox PasswordField;
    }
}