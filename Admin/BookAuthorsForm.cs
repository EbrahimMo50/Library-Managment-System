using Phase_2_DB.Models;


namespace Phase_2_DB.Admin
{
    public partial class BookAuthorsForm : Form
    {
        public BookAuthorsForm(Author[] Authors)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            AddAuthors(Authors);
        }
        private void AddAuthors(Author[] Authors)
        {
            foreach (Author author in Authors)
            {
                listBox1.Items.Add(author.Name);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookAuthorsForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
