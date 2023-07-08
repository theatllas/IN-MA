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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        int GetIndex()
        {
            string i = ProductGridView.SelectedRows[0].Cells[0].FormattedValue.ToString();
            int e = Convert.ToInt32(i);
            return e;
        }
        void UpdateProduct()
        {

            int id = GetIndex();
            int newQuantity = stock - Convert.ToInt32(QuantityTextBox.Text);
            if (newQuantity < 0)
            {
                MessageBox.Show("Operation Failed");
            }
            else
            {
                Con.Open();
                string query = "update ProductTable set ProductQuantity = " + newQuantity + " where ProductID = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                PopulateProducts();
            }

        }
        int num = 0;
        int uprice, totalPrice, quantity;
        string product;
        DataTable table = new DataTable();

        void Populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CustomerrTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                CustomerGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
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
                //CategoryComboBox.ValueMember = "CategoryName";
                //CategoryComboBox.DataSource = dataTable;
                SearchComboBox.ValueMember = "CategoryName";
                SearchComboBox.DataSource = dataTable;
                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            Populate();
            PopulateProducts();
            FillCategory();
            table.Columns.Add("Num", typeof(int)); //data type int
            table.Columns.Add("Product", typeof(string)); // data type string
            table.Columns.Add("Quantity", typeof(int)); // data type int
            table.Columns.Add("Uprice", typeof(int)); // data type int
            table.Columns.Add("TotalPrice", typeof(int)); // data type int

            OrderGridView.DataSource = table;
        }

        void PopulateProducts()
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

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CustomerIDTextBox.Text = CustomerGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CustomerNameTextBox.Text = CustomerGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //ProductQuantityTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                //ProductPriceTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //DiscriptionTextBox.Text = ProductGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                //CategoryComboBox.SelectedValue = ProductGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

            }
        }

        private void SearchComboBox_SelectionChangeCommitted(object sender, EventArgs e)
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

        int flag = 0;
        int stock;
        private void ProductGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                product = ProductGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //quantity = Convert.ToInt32(QuantityTextBox.Text);
                stock = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                uprice = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                //totalPrice = Quantity * uprice;
                flag = 1;
            }

        }

        int sum = 0;

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {



            if (QuantityTextBox.Text == "")
            {
                MessageBox.Show("Enter the Quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(QuantityTextBox.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock Available");
            }
            else
            {
                num = num + 1;
                quantity = Convert.ToInt32(QuantityTextBox.Text);
                totalPrice = quantity * uprice;
                table.Rows.Add(num, product, quantity, uprice, totalPrice);
                OrderGridView.DataSource = table;
                flag = 0;
            }
            sum = sum + totalPrice;
            TotalAmountLabel.Text = "Rs" + sum.ToString();
        }

        private void InsertOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderIDTextBox.Text == "" || CustomerIDTextBox.Text == "" || CustomerNameTextBox.Text == "" || TotalAmountLabel.Text == "")
            {
                MessageBox.Show("Fill the data correctly");
            }
            else
            {
                //try
                //{
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into OrderTable values('" + OrderIDTextBox.Text + "', '" + CustomerIDTextBox.Text + "','" + CustomerNameTextBox.Text + "' , '" + OrderDate.Text + "', '" + TotalAmountLabel.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully Added");
                Con.Close();
                //Populate();

                //}
                //catch (Exception ex) { }
            }
        }

        private void ViewOrdersButton_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
