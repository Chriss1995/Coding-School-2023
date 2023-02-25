using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelGasStation.WinForm
{
    public partial class StaffFormcs : Form
    {
        public StaffFormcs()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
        }
    }
}
