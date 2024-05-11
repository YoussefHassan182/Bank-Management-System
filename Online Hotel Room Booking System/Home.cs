using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Hotel_Room_Booking_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
        }
    }
}
