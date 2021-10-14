namespace Domain
{
    using System;

    public class CreateTransactionInput
    {
        public Guid AccountId { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
    }
}