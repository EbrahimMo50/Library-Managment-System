using Phase_2_DB.Models;

namespace Phase_2_DB.Student
{
    public partial class StudentBookViewForm : Form
    {
        Book[] BookArr;
        bool IsLoggingOut = false;
        public StudentBookViewForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            LoadBooks(Book.GetBooks());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(Book.GetBooks(SearchBar.Text));
        }

        private void LoadBooks(Book[] BookArr)
        {
            listBox1.Items.Clear();
            if (BookArr != null)
                for (int i = 0; i < BookArr.Length; i++)
                {
                    listBox1.Items.Add(BookArr[i].Title + "\t\tPublication year:" + BookArr[i].PublicationDate);
                }
            this.BookArr = BookArr;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (Copy.BorrowBook(BookArr[listBox1.SelectedIndex]))
                {
                    MessageBox.Show("Succefully borrowed");
                }
                else
                {
                    MessageBox.Show("The book is unavilable you have been added to waiting list");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form BorrowedBooks = new BorrowedBooksForm();
            this.Hide();
            BorrowedBooks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Person.LogOut(this);
        }

        private void StudentBookViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggingOut)
                System.Environment.Exit(0);
        }

        private void StudentBookViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
