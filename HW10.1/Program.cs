//Будуємо метод привітання. В двох версіях:
//Одна з версій приймає текст привітання, і кількість раз його відображення. 
//Відображаємо стільки раз привітання на консоль скільки передано число. 
//Якщо текст привітання не передано - даємол станадартне "Nice to meet you in our team". 
//Також треба ще одна версія методу, яка приймає два параметри один текст привітання (зі значенням за змовчуванням), 
//другий - текстом кількість раз виводу привітання на екран. "one", "two" - і так до 5  - 
//цей метод всередині повинен перевикликати версію яка приймає текст і число

using System.Linq.Expressions;

internal class Program
{                       
    static void Greatings(int count, string text = "Nice to meet you in our team")
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(text);
        }
    }
    static void Greatings(string count, string text = "Nice to meet you in our team")
    {
        int parsedCount = 0;
        switch (count.ToLower())
    {
        case  "one":
            parsedCount = 1;
            break;

        case "two":
            parsedCount = 2;
            break;

        case "three":
            parsedCount = 3;
            break;

        case "four":
            parsedCount = 4;
            break;

        case "five":
            parsedCount = 5;
            break;

        default:
            Console.WriteLine($"Invalid count paremeter");
            break;
    }
            Greatings(parsedCount, text);
    }
    static void Main()
    {
            Console.WriteLine("Input text");
            string text = (Console.ReadLine());
            Console.WriteLine("Input count");
            string count = Console.ReadLine();
            int parsedCount;
            bool success = int.TryParse(count, out parsedCount); 
            if (success)
            {
            if (text == null || text == string.Empty)
            {
                Greatings (parsedCount);
            }
            else
            {
                Greatings (parsedCount, text);
            }
         }
         else
         {
            Greatings (count, text);
         }
}
}
