namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence: ");
            string str = Console.ReadLine();
            int res = AmountOfWordsInSentence(str);
            Console.WriteLine($"Amount of words in sentence: {res}");
        }
        public static int AmountOfWordsInSentence(string str) 
        {
            string[] strings = str.Split(' ');
            int counter = 0;
            for(int i = 0; i< strings.Length; i++)
            {
                counter++;
            }
            return counter;
        }
    }
}