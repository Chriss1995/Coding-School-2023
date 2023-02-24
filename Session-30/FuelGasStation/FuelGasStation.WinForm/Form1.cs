using DevExpress.Mvvm.POCO;
using DevExpress.PivotGrid.Criteria;
using DevExpress.Utils;
using FuelGasStation.Blazor.Shared.Customer;
using System.Net.Http;
using System.Net.Http.Json;
namespace FuelGasStation.WinForm
{
    public partial class Form1 : Form
    {
        CustomerEditDto Customer { get; set; }
        
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

        private async Task CreateCustomer()
        {
            var response = await client.PostAsJsonAsync("customer", Customer);
            response.EnsureSuccessStatusCode();
        }

        private async Task GetCustomer(CustomerEditDto customer)
        {
            var response = await client.GetFromJsonAsync<CustomerEditDto>($"customer/{customer.Id}");
        }
        private async Task EditCustomer(CustomerEditDto customer)
        {
            var response = await client.PutAsJsonAsync("customer", Customer);
            response.EnsureSuccessStatusCode();
        }

        private async Task DeleteCustomer(CustomerListDto customer)
        {
            var response = await client.DeleteAsync($"customer/{customer.Id}");
            response.EnsureSuccessStatusCode();
        }
    }
}