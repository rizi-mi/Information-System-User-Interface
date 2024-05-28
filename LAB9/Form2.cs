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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSTDataSet1);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSTDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.iSTDataSet1.Users);

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
