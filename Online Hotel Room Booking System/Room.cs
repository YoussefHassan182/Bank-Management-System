using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Room : Form
    {
        string sqlConnecion =
      "Data Source=.;Initial Catalog=Bank Management System;Integrated Security=True";
        SqlDataAdapter sdad;
        DataTable dt;
        SqlConnection conn;
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            ShowDataRooms();
        }
        public void ShowDataRooms()
        {
            sdad = new SqlDataAdapter("select * from Rooms Where IsAvailable = 'True'", sqlConnecion);
            dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
