using ExtraConstraints;

public interface IDelegateToOtherFunc
{
    TOther Invoke<[DelegateConstraint]TDelegate, TOther>(TDelegate arg);
}
public abstract class DelegateToOtherFunc : IDelegateToOtherFunc
{
    public abstract TOther Invoke<[DelegateConstraint]TDelegate, TOther>(TDelegate arg);
}

public interface IDelegateToDelegateFunc
{
    TOutput Invoke<[DelegateConstraint]TInput, [DelegateConstraint]TOutput>(TInput arg);
}
public abstract class DelegateToDelegateFunc : IDelegateToDelegateFunc
{
    public abstract TOutput Invoke<[DelegateConstraint]TInput, [DelegateConstraint]TOutput>(TInput arg);
}

public interface IOtherToDelegateFunc
{
    TDelegate Invoke<TOther, [DelegateConstraint]TDelegate>(TOther arg);
}
public abstract class OtherToDelegateFunc : IOtherToDelegateFunc
{
    public abstract TDelegate Invoke<TOther, [DelegateConstraint]TDelegate>(TOther arg);
}

public interface IDelegateAdditiveFunc
{
    T Invoke<[DelegateConstraint]T>(T x, T y);
}
public abstract class DelegateAdditiveFunc : IDelegateAdditiveFunc
{
    public abstract T Invoke<[DelegateConstraint]T>(T x, T y);
}

public interface IDelegateComparativeFunc
{
    TResult Invoke<[DelegateConstraint]TDelegate, TResult>(TDelegate x, TDelegate y);
}
public abstract class DelegateComparativeFunc : IDelegateComparativeFunc
{
    public abstract TResult Invoke<[DelegateConstraint]TDelegate, TResult>(TDelegate x, TDelegate y);
}
