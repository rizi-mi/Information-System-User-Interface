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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSTDataSet1);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSTDataSet1.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.iSTDataSet1.Orders);

        }

        private void costLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
