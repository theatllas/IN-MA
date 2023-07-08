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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            PopulateOrders();
        }

        void PopulateOrders()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from OrderTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                OrderGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
