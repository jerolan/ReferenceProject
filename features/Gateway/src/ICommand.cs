using System;

namespace Gateway
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}