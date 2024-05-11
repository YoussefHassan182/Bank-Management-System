using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        string sqlConnecion =
      "Data Source=.;Initial Catalog=Bank Management System;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUserName.Text.ToString();
            string Password = textBoxPassword.Text.ToString();
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                DialogResult message = MessageBox.Show("User Name Or Password Can't Be Empty");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = sqlConnecion;
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    $"Select * From UserTable where UserName = '{UserName}' And Password = '{Password}'";
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Home h = new Home();
                        h.Show();  
                        this.Hide();
                    }
                }    
                connection.Close();  
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
