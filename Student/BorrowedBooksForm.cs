using Phase_2_DB.Models;
using System.Data.SqlClient;

namespace Phase_2_DB.Student
{
    public partial class BorrowedBooksForm : Form
    {
        Copy[] BorrowedBooks;
        bool IsLoggingOut = false;
        public BorrowedBooksForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            listBox1.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(Program.connString);

                string LoadQuery = "SELECT * FROM Copy WHERE OwnerID = @owner";
                SqlCommand command = new SqlCommand(LoadQuery, conn);

                string LoadSize = "SELECT COUNT(*) FROM Copy WHERE OwnerID = @owner";
                SqlCommand command1 = new SqlCommand(LoadSize, conn);
                command1.Parameters.AddWithValue("owner", Person.ActiveUser.ID);

                conn.Open();
                int size = (int)command1.ExecuteScalar();
                BorrowedBooks = new Copy[size];

                command.Parameters.AddWithValue("owner", Person.ActiveUser.ID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; reader.Read(); i++)
                    {
                        Copy obj = new Copy(
                            (int)reader["ID"],
                            (int)reader["bookISBN"],
                            (bool)reader["IsAvailable"],
                            reader["BorrowedDate"].ToString(),
                            reader["ReturnDate"].ToString(),
                            (int)reader["OwnerID"]
                            );
                        BorrowedBooks[i] = obj;

                    }
                }

                for (int i = 0; size > i; ++i)
                {
                    string LoadBookName = "SELECT Title FROM Book WHERE ISBN = @isbn";
                    command = new SqlCommand(LoadBookName, conn);
                    command.Parameters.AddWithValue("isbn", BorrowedBooks[i].BookISBN);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            listBox1.Items.Add(reader[0].ToString() + "\t\t" + BorrowedBooks[i].ReturnDate);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Loading Borrowed Books\n" + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form StudentBookView = new StudentBookViewForm();
            this.Hide();
            StudentBookView.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                if (Copy.ReturnCopy(BorrowedBooks[listBox1.SelectedIndex]));
                    MessageBox.Show("success");
            }
            LoadBorrowedBooks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Person.LogOut(this);
        }

        private void BorrowedBooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggingOut)
                System.Environment.Exit(0);
        }
    }
}
