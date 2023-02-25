using DevExpress.Mvvm.POCO;
using DevExpress.PivotGrid.Criteria;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using FuelGasStation.Blazor.Shared.Customer;
using FuelGasStation.Model;
using System.Net.Http;
using System.Net.Http.Json;
namespace FuelGasStation.WinForm
{
    public partial class Form1 : Form
    {
        List<CustomerListDto> Customers { get; set; }
        public virtual NavigatorButton Append { get; }
        
        private readonly HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetControlProperties();

        }
        private async void SetControlProperties()
        {
            Customers = await client.GetFromJsonAsync<List<CustomerListDto?>>("customer");
            customerBindingSource.DataSource = Customers;
            gridControl1.DataSource = customerBindingSource;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerListDto customer = customerBindingSource.Current as CustomerListDto;
            var response = await client.PostAsJsonAsync("customer", customer);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Customer Created!");
            SetControlProperties();

        }
        private async void btnDelet_Click(object sender, EventArgs e)
        {
            CustomerListDto customer = customerBindingSource.Current as CustomerListDto;
            var response = await client.DeleteAsync($"customer/ {customer.Id}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Customer Deleted!");
            SetControlProperties();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerListDto customer = customerBindingSource.Current as CustomerListDto;
            var response = await client.PutAsJsonAsync("customer", customer);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Customer Changes Saved!");
            SetControlProperties();
        }
    }
}