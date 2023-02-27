using FuelGasStation.Model;
using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelGasStation.WinForm
{
    public partial class TransForm : Form
    {
        List<ItemListDto> Items { get; set; }
        private readonly HttpClient client;
        List<TransactionLineListDto> TransactionLines { get; set; }
        public TransForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void TransForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
        }
        private async Task SetControlProperties()
        {
            Items = await client.GetFromJsonAsync<List<ItemListDto?>>("item");
            itemBindingSource.DataSource = Items;
            grvItem.DataSource = itemBindingSource;
            TransactionLines = await client.GetFromJsonAsync<List<TransactionLineListDto>>("transactionLine");
            transactionLineBindingSource.DataSource = TransactionLines;
            grvTransLine.DataSource = transactionLineBindingSource;
        }
    }
}
