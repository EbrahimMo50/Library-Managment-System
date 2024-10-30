using Phase_2_DB.Models;

namespace Phase_2_DB.Admin
{
    public partial class AdminBookViewForm : Form
    {
        Book[] BookArr;
        public static bool AddBookFormOpened = false;
        public static bool ShowBookDetailsOpened = false;
        bool IsLoggingOut = false;
        public AdminBookViewForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            if (Book.GetBooks() != null)
            {
                BookArr = Book.GetBooks();
                LoadBooks(BookArr);
            }

        }

        private void AdminBookViewForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!AddBookFormOpened)
            {
                Form AddBookForm = new AddBookForm(this);
                AddBookForm.Show();
                AddBookFormOpened = true;
            }

        }

        //my methods
        public void Call()
        {
            if (Book.GetBooks() != null)
            {
                BookArr = Book.GetBooks("");
                LoadBooks(BookArr);
            }
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
        //end of my methods

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ShowBookDetailsOpened)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int selectedItem = listBox1.SelectedIndex;
                    Form BookDetailsForm = new BookDetailsForm(BookArr[selectedItem]);
                    BookDetailsForm.Show();
                    ShowBookDetailsOpened = true;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int SelectedItemIndex = listBox1.SelectedIndex;
                Book.DeleteBook(BookArr[SelectedItemIndex]);
                Call();
                //MessageBox.Show("You selected: " + selectedItem.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AuthorForm = new AuthorManagerForm();
            AuthorForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(Book.GetBooks(SearchBar.Text));
            //MessageBox.Show(SearchBar.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedItem = listBox1.SelectedIndex;
                if (Book.UpdateBookDate(BookArr[selectedItem], Int32.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Update Successful");
                }
                Call();
            }
            else
            {
                MessageBox.Show("Please choose a proper book from the list");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form StudentForm = new StudentManagerForm();
            this.Hide();
            StudentForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Person.LogOut(this);
        }

        private void AdminBookViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsLoggingOut)
                System.Environment.Exit(0);
        }
    }
}
