using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Booking : Form
    {
        string sqlConnecion =
      "Data Source=.;Initial Catalog=Bank Management System;Integrated Security=True";
        SqlDataAdapter sdad,sdad2, sdad3;

        DataTable dt,dt2,dt3;
        SqlConnection conn;
        public Booking()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int  selectedCustomerId= (int)comboBox1.SelectedValue;
            int  selectedOperationId= (int)comboBox2.SelectedValue;
            int Amount = (int)numericUpDown1.Value;
            if (Amount == 0)
            {
                MessageBox.Show("Period Can't Be Zero");
            }
            else
            {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = sqlConnecion;
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
                if (selectedOperationId == 1)
                {
                      cmd.CommandText =
                $"Insert Into DepositOperations (OperationId,CustomerId,Amount) Values ('{selectedOperationId}','{selectedCustomerId}','{Amount}')";
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Deposit Done Successfully");
            }
            connection.Close();
            } 
                
                else
                {
                cmd.CommandText =
         $"Insert Into LoanOperations (OperationId,CustomerId,Amount) Values ('{selectedOperationId}','{selectedCustomerId}','{Amount}')";
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Loan Done Successfully");
                }
                connection.Close();
            }
        }
                     
        }

        private void Booking_Load(object sender, EventArgs e)
        {
           sdad = new SqlDataAdapter("Select Id,Type from Operations", sqlConnecion);
           sdad2 = new SqlDataAdapter("Select Id,CustomerName from Customers", sqlConnecion); 
            dt = new DataTable();
            dt2 = new DataTable();
            sdad.Fill(dt2);
            sdad2.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "CustomerName";
            comboBox2.DataSource = dt2;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Type";
            int selectedRoomId = (int)comboBox1.SelectedValue;
            int selectedCustomerId = (int)comboBox2.SelectedValue;
        }
    }
}
