using DevExpress.Mvvm.POCO;
using DevExpress.PivotGrid.Criteria;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using FuelGasStation.Blazor.Shared.Customer;
using FuelGasStation.Blazor.Shared.Item;
using System.Net.Http;
using System.Net.Http.Json;
namespace FuelGasStation.WinForm
{
    public partial class Form1 : Form
    {
        CustomerEditDto Customer { get; set; }
        public virtual NavigatorButton Append { get; }
        
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            customerBindingSource.DataSource =  CreateCustomer();
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

        private async Task GetItem(CustomerEditDto customer)
        {
            var response = await client.GetFromJsonAsync<ItemEditDto>($"customer/{customer.Id}");
        }
        private async Task EditItem(CustomerEditDto item)
        {
            var response = await client.PutAsJsonAsync("item", Customer);
            response.EnsureSuccessStatusCode();
        }

        private async Task DeleteItem(CustomerListDto customer)
        {
            var response = await client.DeleteAsync($"customer/ {customer.Id}");
            response.EnsureSuccessStatusCode();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

        }


    }
}