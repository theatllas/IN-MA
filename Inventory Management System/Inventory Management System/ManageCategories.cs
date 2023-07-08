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


namespace Inventory_Management_System
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void Populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CategoryTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                CategoryGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void CategoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoryGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CategoryIDTextBox.Text = CategoryGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CategoryNameTextBox.Text = CategoryGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CategoryTable values('" + CategoryIDTextBox.Text + "','" + CategoryNameTextBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully added");
                Con.Close();
                Populate();
            }
            catch (Exception ex) { }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTable set CategoryName='" + CategoryNameTextBox.Text + "'where CategoryID='" + CategoryIDTextBox.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Successfully updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex) { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CategoryIDTextBox.Text == null)
            {
                MessageBox.Show("Please Enter Category ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CategoryTable where CategoryID='" + CategoryIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully deleted");
                Con.Close();
                Populate();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
