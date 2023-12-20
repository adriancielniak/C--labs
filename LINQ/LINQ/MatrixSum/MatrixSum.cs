
class MatrixSum
{
    public void RunApp()
    {
        Console.Write("Enter first number: ");
        int N = Int32.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int M = Int32.Parse(Console.ReadLine());

        Random rnd = new Random();

        int[][] matrix = Enumerable.Range(0, N)
            .Select(_ => Enumerable.Range(0, M).Select(__ => rnd.Next(1, 10000)).ToArray())
            .ToArray();

        var matrixSum = matrix.SelectMany(x => x).ToList().Sum();

        Console.WriteLine(matrixSum);
    }
}