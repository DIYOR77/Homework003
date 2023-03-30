namespace homework003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number : ");
            string son = Console.ReadLine();
            int raqam;
            bool isnumber = int.TryParse(son, out raqam);
            if (isnumber)
            {
                string binaryNUmber = Convert.ToString(raqam, 2);
                Console.WriteLine("BinaryNumber: " + binaryNUmber);
            }
            else
            {
                Console.WriteLine(" Faqat son butun son kirita olasz !!!");
            }
            Main(args);
        }
    }
}