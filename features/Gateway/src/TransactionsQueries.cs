using System.Collections.Generic;

namespace Gateway
{
    public class TransactionsQueries : TransactionsDao
    {
        public IEnumerable<TransactionProxy> FindAll()
        {
            return new Domain.AccountService(null).GetTransactions() 
                as IEnumerable<TransactionProxy>;
        }
    }
}