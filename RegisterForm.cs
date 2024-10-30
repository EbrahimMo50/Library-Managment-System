using Phase_2_DB.Models;

namespace Phase_2_DB
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Person.Register(FnameField.Text, LnameField.Text, EmailFieldReg.Text, PassFieldReg.Text, checkBox1.Checked);
            ClearRegForm();

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            this.Hide();
            LoginForm.Show();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ClearRegForm();
        }

        private void ClearRegForm()
        {
            FnameField.Clear();
            LnameField.Clear();
            EmailFieldReg.Clear();
            PassFieldReg.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
