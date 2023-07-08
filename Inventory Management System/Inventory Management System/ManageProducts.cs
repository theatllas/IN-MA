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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ProductIDTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ProductNameTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                ProductQuantityTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                ProductPriceTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                DiscriptionTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                CategoryComboBox.SelectedValue = ProductGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void Populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                ProductGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
        }

        void FilterByCategory()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTable where ProductCategory = '" + SearchComboBox.SelectedValue.ToString() + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                ProductGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FillCategory()
        {
            string query = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader;
            try
            {
                Con.Open();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CategoryName", typeof(string));
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                CategoryComboBox.ValueMember = "CategoryName";
                CategoryComboBox.DataSource = dataTable;
                SearchComboBox.ValueMember = "CategoryName";
                SearchComboBox.DataSource = dataTable;
                Con.Close();
            }
            catch (Exception ex) { }
        }



        private void ManageProducts_Load(object sender, EventArgs e)
        {
            FillCategory();
            Populate();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into ProductTable values('" + ProductIDTextBox.Text + "', '" + ProductNameTextBox.Text + "', '" + ProductQuantityTextBox.Text + "', '" + ProductPriceTextBox.Text + "','" + DiscriptionTextBox.Text + "','" + CategoryComboBox.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception ex) { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductIDTextBox.Text == null)
            {
                MessageBox.Show("Please Enter Product ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from ProductTable where ProductID='" + ProductIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully deleted");
                Con.Close();
                Populate();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTable set ProductName='" + ProductNameTextBox.Text + "',ProductQuantity='" + ProductQuantityTextBox.Text + "',ProductPrice = '" + ProductPriceTextBox.Text + "',ProductDiscription = '" + DiscriptionTextBox.Text + "',ProductCategory = '" + CategoryComboBox.SelectedValue.ToString() + "' where ProductID=" + ProductIDTextBox.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex) { }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
