using System;
using System.Linq;

public delegate void StackingEventHandler<TArgs>(object sender, TArgs args,
    StackingEventHandler<TArgs> next = null);
public delegate TResult StackingEventHandler<TArgs, TResult>(object sender, TArgs args,
    StackingEventHandler<TArgs, TResult> next = null);

public static class StackingEvent
{
    public static void InvokeStacking<TArgs>(this StackingEventHandler<TArgs> handler, object sender, TArgs args)
    {
        var current = (StackingEventHandler<TArgs>)handler.GetInvocationList().Last();
        var next = handler - current;

        if (next != null)
        {
            var remains = next;
            next = (s, a, n) => InvokeStacking(n ?? remains, s, a);
        }

        current(sender, args, next);
    }

    public static TResult InvokeStacking<TArgs, TResult>(this StackingEventHandler<TArgs, TResult> handler, object sender, TArgs args)
    {
        var current = (StackingEventHandler<TArgs, TResult>)handler.GetInvocationList().Last();
        var next = handler - current;

        if (next != null)
        {
            var remains = next;
            next = (s, a, n) => InvokeStacking(n ?? remains, s, a);
        }

        return current(sender, args, next);
    }
}
