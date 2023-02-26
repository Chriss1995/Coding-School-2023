using FuelGasStation.Blazor.Shared.Transaction;
using FuelGasStation.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelGasStation.WinForm
{
    public partial class TransactionForm : Form
    {
        List<TransactionLineListDto> transactionLine { get; set; }
        private readonly HttpClient client;
        List<TransactionListDto> transactions {get; set;}
        public TransactionForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFindForm customerFind = new CustomerFindForm();
           customerFind.Show();
        }

        private void btnAddTrsasLine_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
         
        }

    }
}
