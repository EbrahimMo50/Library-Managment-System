using Phase_2_DB.Admin;
using Phase_2_DB.Models;
using Phase_2_DB.Student;

namespace Phase_2_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            EmailField.Text = string.Empty;
            PasswordField.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (Person.Login(EmailField.Text, PasswordField.Text))
            {
                if (Person.ActiveUser.Role == "admin")
                {
                    AdminBookViewForm form = new AdminBookViewForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    StudentBookViewForm form = new StudentBookViewForm();
                    form.Show();
                    this.Hide();
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}