namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            Console.Write("Enter the length of array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int countPositive = 0;
            int countNegative = 0;
            int[] arrayPositive = new int[length];
            int[] arrayNegative = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
                if (array[i] >= 0)
                {
                    arrayPositive[countPositive] = array[i];
                    countPositive++;
                }
                else
                {
                    arrayNegative[countNegative] = array[i];
                    countNegative++;
                }
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i< countPositive; i++)
            {
                Console.Write($" {arrayPositive[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < countNegative; i++)
            {
                Console.Write($" {arrayNegative[i]}");
            }
        }
    }
}