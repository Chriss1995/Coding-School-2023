using FuelGasStation.Blazor.Shared.Employee;
using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get()
        {
            var result = _itemRepo.GetAll();
            return result.Select(Item => new ItemListDto
            {
                Id = Item.Id,
                Code = Item.Code,
                Description = Item.Descriptioon,
                ItemType = Item.ItemType,
                Cost= Item.Cost,
                Price = Item.Price
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemEditDto> GetById(int id)
        {
            var result = _itemRepo.GetById(id);
            return new ItemEditDto
            {
                Id = result.Id,
                Code = result.Code,
                Description = result.Descriptioon,
                ItemType = result.ItemType,
                Cost = result.Cost,
                Price = result.Price
            };
        }

        [HttpPost]
        public async Task Post(ItemEditDto item)
        {
            var newItem = new Item(item.Code, item.Description, item.ItemType, item.Cost, item.Price);
            
            _itemRepo.Add(newItem);
        }

        [HttpPut]
        public async Task Put(ItemEditDto item)
        {
            var itemToUpdate = _itemRepo.GetById(item.Id);
            itemToUpdate.Code = item.Code;
            itemToUpdate.Descriptioon = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.Price = item.Price;
            _itemRepo.Update(item.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            _itemRepo.Delete(id);
            return Ok();
        }
    }
}
