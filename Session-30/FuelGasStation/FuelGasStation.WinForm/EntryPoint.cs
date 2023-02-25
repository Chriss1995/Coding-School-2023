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
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierForm cashierForm = new CashierForm();
            cashierForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffFormcs cashierForm = new StaffFormcs();
            cashierForm.Show();
        }
    }
}
