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
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CustomerrTable values('" + CustomerIDTextBox.Text + "', '" + CustomerNameTextBox.Text + "', '" + CustomerPhoneTextBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception ex) { }

        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustomerPhoneTextBox.Text == null)
            {
                MessageBox.Show("Please Enter Cstomer Phone number");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CustomerrTable where CustomerID='" + CustomerIDTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully deleted");
                Con.Close();
                Populate();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerrTable set CustomerName='" + CustomerNameTextBox.Text + "',CustomerPhone='" + CustomerPhoneTextBox.Text + "'where CustomerID='" + CustomerIDTextBox.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex) { }
        }

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CustomerIDTextBox.Text = CustomerGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                CustomerNameTextBox.Text = CustomerGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                CustomerPhoneTextBox.Text = CustomerGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                Con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select Count(*) from OrderTable where CustomerID = " + CustomerIDTextBox.Text + "", Con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                OrdersLabel.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter adapter1 = new SqlDataAdapter("select Sum(TotalAmount) from OrderTable where CustomerID = " + CustomerIDTextBox.Text + "", Con);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                AmountLabel.Text = dt1.Rows[0][0].ToString();

                SqlDataAdapter adapter2 = new SqlDataAdapter("select Max(OrderDate) from OrderTable where CustomerID = " + CustomerIDTextBox.Text + "", Con);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                DateLabel.Text = dt2.Rows[0][0].ToString();

                Con.Close();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
