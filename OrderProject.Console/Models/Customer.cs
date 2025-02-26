namespace OrderProject.Console.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; }
        public decimal Balance { get; private set; }
        public int BalanceIncreaseCount { get; private set; }

        public Customer(string name, string email, decimal balance)
        {
            if (balance < 0)
                throw new InvalidOperationException("A keretösszeg nem lehet negatív!");

            Name = name;
            Email = email;
            Balance = balance;
            BalanceIncreaseCount = 0;
        }

        public void IncreaseBalance(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                BalanceIncreaseCount++;
            }
            else
            {
                throw new InvalidOperationException("A növelés csak pozitív érték lehet!");
            }
        }

        public bool CanPurchase(decimal amount)
        {
            return Balance >= amount;
        }

        public void Purchase(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidOperationException("A vásárlás értéke nem lehet negatív vagy nulla!");

            if (!CanPurchase(amount))
                throw new InvalidOperationException("Nincs elegendő keret a vásárláshoz!");

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Vásárló {Name} ({Email}) -> {Balance} Ft";
        }
    }
}
