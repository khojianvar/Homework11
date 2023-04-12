namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int maxN = Math.Max(a, b);
            int minN = Math.Min(a, b);
            int counter = 0;
            for (int i = minN; i <= maxN; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($" {i}");
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Amount of odd elements: {counter}");
        }
    }
}