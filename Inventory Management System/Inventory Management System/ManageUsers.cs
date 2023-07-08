
using System.Data;
using System.Data.SqlClient;
namespace Inventory_Management_System
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into UserTable values('" + UserNameTextBox.Text + "','" + FullNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + TelephoneTextBox.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception ex)
            {

            }
        }

        void Populate()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from UserTable";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                UsersGridView.DataSource = dataSet.Tables[0];
                Con.Close();
            }
            catch (Exception ex) { }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (TelephoneTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the User's phone number");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from UserTable where Uphone='" + TelephoneTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully deleted");
                Con.Close();
                Populate();
            }
        }


        private void UsersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                UserNameTextBox.Text = UsersGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                FullNameTextBox.Text = UsersGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                PasswordTextBox.Text = UsersGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                TelephoneTextBox.Text = UsersGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set Uname='" + UserNameTextBox.Text + "',Ufullname='" + FullNameTextBox.Text + "',Upassword='" + PasswordTextBox.Text + "'where Uphone='" + TelephoneTextBox.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                Populate();

            }
            catch (Exception ex)
            {

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
