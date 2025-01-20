//Створи вивід таблички множення 
//2 * 2 = 4 і так далі до 9 * 9 = 81

internal class Program
{                       
    static string Print(int a, int b)
    {

        return $"{a} * {b} = {a * b}";
    }

    static void Main()
    {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                   Console.WriteLine($"{Print (i, j)}");
                }
            }

    }

}
