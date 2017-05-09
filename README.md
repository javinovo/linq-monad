# Monads with LINQ

Trying monads with LINQ in .NET Core. Based on "Understand monads with LINQ" at http://codewithstyle.info/understand-monads-linq/ origin of the following quote:

> **Ok, so what’s exactly a Monad?**
>
> Monad is any generic type which implements SelectMany (strictly speaking, this is far from a formal definition, but I think it’s sufficient in this context and captures the core idea).
>
> SelectMany is a slightly more general version of an operation which in the functional programming world is referred to as bind.
>
> Monadic types are like wrappers around some values. Binding monads is all about composing them. By wrapping and unwrapping of the values inside monads, we can perform additional operations (such as handling empty results in our case) and hide them away from the user.
>
> Maybe is a classic example of a monad. Another great candidate for monad is C#’s Task<T> type. You can think of it as a type that wraps some value (the one that will be returned when the task completes). By combining tasks you describe that one task should be executed after the other finishes.

