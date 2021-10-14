namespace Domain
{
    public record Transaction : Entity
    {
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
    }
}