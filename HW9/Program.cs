// Створити метод оплати в Інтернеті. 
//Ми передаємо суму і наш баланс отримуємо результат як успішна операція/не успішна і присилаємо новий баланс за вичотом внесеної суми. 
//Треба подумати що повертає метод які параметри треба задати. 
//В методі мейн викликаємо метод 10 раз і передаємо кожен раз суму сплати збільшену вдвічі у метод. 
//Виводимо в кінці поточний баланс на екран


internal class Program
{                       
    static float Transaction(float price, float balance, out bool isTransactionSucceeded)
    {
        float transactionResult = balance - price;

        isTransactionSucceeded = (transactionResult >= 0); 
       
        return transactionResult;
    }

    static void Main()
    {
            Console.WriteLine("Input your balance amount");
            float balance = float.Parse(Console.ReadLine());
            Console.WriteLine("Input product price");
            float price = float.Parse(Console.ReadLine());

            //float transaction = Transaction(price, balance, out isTransactionSucceeded);
            float newBalance = balance;
            for (int i = 0; i <= 10; i++)
            {
                balance = Transaction(price, balance, out bool isTransactionSucceeded);
                if (!isTransactionSucceeded)
                {
                    Console.WriteLine($"Your balance is {newBalance} - not enough money. Good bye");
                    return;
                }

                price *= 2; 

                Console.WriteLine($"price {price}");
                Console.WriteLine($"New balance is {newBalance}");
            }

        Console.WriteLine($"Your balance is {newBalance}. All operations are succeeded. Good bye");
    }

}
