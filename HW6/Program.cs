Console.WriteLine("Обрахую суму чисел в певному діапазоні. Введіть число від");
string input1 = Console.ReadLine();
Console.WriteLine("Введіть число до");
string input2 = Console.ReadLine();

// Перевірка, чи введені значення є цілими числами
if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
{
    int sum = 0;

    // Перевірка на правильність діапазону
    if (number1 > number2)
    {
        Console.WriteLine("Невірний діапазон: перше число повинно бути меншим або рівним другому.");
        return;
    }

    // Обчислення суми чисел у діапазоні
    for(int i = number1; i <= number2; i++)
    {
        sum += i;  

    } 

    // Виведення результату
    Console.WriteLine($"Сума чисел в діапазоні від {input1} до {input2} = {sum}");
    // Виведення парних чисел в цьому діапазоні
    Console.WriteLine($"Парні числа в діапазоні від {input1} до {input2}");
    for(int i = number1; i <= number2; i++)
    {
       if (i % 2 ==0) 
       {
        Console.WriteLine($"{i}");
       }
    } 
    
    // Виведення середнього арифметичного
    Console.WriteLine($"Середнє арифметичне в діапазоні від {input1} до {input2} = {(float)sum/(number2-number1)}");

}
else
{
    Console.WriteLine("Введено некоректні значення. Будь ласка, введіть цілі числа.");
}