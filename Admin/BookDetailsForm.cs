using Phase_2_DB.Models;
using System.Data.SqlClient;

namespace Phase_2_DB.Admin
{
    public partial class BookDetailsForm : Form
    {
        Book BookObj;
        public static bool AddAuthorFormOpened = false;
        public BookDetailsForm(Book BookObj)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            label2.Text = BookObj.ISBN.ToString();
            label3.Text = BookObj.Title.ToString();
            label5.Text = BookObj.PublicationDate.ToString();
            this.BookObj = BookObj;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryArrSize = "SELECT COUNT(*) FROM Author WHERE ID IN(SELECT AuthorID FROM Contain WHERE bookISBN = @isbn)";
                string sqlQuery = "SELECT * FROM Author WHERE ID IN(SELECT AuthorID FROM Contain WHERE bookISBN = @isbn)";

                conn.Open();

                SqlCommand SizeCommand = new SqlCommand(sqlQueryArrSize, conn);
                SizeCommand.Parameters.AddWithValue("isbn", BookObj.ISBN);

                Author[] Authors = new Author[(int)SizeCommand.ExecuteScalar()];

                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("isbn", BookObj.ISBN);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; reader.Read(); ++i)
                    {
                        Authors[i] = new Author((int)reader[0], reader[1].ToString());
                    }
                }
                conn.Close();

                Form AuthorsForm = new BookAuthorsForm(Authors);
                AuthorsForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in displaying authors for book\n" + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!AddAuthorFormOpened)
            {
                Form AddAuthor = new AddAuthorForm(BookObj);
                AddAuthor.Show();
                AddAuthorFormOpened = true;
            }
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void BookDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminBookViewForm.ShowBookDetailsOpened = false;
        }
    }
}
