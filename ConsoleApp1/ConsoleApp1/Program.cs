namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[m];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(-10, 10);
                    sum += array[i][j];
                    Console.Write($" {array[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Amount of array`s elements: {n*m}");
            Console.WriteLine($"Sum of array`s elements: {sum}");
            if(sum>n*m)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}