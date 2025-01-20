using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//Створити програму для обрахування дискримінанту.  
//Отримуємо три змінних (якого типу?) a, b, c 
//браховуємо дискримінант і виводимо результат з інтерполяцією рядка ($) з форматуванням - два знаки після коми
//Переписати програму розрахунку квадртаникх коренів. Винести розрахунок дискримінанта в окремий метод. 

namespace HW8
{
    class System
    {
             static float Descriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b,2) - 4 * a * c;
        }

        static void Main()
        {
            Console.WriteLine("Input a please");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Input b please");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Input c please");
            float c = float.Parse(Console.ReadLine());

            float descriminant = Descriminant(a, b, c);
            
            Console.Write($"Дескримінант дорівнює: {descriminant}");

            float x1;
            float x2;

//Написати програму яка буде вираховувати квадратні корені рівняння. Нагадую що є три сценарія - коли Д <0 Д>0 і Д==0
//Якщо дискримінант менше нуля (D < 0), рівняння не має дійсних коренів.
            if (descriminant < 0)
            {
            Console.WriteLine(" рівняння не має дійсних коренів");
            }
//Якщо дискримінант дорівнює 0 (D = 0), рівняння має один дійсний корінь.
           else if (descriminant == 0)
           {
           Console.WriteLine(" рівняння має один дійсний корінь");
           x1 = -b/(2*a);
           Console.WriteLine($"корінь дорівнює:{x1}");
           }

//Якщо дискримінант більший за 0 (D > 0), рівняння має два різних дійсних коренів.
           else
           {
           Console.WriteLine(" рівняння має два різних дійсних корені.");
           x1 = -b+(float)Math.Sqrt(descriminant)/(2*a);
           x2 = -b-(float)Math.Sqrt(descriminant)/(2*a);
           Console.WriteLine($"перший корінь дорівнює:{x1}, другий корінь дорівнює:{x2}");
           }
        }

    }
}


