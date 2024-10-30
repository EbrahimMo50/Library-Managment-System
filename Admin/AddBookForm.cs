using Phase_2_DB.Models;

namespace Phase_2_DB.Admin
{
    public partial class AddBookForm : Form
    {
        AdminBookViewForm form;
        public AddBookForm(AdminBookViewForm form)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            this.form = form;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Book.AddBook(textBox1.Text, textBox2.Text))
            {
                form.Call();
            }
            if (Copy.SetCopies(new Book(0, textBox1.Text, textBox2.Text), Int32.Parse(textBox3.Text)))
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminBookViewForm.AddBookFormOpened = false;
        }
    }
}
