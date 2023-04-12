namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[m];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 10);
                    Console.Write($" {array[i][j]}");
                }
                Console.WriteLine();
            }
            int diagonalSum = 0;
            int lastColumnSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (i == j)
                    {
                        diagonalSum += array[i][j];
                    }
                    if (j == array[i].Length-1)
                    {
                        lastColumnSum += array[i][j];
                    }
                }
            }
            Console.WriteLine($"Diagonal`s sum: {diagonalSum}, Last Column`s sum: {lastColumnSum}");
            if(diagonalSum>lastColumnSum)
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