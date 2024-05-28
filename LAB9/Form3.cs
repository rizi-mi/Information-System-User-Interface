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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iSTDataSet1);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iSTDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.iSTDataSet1.Products);

        }
    }
}
