
using System.Data.SqlClient;

namespace NoteTakingWindowsForms
{
    public partial class InsertNote : Form
    {

        public InsertNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Data Base in order to Save Data
        /// </summary>
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\NoteAppDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("Insert into NoteTable values('" + IDTextBox.Text + "', '" + TitleTextBox.Text + "', '" + TextTextBox.Text + "')", Con);//,'" + NoteDate.Text + "'
                cmd.ExecuteNonQuery();
                MessageBox.Show("Note Added");

                Con.Close();
            }
            catch { }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = string.Empty;
            TitleTextBox.Text = string.Empty;
            TextTextBox.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }


}
