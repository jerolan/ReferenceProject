namespace Gateway
{
    public interface ICommandHandler<T>
    {
        void Handle(T command);
    }
}