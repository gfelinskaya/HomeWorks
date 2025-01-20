using System;
using System.Text;

namespace HW2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a please");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Input b please");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Input c please");
            float c = float.Parse(Console.ReadLine());

            float result = (float)Math.Pow(b,2) - 4 * a * c;
            
            Console.Write($"Дескримінант дорівнює: {result:C}");
        }

    }
}

