using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Registration : Form
    {
        string sqlConnecion =
      "Data Source=.;Initial Catalog=Bank Management System;Integrated Security=True";
        SqlDataAdapter sdad;
        DataTable dt;
        SqlConnection conn;
   
        public Registration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Hide();
            string CustomerName = textBoxCustName.Text.ToString();
            string CustomerPhoneNumber = textBoxPhoneNum.Text.ToString();
            string CustomerEmail = textBoxCustEmail.Text.ToString();
            string CustomerIdentityNumber = textBoxCustIdentityNo.Text.ToString();
            if (string.IsNullOrEmpty(CustomerName) ||
                string.IsNullOrEmpty(CustomerPhoneNumber) ||
                string.IsNullOrEmpty(CustomerEmail) ||
                string.IsNullOrEmpty(CustomerIdentityNumber))
            {
                MessageBox.Show("Empty Fields Not Allowed");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = sqlConnecion;
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    $"Insert Into Customers (CustomerName,CustomerPhoneNumber,CustomerEmail,CustomerIdentityNumber) Values ('{CustomerName}','{CustomerPhoneNumber}','{CustomerEmail}','{CustomerIdentityNumber}')";
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Customer Successfully Registered");
                    textBoxCustName.Text = "";
                    textBoxCustEmail.Text = "";
                    textBoxPhoneNum.Text = "";
                    textBoxCustIdentityNo.Text = "";
                }
                connection.Close();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //sdad = new SqlDataAdapter("SELECT Id FROM Rooms WHERE IsAvailable = 'True'", sqlConnecion);
            //DataTable dt = new DataTable();
            //sdad.Fill(dt);
            //comboBox1.DataSource = dt;
            //comboBox1.ValueMember = "Id";
            //comboBox1.Text = "Choose Room Number";
            //int selectedRoomId = (int)comboBox1.SelectedValue;
        }
    }
}
