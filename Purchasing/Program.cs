namespace Purchasing
{
    internal class Program
    {
        static void Main()
        {
            bool isAvailable = true;
            string color = "white";
            double price = 21_000;
            double balance = 25_000;

            //  first condition  second condition            third condition        
            if (isAvailable && price <= balance && (color == "black" || color == "white"))
            {
                Console.WriteLine("Purchasing...");
            }
            else
            {
                Console.WriteLine("Cancel transaction");
            }
        }
    }
}
