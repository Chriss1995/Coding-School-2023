using FuelGasStation.Blazor.Client.Pages.Item;
using FuelGasStation.Blazor.Server.Controllers;
using FuelGasStation.Model.Enums;
using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.Blazor.Shared.Transaction;
using FuelGasStation.Blazor.Shared.TransactionLine;
using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using Microsoft.EntityFrameworkCore.Storage;

namespace FuelGasStation.Busimess
{
    public class Business
    {
        private readonly IEntityRepo<Transaction> _transRepo;
        private readonly IEntityRepo<Customer> _custRepo;
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private readonly IEntityRepo<Item> _itemRepo;
         TransactionEditDto transaction { get; set; }
        TransactionLineEditDto TransactionLine { get; set; }
        public Business(IEntityRepo<Transaction> transRepom, 
                        IEntityRepo<Customer> custRepo,
                        IEntityRepo<TransactionLine> transLineRepo, 
                        IEntityRepo<Item> itemRepo)
        {
            _transRepo = transRepom;
            _custRepo= custRepo;
            _transLineRepo = transLineRepo;
            _itemRepo = itemRepo;
        }
        
        public decimal CalNetValue (TransactionLineEditDto transactionLine)
        {
            transactionLine.NetValue = transactionLine.ItemPrice * transactionLine.Quantity;
            return transactionLine.NetValue;
        }
        
        public decimal CalcDiscount(TransactionLineEditDto transactionLine)
        {
            transactionLine.DiscountValue = transactionLine.NetValue * transactionLine.PercentDiscount;
            return transactionLine.DiscountValue;
        }
        public decimal CalcTotal(TransactionLineEditDto transactionLine)
        {
            transactionLine.TotalValue = transactionLine.NetValue - transactionLine.DiscountValue;
            return transactionLine.TotalValue;
        }
       
    }
}