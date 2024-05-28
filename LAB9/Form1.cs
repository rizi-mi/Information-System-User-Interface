using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = new Users();
            users.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var products = new Products();
            products.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var orders = new Orders();
            orders.Visible = true;
        }
    }
}
