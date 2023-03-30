namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 1 son kiriting: ");
            string son = Console.ReadLine();
            bool isnumber = int.TryParse(son, out int number);
            Console.Write(" 2 son kiriting: ");
            string sonn = Console.ReadLine();
            bool isnumber2 = int.TryParse(sonn, out int number2);
            if (isnumber && isnumber2)
            {
                for (int i; number <= number2; number++)
                {
                    if (number2 % number == 0)
                    {
                        Console.Write(number + " ");
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