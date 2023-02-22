using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using FuelGasStation.Blazor.Shared.TransactionLine;
using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.Blazor.Shared.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<Transaction> _transRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transLineRepo, 
                                          IEntityRepo<Item> itemRepo, 
                                          IEntityRepo<Transaction> transRepo)
        {
            _transLineRepo = transLineRepo;
            _itemRepo = itemRepo;
            _transRepo = transRepo;
        }

        [HttpGet]
        public IEnumerable<TransactionLineListDto> Get()
        {
            var result = _transLineRepo.GetAll();
            return result.Select(tranLine => new TransactionLineListDto
            {
                Id = tranLine.Id,
                Quantity = tranLine.Quantity,
                ItemPrice = tranLine.ItemPrice,
                NetValue = tranLine.NetValue,
                PercentDiscount = tranLine.PercentDiscount,
                DiscountValue = tranLine.DiscountValue,
                TotalValue = tranLine.TotalValue,
                TransactionID = tranLine.TransactionID,
                ItemCode = tranLine.Item.Code,
                ItemID = tranLine.ItemID
            });
        }
        
        [HttpGet("{id}")]
        public TransactionLineEditDto GetById(int id)
        {
            var result= _transLineRepo.GetById(id);
            var items = _itemRepo.GetAll();
            var transactions = _transRepo.GetAll();
            return new TransactionLineEditDto
            {
                Id = result.Id,
                Quantity = result.Quantity,
                ItemPrice = result.ItemPrice,
                NetValue = result.NetValue,
                PercentDiscount = result.PercentDiscount,
                DiscountValue = result.DiscountValue,
                TotalValue = result.TotalValue,
                Items = items.Select(items => new ItemListDto 
                { 
                    Id = items.Id,
                    Code= items.Code,
                    Description = items.Descriptioon,
                    ItemType = items.ItemType,
                    Cost= items.Cost,
                    Price= items.Price
                }).ToList(),
                Transactions = transactions.Select(transactions=> new TransactionListDto
                { 
                    Id = transactions.Id,
                    DateTime= transactions.DateTime,
                    PaymentMetod=transactions.PaymentMetod,
                    TotalValue= transactions.TotalValue,
                    CustomerID= transactions.CustomerID,
                    EmployeeID= transactions.EmployeeID
                }).ToList()
            };
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transactionLine)
        {
            var newTransactionLine = new TransactionLine(transactionLine.Quantity,
                                        transactionLine.ItemPrice, transactionLine.NetValue,
                                        transactionLine.PercentDiscount, transactionLine.DiscountValue,
                                        transactionLine.TotalValue)
            { ItemID = transactionLine.ItemID,
            TransactionID = transactionLine.TransactionID};
            _transLineRepo.Add(newTransactionLine);
        }

        [HttpPut]
        public async Task Put(TransactionLineEditDto transactionLine)
        {
            var itemToUpdate = _transLineRepo.GetById(transactionLine.Id);
            itemToUpdate.Quantity = transactionLine.Quantity;
            itemToUpdate.ItemPrice = transactionLine.ItemPrice;
            itemToUpdate.NetValue= transactionLine.NetValue;
            itemToUpdate.PercentDiscount= transactionLine.PercentDiscount;
            itemToUpdate.DiscountValue= transactionLine.DiscountValue;
            itemToUpdate.TotalValue= transactionLine.TotalValue;
            itemToUpdate.ItemID= transactionLine.ItemID;
            itemToUpdate.TransactionID= transactionLine.TransactionID;
            _transLineRepo.Update(transactionLine.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transLineRepo.Delete(id);
        }
    }
}
