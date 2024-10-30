using Phase_2_DB.Models;
using System.Data.SqlClient;


namespace Phase_2_DB.Admin
{
    public partial class AddAuthorForm : Form
    {
        Author[] AuthorArr;
        Book CurrentBook;
        public AddAuthorForm(Book CurrentBook)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            this.CurrentBook = CurrentBook;
            IntializeListBox();
        }

        private void IntializeListBox()
        {
            listBox1.Items.Clear();

            try
            {

                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQuery = "SELECT * FROM Author WHERE Author.ID NOT IN(SELECT AuthorID FROM Contain WHERE bookISBN = @isbn);";

                string ArrSize = "SELECT COUNT(*) FROM Author WHERE Author.ID NOT IN(SELECT AuthorID FROM Contain WHERE bookISBN = @isbn);";

                conn.Open();
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                SqlCommand commandForSize = new SqlCommand(ArrSize, conn);

                commandForSize.Parameters.AddWithValue("isbn", CurrentBook.ISBN);
                command.Parameters.AddWithValue("isbn", CurrentBook.ISBN);

                int counter = 0;

                AuthorArr = new Author[(int)commandForSize.ExecuteScalar()];

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Author obj = new Author((int)reader[0], reader[1].ToString());
                        AuthorArr[counter] = obj;
                        counter++;
                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in instializing authors\n" + ex.Message);
            }

            foreach (Author author in AuthorArr)
            {
                listBox1.Items.Add(author.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {

                    SqlConnection conn = new SqlConnection(Program.connString);
                    conn.Open();
                    string sqlQuery = "INSERT INTO Contain VALUES(@isbn,@authorID)";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);

                    command.Parameters.AddWithValue("@isbn", CurrentBook.ISBN);
                    command.Parameters.AddWithValue("@authorID", AuthorArr[listBox1.SelectedIndex].ID);

                    command.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("added " + listBox1.SelectedItem + " to " + CurrentBook.ISBN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in rendring authors\n" + ex.Message);
                }
                IntializeListBox();
            }
        }

        private void AddAuthorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BookDetailsForm.AddAuthorFormOpened = false;
        }

        private void AddAuthorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
