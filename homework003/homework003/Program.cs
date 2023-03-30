namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 1 number: ");
            string son1 = Console.ReadLine();
            bool isnumber1 = double.TryParse(son1, out double number1);
            if (isnumber1)
            {
                Console.Write(" 2number: ");
                string son2 = Console.ReadLine();
                bool isnumber2 = double.TryParse(son2, out double number2);
                if (isnumber2)
                {
                    Console.Write(" 3 number: ");
                    string son3 = Console.ReadLine();
                    bool isnumber3 = double.TryParse(son3, out double number3);
                    if (isnumber3)
                    {
                        Console.Write(" 4 number: ");
                        string son4 = Console.ReadLine();
                        bool isnumber4 = double.TryParse(son4, out double number4);
                        if (isnumber4)
                        {
                            double max = Math.Max(Math.Max(number1, number2), Math.Max(number3, number4));
                            Console.WriteLine(" Maximum: " + max);
                            double min = Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
                            Console.WriteLine(" Minimum: " + min);
                            Console.WriteLine($"{" Faqri: "}{max}-{min}={max - min}");
                        }
                        else
                        {
                            Console.WriteLine(" Faqat son kirita olasiz !!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Faqat son kirita olasiz !!!");
                    }
                }
                else
                {
                    Console.WriteLine(" Faqat son kirita olasiz !!!");
                }
            }
            else
            {
                Console.WriteLine(" Faqat son kirita olasiz !!!");
            }
            Main(args);
        }
    }
}