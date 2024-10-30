using Phase_2_DB.Models;

namespace Phase_2_DB.Admin
{
    public partial class AuthorManagerForm : Form
    {
        Author[] AuthorArr;
        bool IsLoggingOut = false;

        public AuthorManagerForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            AuthorArr = Author.GetAuthors();
            DisplayAuthors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Author.CreateAuthor(textBox1.Text))
                {
                    MessageBox.Show("Author added successfully");
                    textBox1.Clear();
                    UpdateAuthors();
                }
            }

        }

        private void UpdateAuthors()
        {
            AuthorArr = Author.GetAuthors();
            DisplayAuthors();
        }

        private void DisplayAuthors()
        {
            listBox1.Items.Clear();
            foreach (Author author in AuthorArr)
            {
                listBox1.Items.Add(author.Name);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form BookForm = new AdminBookViewForm();
            BookForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int SelectedItemIndex = listBox1.SelectedIndex;
                Author.DeleteAuthor(AuthorArr[SelectedItemIndex]);
                UpdateAuthors();
                //MessageBox.Show("You selected: " + selectedItem.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form StudentManagerForm = new StudentManagerForm();
            StudentManagerForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsLoggingOut = true;
            Person.LogOut(this);
        }

        private void AuthorManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggingOut)
                System.Environment.Exit(0);
        }

        private void AuthorManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
