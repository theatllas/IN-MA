using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingWindowsForms
{
    public partial class ViewNote : Form
    {
        public ViewNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Data Base in order to Save Data
        /// </summary>
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\NoteAppDB.mdf;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// To Load Previous Notes fromn the DataBase. Whenever this function is called our list will be updated
        /// </summary>
        void PopNote()
        {
            try
            {
                Con.Open();

                String myQuery = "select * from NoteTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                NotesGridView.DataSource = dataset.Tables[0];

                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void NotesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NotesGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                IDTextBox.Text = NotesGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                TitleTextBox.Text = NotesGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                TextTextBox.Text = NotesGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text == null)
            {
                MessageBox.Show("Please Enter Note ID");
            }
            else
            {
                Con.Open();

                string myQuery = "delete from NoteTable where Id='" + IDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Note deleted.");

                Con.Close();
                PopNote();
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewNote_Load(object sender, EventArgs e)
        {
            PopNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("update NoteTable set Title='" + TitleTextBox.Text + "', Text='" + TextTextBox.Text + "' where Id='" + IDTextBox.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Note Updated!");

                Con.Close();
                PopNote();

            }
            catch (Exception ex) { }

        }
    }
}
