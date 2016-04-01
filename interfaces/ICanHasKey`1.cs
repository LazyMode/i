public interface ICanHasKey<T> : IHasKey<T>
{
    bool HasKey { get; }
}
