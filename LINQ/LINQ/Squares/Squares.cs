using System;
using System.Linq;

class Squares {

    public void RunApp()
    {
        Console.WriteLine("Enter number: ");

        int N = int.Parse(Console.ReadLine());

        var squares = Enumerable.Range(1, N).
            Where(x => x != 5 && x != 9 && (x % 2 != 0 || x % 7 == 0)).
            Select(x => x * x).
            OrderBy(x => x).
            ToList();

        Console.WriteLine(squares.Sum());
        Console.WriteLine(squares.Count());
        Console.WriteLine(squares.First());
        Console.WriteLine(squares.Last());
        Console.WriteLine(squares.Count());
        Console.WriteLine(squares.ElementAt(2));

    }

}