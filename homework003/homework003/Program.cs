namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" son kiriting: ");
            string son = Console.ReadLine();
            bool isnumber = int.TryParse(son, out int raqam);
            if (isnumber)
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % raqam == 0 && i % 2 == 0)
                    {
                        Console.Write(" " + i);
                    }
                }
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasz !!!");
            }
            Main(args);
        }
    }
}