using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//Написати примітивний калькулятор. 
//Користувач вводить перший операнд, другий операнд 
//далі вводить операцію +, *, /, -, %
//Виводимо результат
namespace HW5
{
    class System
    {
        static void Main()
        {
            Console.WriteLine("Введіть перше число");
            string number1 = Console.ReadLine();
            if (!double.TryParse(number1, out double parsed1))        
            {   
                Console.WriteLine("значення один не валідне");
                return;
            }

            Console.WriteLine("Введіть друге число");
            string number2 = Console.ReadLine();
            if (!float.TryParse(number2, out float parsed2))
            {
              Console.WriteLine("значення два не валідне");  
              return;
            }

            Console.WriteLine("Введіть операцію +, *, /, -, %"); 

             string operation = (Console.ReadLine());
             double result = 0;
             switch (operation)
            {
                case "+":
                    result =(parsed1 + parsed2);
                    break;
                case "*":
                    result = parsed1 * parsed2;
                    break;
                case "/":
                    result = parsed1 / parsed2;
                    if (parsed2 == 0)
                    {
                    Console.WriteLine("на нуль ділити не можна");
                    return;
                    }
                    break; 
                case "-":
                    result = parsed1 - parsed2;
                    break;
                case "%":
                    result = parsed1 % parsed2;
                    break;
                default:
                    Console.WriteLine("Ви ввели не валідний символ");
                    return;
            }
        
        Console.WriteLine($"Дорівнює = {result}");
            }
    }
}