namespace Domain
{
    using System.Collections.Generic;

    public record Account : Entity
    {
        public IEnumerable<Transaction> Transactions { get; set; }
        public decimal Amount { get; set; }
    }
}