using Phase_2_DB.Models;
using System.Data.SqlClient;

namespace Phase_2_DB.Admin
{
    public partial class StudentManagerForm : Form
    {
        bool IsLoggingOut = false;
        public StudentManagerForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            IntializeList();
        }

        public void IntializeList()
        {
            try
            {

                SqlConnection conn = new SqlConnection(Program.connString);
                conn.Open();

                string SqlQuerySelect = "SELECT * FROM Person WHERE Role = 'student';";
                SqlCommand command = new SqlCommand(SqlQuerySelect, conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add
                            (
                            reader["ID"].ToString(),
                            reader["Fname"].ToString() + " " + reader["Lname"].ToString(),
                            reader["email"].ToString(),
                            reader["password"].ToString()
                            );
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students\n" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form BookManager = new AdminBookViewForm();
            BookManager.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AuthorManager = new AuthorManagerForm();
            AuthorManager.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Person.LogOut(this);
        }

        private void StudentManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggingOut)
                System.Environment.Exit(0);
        }

        private void StudentManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
