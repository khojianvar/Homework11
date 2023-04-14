namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter word what do you search: ");
            string str2 = Console.ReadLine();
            int res = AmountOfYYY(str1,str2);
            Console.WriteLine($"Output: {res}");
        }
        public static int AmountOfYYY(string str1, string str2)
        {
            int counter = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if ((i < str1.Length-2) && (str1.Substring(i, str2.Length) == str2))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}