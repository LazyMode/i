public interface ICanHasSignature<T> : IHasSignature<T>
{
    bool HasSignature { get; }
}
