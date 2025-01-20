//Задати масив чисел  наприклад [34, 56, -9, -56, 0, 99, -2];
//опрацювати його таким чином в кожному з окремих методів 
//Метод визначає мінімальний елемент масиву 
//Метод визначає максимальний елемент масиву 
//Метод визначає середнє арефметичне елементів масиву 
//Метод повертає суму елементів масиву 
//Метод для виводу масивy
//Застосуй params

 class Program
    {
        static void Main()
        {
            int[] array = { 34, 56, -9, -56, 0, 99, -2 };
            Console.WriteLine($"minimal element is {GetMin(array)}");
            Console.WriteLine($"maximal element is {GetMax(array)}");
            Console.WriteLine($"elements sum is {GetSumm(array)}");
            Console.WriteLine($"elements average is {GetAverage(array)}");
            DisplayElements(array);
        }
        static int GetMin (params int [] array)
         {
            int minimalElement = array[0];
            for (int i = 1; i < array.Count(); i++)
            {
                if (minimalElement < array[i])
                {
                    continue;
                }
                    else 
                    {
                        minimalElement = array[i];
                    }
            }
            return minimalElement;
        }
        static int GetMax (params int [] array)
         {
            int maximalElement = array[0];
            for (int i = 1; i < array.Count(); i++)
            {
                if (maximalElement > array[i])
                {
                    continue;
                }
                    else 
                    {
                        maximalElement = array[i];
                    }
            }
            return maximalElement;
        }
        static int GetSumm (params int [] array)
         {
            int summ = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                summ += array[i];
            }
            return summ;
        }
            static int GetAverage (params int [] array)
         {
            return GetSumm(array)/array.Count();
        }
            static void DisplayElements (params int [] array)
         { 
            for (int i = 0; i < array.Count(); i++) 
            {
                Console.WriteLine($"element number {i} = {array[i]}");
            }
         }
    }
