namespace FuelGasStation.Model
{
    public class Customer
    {
        public Customer(string name, string surname, string cardNumber) 
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Transactions = new List<Transaction>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        //Relations
        public List<Transaction> Transactions { get; set; }
    }
}