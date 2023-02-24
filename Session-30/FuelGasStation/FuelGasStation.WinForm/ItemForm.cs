using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.Model;
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
    public partial class ItemForm : Form
    {
        ItemEditDto Item { get; set; }
        private readonly HttpClient client;
        public ItemForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            itemBindingSource.DataSource = await GetItems();
            grvItem.DataSource = itemBindingSource;
        }
        private async Task<List<ItemListDto?>> GetItems()
        {
            var response = await client.GetFromJsonAsync<List<ItemListDto?>>("item");
            return response.ToList();
        }
        private async Task CreateItem()
        {
            var response = await client.PostAsJsonAsync("item", Item);
            response.EnsureSuccessStatusCode();
        }

        private async Task GetItem(ItemEditDto item)
        {
            var response = await client.GetFromJsonAsync<ItemEditDto>($"item/{item.Id}");
        }
        private async Task EditItem(ItemEditDto item)
        {
            var response = await client.PutAsJsonAsync("item", Item);
            response.EnsureSuccessStatusCode();
        }

        private async Task DeleteItem(ItemListDto item)
        {
            var response = await client.DeleteAsync($"item/{item.Id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
