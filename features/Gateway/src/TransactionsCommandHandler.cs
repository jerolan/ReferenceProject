namespace Gateway
{
    using Domain;

    public class TransactionsCommandHandler : ICommandHandler<CreateTransaction>
    {
        public void Handle(CreateTransaction command)
        {
            new Domain.AccountService(null).CreateTransaction(
                new CreateTransactionInput({
                    AccountId = command.AccountId,
                    Concept = command.Concept,
                    Amount = command.Amount,
                    Type = command.Type,
                });
        }
    }
}