namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Raqam kiriting: ");
            string son = Console.ReadLine();
            bool isnumber = int.TryParse(son, out int value);
            int soni = 0;
            if (isnumber)
            {
                for (int i = 1; i <= value; i++)
                {
                    if (value % i == 0) soni++;
                }
                if (soni == 2)
                {
                    Console.WriteLine($"{" Tub son: "}{value}");
                }
                else
                {
                    Console.WriteLine(" Tub son emas ");
                }
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            }
            Main(args);
        }
    }
}