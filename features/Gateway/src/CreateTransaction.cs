using System;

namespace Gateway
{
    public class CreateTransaction : Domain.CreateTransactionInput, ICommand
    {
        public Guid Id { get; }
    }
}