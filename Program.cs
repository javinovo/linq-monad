using System;
using static MaybeFactory;

// Based on the article "Understand monads with LINQ" (http://codewithstyle.info/understand-monads-linq/)

class Program
{
    static void Main(string[] args)
    {
        // Maybe.Select

        Maybe<int> age = Some(27);
        Maybe<string> result = from x in age select $"I'm {x} years old";

        Console.WriteLine(result.Value);
        
        var empty = from x in None<int>() select "test";
        
        Console.WriteLine(empty.HasValue);

        // Maybe.SelectMany

        var person = new Person { Name = "John" };
        var monadicPerson = Some(new MonadicPerson { Name = "Jack"});

        monadicPerson.GetSupervisorName();
    }
}

