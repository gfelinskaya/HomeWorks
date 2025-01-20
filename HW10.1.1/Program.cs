//Будуємо метод привітання. В двох версіях:
//Одна з версій приймає текст привітання, і кількість раз його відображення. 
//Відображаємо стільки раз привітання на консоль скільки передано число. 
//Якщо текст привітання не передано - даємол станадартне "Nice to meet you in our team". 
//Також треба ще одна версія методу, яка приймає два параметри один текст привітання (зі значенням за змовчуванням), 
//другий - текстом кількість раз виводу привітання на екран. "one", "two" - і так до 5  - 
//цей метод всередині повинен перевикликати версію яка приймає текст і число

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
            int parsedCount = (count.ToLower()) switch 
            {
                "one" => 1,     
                "two" => 2,
                "three" => 3,
                "four" => 4,
                "five" => 5,
                _ => 0         
            };

            Greatings(parsedCount, text);
        }

        static void Main()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            Console.WriteLine("Input count");
            string count = Console.ReadLine();

            if (count != null)
            {
                bool isNumber = int.TryParse(count, out int parsedCount);

                if (isNumber)
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        Greatings(parsedCount);
                    }
                    else
                        Greatings(parsedCount, text);
                }
                else
                {

                    if (text == null)
                        Greatings(count);
                    else
                        Greatings(count, text);
                }
            }            
        }
    }