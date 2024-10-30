namespace Phase_2_DB
{
    partial class RegisterForm
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
            Submitbtn = new Button();
            Loginbtn = new Button();
            label3 = new Label();
            Clearbtn = new Button();
            EmailFieldReg = new TextBox();
            LnameField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            FnameField = new TextBox();
            PassFieldReg = new TextBox();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // Submitbtn
            // 
            Submitbtn.Location = new Point(215, 300);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(75, 23);
            Submitbtn.TabIndex = 13;
            Submitbtn.Text = "Register";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(346, 346);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(75, 33);
            Loginbtn.TabIndex = 15;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Registerbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(121, 62);
            label3.Name = "label3";
            label3.Size = new Size(265, 38);
            label3.TabIndex = 13;
            label3.Text = "Welcome to Library ";
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(95, 346);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(75, 33);
            Clearbtn.TabIndex = 14;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // EmailFieldReg
            // 
            EmailFieldReg.Location = new Point(176, 192);
            EmailFieldReg.Name = "EmailFieldReg";
            EmailFieldReg.Size = new Size(165, 23);
            EmailFieldReg.TabIndex = 11;
            // 
            // LnameField
            // 
            LnameField.Location = new Point(176, 163);
            LnameField.Name = "LnameField";
            LnameField.Size = new Size(165, 23);
            LnameField.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 223);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 195);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // FnameField
            // 
            FnameField.Location = new Point(176, 134);
            FnameField.Name = "FnameField";
            FnameField.Size = new Size(165, 23);
            FnameField.TabIndex = 9;
            // 
            // PassFieldReg
            // 
            PassFieldReg.Location = new Point(176, 220);
            PassFieldReg.Name = "PassFieldReg";
            PassFieldReg.Size = new Size(165, 23);
            PassFieldReg.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 137);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 18;
            label4.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 166);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Last name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(134, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(319, 264);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Student";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(504, 441);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PassFieldReg);
            Controls.Add(FnameField);
            Controls.Add(Submitbtn);
            Controls.Add(Loginbtn);
            Controls.Add(label3);
            Controls.Add(Clearbtn);
            Controls.Add(EmailFieldReg);
            Controls.Add(LnameField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            FormClosing += RegisterForm_FormClosing;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submitbtn;
        private Button Loginbtn;
        private Label label3;
        private Button Clearbtn;
        private TextBox EmailFieldReg;
        private TextBox LnameField;
        private Label label2;
        private Label label1;
        private TextBox FnameField;
        private TextBox PassFieldReg;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}