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
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 customerForm = new Form1();
            customerForm.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }
    }
}
