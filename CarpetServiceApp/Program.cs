namespace CarpetServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int smallPrice = 25;
            const int largePrice = 35;
            const float taxRate = .06f;
            const int noOfDays = 30;
            Console.Write("Number of small Carpets: ");
            int NoOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large Carpets: ");
            int NoOfLargeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Price per small room: ${smallPrice}");
            Console.WriteLine($"Price per large room: ${largePrice}");
            int Cost = (NoOfSmallCarpets * 25) + (NoOfLargeCarpets * 35);
            Console.WriteLine($"Cost : ${Cost}");
            float Tax = Cost * taxRate;
            Console.WriteLine($"Tax: ${Tax}");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Total estimate: ${Cost + Tax}");
            Console.WriteLine($"This estimate is valid for {noOfDays} days");
        }
    }
}