namespace NoteTakingWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewNotesButton_Click(object sender, EventArgs e)
        {
            ViewNote viewNote = new ViewNote();
            viewNote.Show();
            this.Hide();
        }

        private void InsertANoteButton_Click(object sender, EventArgs e)
        {
            InsertNote insertNote = new InsertNote();
            insertNote.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}