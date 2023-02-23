using FuelGasStation.Blazor.Shared.Customer;
using System.Net.Http;
using System.Net.Http.Json;
namespace FuelGasStation.WinForm
{
    public partial class Form1 : Form
    {


        private readonly HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();

        }
        private async Task SetControlProperties()
        {
            customerBindingSource.DataSource = await GetCustomers();
            gridControl1.DataSource = customerBindingSource;
        }
        private async Task<List<CustomerListDto?>> GetCustomers()
        {
            var response = await client.GetFromJsonAsync<List<CustomerListDto?>>("customer");
            return response.ToList();
        }
    }
}