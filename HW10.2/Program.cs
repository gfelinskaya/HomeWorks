// створити метод що розаховує суму до сплати. 
//Він приймає три параметри - ціну товару, кількість і розмір знижки. 
//Якщо третій параметр не надано - розмір знижки за промовчуванням 0%

internal class Program
{                       
    static float Calculate(float price, int amount, float discount = 0)
    {

        return amount * (price * (100 - discount) / 100);
    }

    static void Main()
    {
            Console.WriteLine("Input price");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Input amount");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Input discount");
            string discount = Console.ReadLine();
            float parsedDiscount;
            bool success = float.TryParse(discount, out parsedDiscount); 
         if (success)
         {
           Console.WriteLine($"final amount is: {Calculate(price, amount, parsedDiscount)}");
         }
         else
         {
            Console.WriteLine($"final amount is: {Calculate(price, amount)}");
         }

              

    }

}
