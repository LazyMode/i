using ExtraConstraints;

public interface IEnumToOtherFunc
{
    TOther Invoke<[EnumConstraint]TEnum, TOther>(TEnum arg);
}
public abstract class EnumToOtherFunc : IEnumToOtherFunc
{
    public abstract TOther Invoke<[EnumConstraint]TEnum, TOther>(TEnum arg);
}

public interface IEnumToEnumFunc
{
    TOutput Invoke<[EnumConstraint]TInput, [EnumConstraint]TOutput>(TInput arg);
}
public abstract class EnumToEnumFunc : IEnumToEnumFunc
{
    public abstract TOutput Invoke<[EnumConstraint]TInput, [EnumConstraint]TOutput>(TInput arg);
}

public interface IOtherToEnumFunc
{
    TEnum Invoke<TOther, [EnumConstraint]TEnum>(TOther arg);
}
public abstract class OtherToEnumFunc : IOtherToEnumFunc
{
    public abstract TEnum Invoke<TOther, [EnumConstraint]TEnum>(TOther arg);
}

public interface IEnumAdditiveFunc
{
    T Invoke<[EnumConstraint]T>(T x, T y);
}
public abstract class EnumAdditiveFunc : IEnumAdditiveFunc
{
    public abstract T Invoke<[EnumConstraint]T>(T x, T y);
}

public interface IEnumComparativeFunc
{
    TResult Invoke<[EnumConstraint]TEnum, TResult>(TEnum x, TEnum y);
}
public abstract class EnumComparativeFunc : IEnumComparativeFunc
{
    public abstract TResult Invoke<[EnumConstraint]TEnum, TResult>(TEnum x, TEnum y);
}
