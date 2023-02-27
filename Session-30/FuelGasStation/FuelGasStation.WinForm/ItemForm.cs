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
        List<ItemListDto> Items { get; set; }
        private readonly HttpClient client;
        public ItemForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7222/");
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {

            Items = await client.GetFromJsonAsync<List<ItemListDto?>>("item");
            itemBindingSource.DataSource = Items;
            grvItem.DataSource = itemBindingSource;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            ItemListDto item = itemBindingSource.Current as ItemListDto;
            var response = await client.PostAsJsonAsync("item", item);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Item Created!");
            SetControlProperties();
        }

        private async void dntDekete_Click(object sender, EventArgs e)
        {
            ItemListDto item = itemBindingSource.Current as ItemListDto;
            var response = await client.DeleteAsync($"item/ {item.Id}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Item Deleted!");
            SetControlProperties();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            ItemListDto item = itemBindingSource.Current as ItemListDto;
            var response = await client.PutAsJsonAsync("item", item);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Item Changes Saved!");
            SetControlProperties();
        }
    }
}
