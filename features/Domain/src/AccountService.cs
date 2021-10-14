
using System.Collections.Generic;

namespace Domain
{
    using System;
    using System.Linq;

    public class AccountService
    {
        private IRepository<Account> repository;

        public AccountService(IRepository<Account> repository)
        {
            this.repository = repository;
        }

        public Transaction CreateTransaction(CreateTransactionInput input)
        {
            var sourceAccount = this.repository
                .Find(a => a.Id.Equals(input.AccountId))
                .First();

            if (sourceAccount.Amount < input.Amount)
            {
                throw new Exception("No money :c");
            }

            var transaction = new Transaction
            {
                Concept = input.Concept,
                Type = input.Type,
                Amount = input.Amount,
            };

            var updatedAccount = sourceAccount with
            {
                Transactions = sourceAccount.Transactions.Append(transaction)
            };

            this.repository.Update(updatedAccount);
            return transaction;
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return this.repository.All().SelectMany(a => a.Transactions);
        }
    }
}
