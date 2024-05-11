using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Customer : Form
    {
        string sqlConnecion =
      "Data Source=.;Initial Catalog=Bank Management System;Integrated Security=True";
        SqlDataAdapter sdad;
        DataTable dt;
        SqlConnection conn;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ShowDataCustomer();
        }
        public void ShowDataCustomer()
        {
            sdad = new SqlDataAdapter("select * from Customers", sqlConnecion);
            dt = new DataTable();
            sdad.Fill(dt);
            dataGridViewCustomers.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsSearchByName = radioButtonName.Checked;
            bool IsSearchById = radioButtonIdentity.Checked;
            bool IsSearchByPhoneNumber = radioButtonPhoneNumber.Checked;
            string Search = textBoxSearch.Text.ToString();
            if (IsSearchById)
            {
                sdad = new SqlDataAdapter($"select * from Customers Where CustomerIdentifyNumber = '{Search}'", sqlConnecion);
                dt = new DataTable();
                sdad.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (IsSearchByName)
            {
                sdad = new SqlDataAdapter($"select * from Customers Where CustomerName = '{Search}'", sqlConnecion);
                dt = new DataTable();
                sdad.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (IsSearchByPhoneNumber)
            {
                sdad = new SqlDataAdapter($"select * from Customers WhereCustomerPhoneNumber = '{Search}'", sqlConnecion);
                dt = new DataTable();
                sdad.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
