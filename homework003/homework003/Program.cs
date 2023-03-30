namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" raqam kiriting: ");
            string son = Console.ReadLine();
            bool isnumber = int.TryParse(son, out int number);
            int raqam1 = 1, raqam2 = 0, yig = -1;
            if (isnumber)
            {
                for (int i = 0; i < number - 1; i = i + 1)
                {
                    yig = raqam1 + raqam2;
                    Console.Write($"{" "}{yig}");
                    raqam1 = raqam2;
                    raqam2 = yig;
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