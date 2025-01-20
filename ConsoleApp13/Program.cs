// Розробити фільтр товарів. 
//Створити 3 групи змінних, які описуватимуть 3 різних товарів - їх назва, колір, розмір, ціна, доступність 
//- good1Price, good1IsAvaliable... good2Price... 
//Далі створити діалог користувачу - оберіть бажаний колір, бажаний розмір і діапазон цін від і до 
//Вивести тільки ті товари, які відповідають цьому фільтру і в тому ціновому діапазоні, якщо співпадінь не знайдено виводимо - товарів не знайдено
using System.Text;

namespace HW5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;  

            string good1Name = "shirt";
            string good1Color = "black";
            int good1Size = 46;
            double good1Price = 500;
            bool good1IsAvaliable = true;

            string good2Name = "pant";
            string good2Color = "white";
            int good2Size = 42;
            double good2Price = 1000;
            bool good2IsAvaliable = true;

            string good3Name = "boot";
            string good3Color = "pink";
            int good3Size = 46;
            double good3Price = 500;
            bool good3IsAvaliable = true;

            bool doesItMatch = false;


            Console.WriteLine("Введіть колір товару");
            string goodColor = Console.ReadLine();

            if (goodColor.ToLower() == good1Color ||
                goodColor.ToLower() == good2Color ||
                goodColor.ToLower() == good3Color)
            {
                Console.WriteLine("Введіть розмір товару");

                string size = (Console.ReadLine());
                int.TryParse(size, out int goodSize);

                if (goodSize == good1Size ||
                    goodSize == good2Size ||
                    goodSize == good3Size)
                {
                    Console.WriteLine("Введіть мінімальну ціну товару");
                    string minPrice = Console.ReadLine();
                    double.TryParse(minPrice, out double minimumPrice);

                    Console.WriteLine("Введіть максимальну ціну товару");
                    string maxPrice = Console.ReadLine();
                    double.TryParse(maxPrice, out double maximumPrice);


                    if ((minimumPrice <= good1Price && good1Price <= maximumPrice) ||
                        (minimumPrice <= good2Price && good2Price <= maximumPrice) ||
                        (minimumPrice <= good3Price && good3Price <= maximumPrice))
                    {
                        if (goodColor == good1Color &&
                            goodSize == good1Size &&
                            minimumPrice <= good1Price &&
                            maximumPrice <= good1Price &&
                            good1IsAvaliable)
                        {
                            Console.WriteLine(good1Name);
                            Console.WriteLine(good1Price);
                            doesItMatch = true;
                        }
                        if (goodColor == good2Color &&
                            goodSize == good2Size &&
                            minimumPrice <= good2Price &&
                            maximumPrice <= good2Price &&
                            good1IsAvaliable)
                        {
                            Console.WriteLine(good2Name);
                            Console.WriteLine(good2Price);
                            doesItMatch = true;
                        }
                        if (goodColor == good3Color &&
                            goodSize == good3Size &&
                            minimumPrice <= good3Price &&
                            maximumPrice >= good3Price &&
                            good1IsAvaliable)
                        {
                            // minPrice <= goodPrice <= maxPrice
                            Console.WriteLine(good3Name);
                            Console.WriteLine(good3Price);

                            doesItMatch = true;
                        }

                        if (!doesItMatch)
                        {
                            Console.WriteLine("Товарів не знайдено!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Товарів не знайдено!");
                    }
                }
                else
                {
                    Console.WriteLine("Товарів не знайдено!");
                }
            }
            else
            {
                Console.WriteLine("Товарів не знайдено!");
            }
        }
    }
}
















