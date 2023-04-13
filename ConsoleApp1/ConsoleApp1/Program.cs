namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence: ");
            string str = Console.ReadLine();
            StrSoz(str);
        }
        public static void StrSoz(string str)
        {

            string sentence = str.ToLower();
            string[] strings = sentence.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(0, 1).ToUpper() + strings[i].Substring(1);

                Console.Write($"{strings[i]} ");
            }
        }
    }
}