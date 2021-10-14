
namespace Gateway
{
    using System.Collections.Generic;

    public interface TransactionsDao
    { 
        IEnumerable<TransactionProxy> FindAll();
    }
}