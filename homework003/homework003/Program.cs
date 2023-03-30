namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" son kiriting: ");
            string son = Console.ReadLine();
            bool isnumber = int.TryParse(son, out int raqam);
            int faktorial = 1;
            if (isnumber)
            {
                for (int i = 1; i <= raqam; i++)
                {
                    faktorial *= i;
                }
                Console.WriteLine($"{" Faktoriali: "}{faktorial}");
            }
            else
            {
                Console.Write(" Faqat son butun son kirita olasz !!!");
            }
            Main(args);
        }
    }
}