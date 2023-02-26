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
    public partial class CustomerFindForm : Form
    {
        public CustomerFindForm()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 customerForm = new Form1();
            customerForm.Show();
        }

        private void btnAddTransactio_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }
    }
}
